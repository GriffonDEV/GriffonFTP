import discord
from discord.ext import commands
import subprocess
import requests
import os
import glob

# ─────────────────────────────────────────
#  CONFIGURACIÓN — edita estos valores
# ─────────────────────────────────────────

BOT_TOKEN = ".."

# Arma 3 — carpeta donde están armaserver y los .sh de presets
ARMA_DIR          = "/home/steam/arma3gfn"
ARMA_TMUX_SESSION = "arma3"          # nombre de la sesión tmux para Arma 3

# TS3 — LinuxGSM script
TS3_LGSM = "/home/steam/ts3/ts3server"         # script de LinuxGSM

# Canal permitido (None = cualquier canal)
ALLOWED_CHANNEL_ID = 693671125179432990

# ─────────────────────────────────────────
#  SETUP
# ─────────────────────────────────────────

intents = discord.Intents.default()
intents.message_content = True

bot = commands.Bot(command_prefix="!", intents=intents)

# ─────────────────────────────────────────
#  HELPERS — IP
# ─────────────────────────────────────────

def get_public_ip() -> str:
    for url in ["https://api.ipify.org", "https://ifconfig.me/ip"]:
        try:
            return requests.get(url, timeout=5).text.strip()
        except Exception:
            continue
    return "No disponible"

# ─────────────────────────────────────────
#  HELPERS — TMUX (Arma 3)
# ─────────────────────────────────────────

def tmux_session_exists(session: str) -> bool:
    """Devuelve True si la sesión tmux existe."""
    result = subprocess.run(
        ["tmux", "has-session", "-t", session],
        capture_output=True
    )
    return result.returncode == 0

def tmux_start(session: str, script_name: str) -> str:
    """Crea una sesión tmux nueva y ejecuta el .sh dentro."""
    script_path = os.path.join(ARMA_DIR, script_name)
    if not os.path.isfile(script_path):
        return f"Archivo no encontrado: `{script_path}`"
    try:
        os.chmod(script_path, 0o755)
        subprocess.run(
            ["tmux", "new-session", "-d", "-s", session, "-c", ARMA_DIR,
             "bash", script_path],
            check=True
        )
        return "ok"
    except subprocess.CalledProcessError as e:
        return f"Error tmux: {e}"
    except Exception as e:
        return f"Error: {e}"

def tmux_stop(session: str) -> str:
    """Mata la sesión tmux de Arma 3."""
    if not tmux_session_exists(session):
        return "no_session"
    try:
        subprocess.run(["tmux", "kill-session", "-t", session], check=True)
        return "ok"
    except Exception as e:
        return f"Error: {e}"

def tmux_restart(session: str, script_name: str) -> str:
    """Para la sesión tmux existente y lanza de nuevo con el mismo .sh."""
    tmux_stop(session)
    return tmux_start(session, script_name)

# ─────────────────────────────────────────
#  HELPERS — LINUXGSM (TS3)
# ─────────────────────────────────────────

def lgsm_run(action: str) -> str:
    """Ejecuta una acción de LinuxGSM (start | stop | restart)."""
    try:
        result = subprocess.run(
            [TS3_LGSM, action],
            capture_output=True, text=True, timeout=30
        )
        # LinuxGSM devuelve 0 en éxito
        if result.returncode == 0:
            return "ok"
        # Mensaje de error desde stderr o stdout
        err = (result.stderr or result.stdout or "").strip()
        return err if err else f"Código de salida: {result.returncode}"
    except subprocess.TimeoutExpired:
        return "Timeout: LinuxGSM tardó demasiado"
    except PermissionError:
        return f"Sin permisos para ejecutar: `{TS3_LGSM}`\nVerifica que el bot corra como el usuario `steam`."
    except Exception as e:
        return f"Error: {e}"

def is_ts3_running() -> bool:
    result = subprocess.run(
        [TS3_LGSM, "status"],
        capture_output=True, text=True
    )
    return "running" in (result.stdout + result.stderr).lower()

# ─────────────────────────────────────────
#  HELPERS — PRESETS
# ─────────────────────────────────────────

def get_presets() -> list[str]:
    pattern = os.path.join(ARMA_DIR, "*.sh")
    return sorted([os.path.basename(f) for f in glob.glob(pattern)])

# ─────────────────────────────────────────
#  HELPERS — EMBED
# ─────────────────────────────────────────

def build_embed(title, description, color, fields=None) -> discord.Embed:
    embed = discord.Embed(title=title, description=description, color=color)
    for f in (fields or []):
        embed.add_field(name=f["name"], value=f["value"], inline=f.get("inline", True))
    embed.set_footer(text="Griffon Bot 🦅")
    return embed

async def check_channel(ctx) -> bool:
    if ALLOWED_CHANNEL_ID and ctx.channel.id != ALLOWED_CHANNEL_ID:
        await ctx.send("❌ Comando no habilitado en este canal.")
        return False
    return True

# ─────────────────────────────────────────
#  VIEW — SELECCIÓN DE PRESET (Arma 3 start)
# ─────────────────────────────────────────

class PresetButton(discord.ui.Button):
    def __init__(self, script_name: str, index: int, action: str = "start"):
        label = script_name.replace(".sh", "")
        styles = [
            discord.ButtonStyle.primary,
            discord.ButtonStyle.success,
            discord.ButtonStyle.secondary,
            discord.ButtonStyle.danger,
        ]
        super().__init__(
            label=label,
            style=styles[index % len(styles)],
            custom_id=f"{action}_{script_name}",
        )
        self.script_name = script_name
        self.action = action  # "start" o "restart"

    async def callback(self, interaction: discord.Interaction):
        for child in self.view.children:
            child.disabled = True

        verb = "Reiniciando" if self.action == "restart" else "Iniciando"
        await interaction.response.edit_message(
            embed=build_embed(
                title=f"⏳ {verb} Arma 3...",
                description=f"Preset: **{self.script_name.replace('.sh', '')}**",
                color=discord.Color.yellow(),
            ),
            view=self.view,
        )

        if self.action == "restart":
            result = tmux_restart(ARMA_TMUX_SESSION, self.script_name)
        else:
            result = tmux_start(ARMA_TMUX_SESSION, self.script_name)

        if result == "ok":
            embed = build_embed(
                title="🟢 Arma 3 iniciado",
                description=f"Preset **{self.script_name.replace('.sh', '')}** corriendo en tmux `{ARMA_TMUX_SESSION}`.",
                color=discord.Color.green(),
                fields=[
                    {"name": "Puerto",       "value": "2402 (UDP)",         "inline": True},
                    {"name": "Ver consola",  "value": f"`tmux a -t {ARMA_TMUX_SESSION}`", "inline": True},
                ],
            )
        else:
            embed = build_embed(
                title="🔴 Error al iniciar Arma 3",
                description=result,
                color=discord.Color.red(),
            )

        await interaction.edit_original_response(embed=embed, view=self.view)


class PresetView(discord.ui.View):
    def __init__(self, presets: list[str], action: str = "start"):
        super().__init__(timeout=60)
        for i, script in enumerate(presets):
            self.add_item(PresetButton(script, i, action=action))

    async def on_timeout(self):
        for child in self.children:
            child.disabled = True

# ─────────────────────────────────────────
#  VIEW — CONFIRMACIÓN DE SHUTDOWN
# ─────────────────────────────────────────

class ShutdownView(discord.ui.View):
    def __init__(self):
        super().__init__(timeout=30)

    @discord.ui.button(label="✅ Confirmar apagado", style=discord.ButtonStyle.danger)
    async def confirm(self, interaction: discord.Interaction, button: discord.ui.Button):
        for child in self.children:
            child.disabled = True
        await interaction.response.edit_message(
            embed=build_embed(
                title="⏳ Apagando servidor...",
                description="Deteniendo todos los servicios...",
                color=discord.Color.yellow(),
            ),
            view=self,
        )

        lines = []

        # Detener Arma 3
        r_arma = tmux_stop(ARMA_TMUX_SESSION)
        if r_arma == "ok":
            lines.append("🟢 Arma 3 detenido")
        elif r_arma == "no_session":
            lines.append("⚪ Arma 3 ya estaba detenido")
        else:
            lines.append(f"🔴 Arma 3: {r_arma}")

        # Detener TS3
        r_ts3 = lgsm_run("stop")
        lines.append("🟢 TS3 detenido" if r_ts3 == "ok" else f"🔴 TS3: {r_ts3}")

        embed = build_embed(
            title="🛑 Servidor apagado",
            description="\n".join(lines),
            color=discord.Color.dark_red(),
        )
        await interaction.edit_original_response(embed=embed, view=self)

    @discord.ui.button(label="❌ Cancelar", style=discord.ButtonStyle.secondary)
    async def cancel(self, interaction: discord.Interaction, button: discord.ui.Button):
        for child in self.children:
            child.disabled = True
        await interaction.response.edit_message(
            embed=build_embed(
                title="✅ Apagado cancelado",
                description="No se realizó ningún cambio.",
                color=discord.Color.green(),
            ),
            view=self,
        )

# ─────────────────────────────────────────
#  EVENTOS
# ─────────────────────────────────────────

@bot.event
async def on_ready():
    print(f"✅ Griffon Bot conectado como {bot.user} (ID: {bot.user.id})")
    await bot.change_presence(activity=discord.Game(name="!help | Griffon Server"))

# ─────────────────────────────────────────
#  COMANDOS — ARMA 3
# ─────────────────────────────────────────

@bot.command(name="arma", help="Inicia Arma 3 eligiendo un preset.")
async def cmd_arma(ctx):
    if not await check_channel(ctx): return

    if tmux_session_exists(ARMA_TMUX_SESSION):
        await ctx.send(embed=build_embed(
            title="⚠️ Arma 3",
            description=f"El servidor **ya está corriendo** en tmux `{ARMA_TMUX_SESSION}`.\nUsa `!stop arma` para detenerlo o `!restart arma` para reiniciarlo.",
            color=discord.Color.orange(),
        ))
        return

    presets = get_presets()
    if not presets:
        await ctx.send(embed=build_embed(
            title="❌ Sin presets",
            description=f"No se encontraron `.sh` en `{ARMA_DIR}`",
            color=discord.Color.red(),
        ))
        return

    preset_list = "\n".join(f"• `{p.replace('.sh', '')}`" for p in presets)
    embed = build_embed(
        title="🎮 Selecciona un preset de Arma 3",
        description=f"**{len(presets)}** presets disponibles:\n\n{preset_list}\n\n⬇️ Elige con los botones",
        color=discord.Color.blurple(),
    )
    await ctx.send(embed=embed, view=PresetView(presets, action="start"))


@bot.command(name="stop", help="Detiene Arma 3 o TS3. Uso: !stop arma | !stop ts3")
async def cmd_stop(ctx, servicio: str = None):
    if not await check_channel(ctx): return

    if servicio is None:
        await ctx.send(embed=build_embed(
            title="❓ Uso correcto",
            description="`!stop arma` — detiene Arma 3\n`!stop ts3` — detiene TeamSpeak 3",
            color=discord.Color.orange(),
        ))
        return

    servicio = servicio.lower()

    if servicio == "arma":
        async with ctx.typing():
            result = tmux_stop(ARMA_TMUX_SESSION)
        if result == "ok":
            embed = build_embed("🛑 Arma 3 detenido", f"Sesión tmux `{ARMA_TMUX_SESSION}` cerrada.", discord.Color.red())
        elif result == "no_session":
            embed = build_embed("⚪ Arma 3", "El servidor ya estaba detenido.", discord.Color.light_grey())
        else:
            embed = build_embed("🔴 Error", result, discord.Color.red())
        await ctx.send(embed=embed)

    elif servicio == "ts3":
        async with ctx.typing():
            result = lgsm_run("stop")
        if result == "ok":
            embed = build_embed("🛑 TS3 detenido", "TeamSpeak 3 detenido correctamente.", discord.Color.red())
        else:
            embed = build_embed("🔴 Error al detener TS3", result, discord.Color.red())
        await ctx.send(embed=embed)

    else:
        await ctx.send(embed=build_embed(
            title="❓ Servicio no reconocido",
            description="Usa `!stop arma` o `!stop ts3`",
            color=discord.Color.orange(),
        ))


@bot.command(name="restart", help="Reinicia Arma 3 o TS3. Uso: !restart arma | !restart ts3")
async def cmd_restart(ctx, servicio: str = None):
    if not await check_channel(ctx): return

    if servicio is None:
        await ctx.send(embed=build_embed(
            title="❓ Uso correcto",
            description="`!restart arma` — elige preset y reinicia\n`!restart ts3` — reinicia TeamSpeak 3",
            color=discord.Color.orange(),
        ))
        return

    servicio = servicio.lower()

    if servicio == "arma":
        presets = get_presets()
        if not presets:
            await ctx.send(embed=build_embed("❌ Sin presets", f"No se encontraron `.sh` en `{ARMA_DIR}`", discord.Color.red()))
            return
        preset_list = "\n".join(f"• `{p.replace('.sh', '')}`" for p in presets)
        embed = build_embed(
            title="🔄 Reiniciar Arma 3 — Elige preset",
            description=f"Se detendrá la sesión actual y se lanzará con el preset elegido:\n\n{preset_list}",
            color=discord.Color.orange(),
        )
        await ctx.send(embed=embed, view=PresetView(presets, action="restart"))

    elif servicio == "ts3":
        async with ctx.typing():
            result = lgsm_run("restart")
        if result == "ok":
            embed = build_embed("🔄 TS3 reiniciado", "TeamSpeak 3 reiniciado correctamente.", discord.Color.green())
        else:
            embed = build_embed("🔴 Error al reiniciar TS3", result, discord.Color.red())
        await ctx.send(embed=embed)

    else:
        await ctx.send(embed=build_embed(
            title="❓ Servicio no reconocido",
            description="Usa `!restart arma` o `!restart ts3`",
            color=discord.Color.orange(),
        ))

# ─────────────────────────────────────────
#  COMANDOS — TS3
# ─────────────────────────────────────────

@bot.command(name="ts3", help="Inicia el servidor de TeamSpeak 3.")
async def cmd_ts3(ctx):
    if not await check_channel(ctx): return

    if is_ts3_running():
        await ctx.send(embed=build_embed(
            title="⚠️ TeamSpeak 3",
            description="El servidor **ya está corriendo**.\nUsa `!stop ts3` o `!restart ts3`.",
            color=discord.Color.orange(),
        ))
        return

    async with ctx.typing():
        result = lgsm_run("start")

    if result == "ok":
        embed = build_embed(
            title="🟢 TeamSpeak 3 iniciado",
            description="TS3 lanzado correctamente vía LinuxGSM.",
            color=discord.Color.green(),
            fields=[{"name": "Puerto", "value": "9987 (UDP)", "inline": True}],
        )
    else:
        embed = build_embed("🔴 Error al iniciar TS3", result, discord.Color.red())
    await ctx.send(embed=embed)

# ─────────────────────────────────────────
#  COMANDOS — IP / STATUS / SHUTDOWN
# ─────────────────────────────────────────

@bot.command(name="ip", help="Muestra la IP pública del servidor.")
async def cmd_ip(ctx):
    if not await check_channel(ctx): return
    async with ctx.typing():
        public_ip = get_public_ip()
    await ctx.send(embed=build_embed(
        title="🌐 IP Pública del Servidor",
        description=f"`{public_ip}`",
        color=discord.Color.green(),
    ))


@bot.command(name="status", help="Estado de Arma 3, TS3 e IP pública.")
async def cmd_status(ctx):
    if not await check_channel(ctx): return
    async with ctx.typing():
        public_ip = get_public_ip()
        arma_ok   = tmux_session_exists(ARMA_TMUX_SESSION)
        ts3_ok    = is_ts3_running()

    await ctx.send(embed=build_embed(
        title="📊 Estado del Servidor Griffon",
        description=f"**IP Pública:** `{public_ip}`",
        color=discord.Color.blurple(),
        fields=[
            {"name": "Arma 3",      "value": "🟢 Corriendo" if arma_ok else "🔴 Detenido", "inline": True},
            {"name": "TeamSpeak 3", "value": "🟢 Corriendo" if ts3_ok  else "🔴 Detenido", "inline": True},
        ],
    ))


@bot.command(name="shutdown", help="Detiene TODOS los servidores. Pide confirmación.")
async def cmd_shutdown(ctx):
    if not await check_channel(ctx): return
    embed = build_embed(
        title="⚠️ Confirmar apagado total",
        description="Esto detendrá **Arma 3** y **TeamSpeak 3**.\n\nTienes 30 segundos para confirmar.",
        color=discord.Color.dark_orange(),
    )
    await ctx.send(embed=embed, view=ShutdownView())

# ─────────────────────────────────────────
#  ERROR HANDLER
# ─────────────────────────────────────────

@bot.event
async def on_command_error(ctx, error):
    if isinstance(error, commands.CommandNotFound):
        await ctx.send("❓ Comando no reconocido. Usa `!help` para ver los disponibles.")
    elif isinstance(error, commands.MissingRequiredArgument):
        await ctx.send(f"⚠️ Falta un argumento. Usa `!help {ctx.command}` para más info.")
    else:
        await ctx.send(f"⚠️ Error inesperado: `{error}`")

# ─────────────────────────────────────────
#  ARRANQUE
# ─────────────────────────────────────────

if __name__ == "__main__":
    bot.run(BOT_TOKEN)