using Renci.SshNet;
using SubirFTP.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubirFTP.Pantallas
{
    public partial class MenuPrincipal : Form
    {
        FileInfo File;
        subida var_Subida = new subida();
        comandos var_comandos = new comandos();
        gestionDatosAcceso gestionDatosAcceso = new gestionDatosAcceso();
        public MenuPrincipal()
        {
            if (gestionDatosAcceso.validarCredenciales())
            {
                InitializeComponent();
            }
            else
            {
                new UsuarioSSH().Show();
            }

        }

        private void tabMapa_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void splitContainer1_Panel2_DragDrop(object sender, DragEventArgs e)
        {
            string[] rutaArrastrar = (string[])e.Data.GetData(DataFormats.FileDrop);
            txtBox.AppendText(rutaArrastrar[1]);
        }

        private void btnCargarSH_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string message = "No hay archivos seleccionados";
            if (File != null)
            {
                message = "No hay archivos seleccionados";
                message = var_Subida.subirPBO(File);
                txtBox.AppendText(message);
                MessageBox.Show(message, null, buttons);
            }
            else
            {
                MessageBox.Show(message, null, buttons);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;

                File = new System.IO.FileInfo(FD.FileName);
                txtBox.AppendText("Ruta archivo:" + File.FullName);
                //OR

                //System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);
                //etc
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string message = "No hay archivos seleccionados";
            if (File != null)
            {
                message = "No hay archivos seleccionados";

                message = var_Subida.subirPBO(File);
                MessageBox.Show(message, null, buttons);
            }
            else
            {
                MessageBox.Show(message, null, buttons);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;

                File = new System.IO.FileInfo(FD.FileName);
                txtBox.AppendText("Ruta archivo:" + File.FullName);
                //OR

                //System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);
                //etc
            }
        }

        private void btnCargarSSH_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string message = "No hay archivos seleccionados";
            if (File != null)
            {
                message = "No hay archivos seleccionados";
                message = var_Subida.subirSSH(File);

                MessageBox.Show(message, null, buttons);
            }
            else
            {
                MessageBox.Show(message, null, buttons);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            string message = "";
            message = var_comandos.comSSH("root", "reboot");
            txtBox.AppendText(message);
        }

        private void btnStartArma_Click(object sender, EventArgs e)
        {
            string message = "";
            txtBox.AppendText("Iniciando servidor de Arma 3");
            message = var_comandos.comSSH("steam", "./arma.sh");
            txtBox.AppendText(message);
        }

        private void btnStartTs3_Click(object sender, EventArgs e)
        {
            string message = "";
            message = var_comandos.comSSH("ts3", "./ts3server st");
            txtBox.AppendText(message);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {

        }

        private void btnArma3Basic_Click(object sender, EventArgs e)
        {
            string message = "";
            txtBox.AppendText("Iniciando servidor de Arma 3");
            message = var_comandos.comSSH("steam", "./basicos.sh");
            txtBox.AppendText(message);
        }

        private void btnArmaCampa_Click(object sender, EventArgs e)
        {
            string message = "";
            txtBox.AppendText("Iniciando servidor de Arma 3");
            message = var_comandos.comSSH("steam", "./campaña.sh");
            txtBox.AppendText(message);
        }
    }
}
