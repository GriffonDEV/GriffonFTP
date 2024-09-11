using Renci.SshNet;
using SubirFTP.Modelo;
using System.Diagnostics;
using System.Net.Sockets;

namespace SubirFTP.Logica
{
    internal class comandos
    {

        gestionDatosAcceso gestionDatosAcceso = new gestionDatosAcceso();
        public String comSSH(String prm_user, String prm_ssh)
        {
            datosConexion datos = new datosConexion();
            datos = gestionDatosAcceso.leerTXT();
            SshCommand res_txt;
            String result;
            var client = new SshClient(datos.getHost(), datos.getRoot(), datos.getPassword());

            try
            {
                client.Connect();
                Console.WriteLine("Conexión exitosa");

                string command = prm_user switch
                {
                    "steam" => $"su steam -c \"cd ~ && {prm_ssh}\"",
                    "ts3" => $"su ts3 -c \"{prm_ssh}\"",
                    _ => prm_ssh
                };

                Console.WriteLine($"Ejecutando comando: {command}");
                res_txt = client.RunCommand(command);

                Console.WriteLine("Ejecución de comando");
                client.Disconnect();
                client.Dispose();
                return res_txt.Result;
            }
            catch (SocketException ex)
            {
                Console.WriteLine($"Error de socket: {ex.Message}");
                Console.WriteLine($"Código de error: {ex.SocketErrorCode}");
                return ex.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error general: {ex.Message}");
                return ex.ToString();
            }
        }



        public String comSSH (String prm_user , String prm_ssh , String prm_ssh2)
        {
            SshCommand res_txt;
            if (prm_user == "steam")
            {
                string host = "";
                string username = "";
                string password = "";
                var client = new SshClient(host, username, password);
                try
                {
                    client.Connect();
                    res_txt = client.RunCommand(prm_ssh);
                    res_txt = client.RunCommand(prm_ssh2);
                    client.Disconnect();
                    client.Dispose();
                    return res_txt.Result;
                }
                catch (Exception ex)
                {
                    return (ex.ToString());
                }

            }
            else if (prm_user == "root")
            {
                string host = "";
                string username = "root";
                string password = "%";
                var client = new SshClient(host, username, password);
                try
                {
                    client.Connect();
                    res_txt = client.RunCommand(prm_ssh);
                    res_txt = client.RunCommand(prm_ssh2);
                    client.Disconnect();
                    client.Dispose();
                    return res_txt.Result;
                }
                catch (Exception ex)
                {
                    return (ex.ToString());
                }

            }
            return ("Usuario no reconocido");
        }

        public String comSSH(String prm_user,String prm_ssh, String prm_ssh2, String prm_ssh3)
        {
            SshCommand res_txt;
            if (prm_user == "steam")
            {
                string host = "";
                string username = "steam";
                string password = "";
                var client = new SshClient(host, username, password);
                try
                {
                    client.Connect();
                    res_txt = client.RunCommand(prm_ssh);
                    res_txt = client.RunCommand(prm_ssh2);
                    res_txt = client.RunCommand(prm_ssh3);
                    client.Disconnect();
                    client.Dispose();
                    return res_txt.Result;
                }
                catch (Exception ex)
                {
                    return (ex.ToString());
                }

            }
            else if (prm_user == "root")
            {
                string host = "";
                string username = "";
                string password = "";
                var client = new SshClient(host, username, password);
                try
                {
                    client.Connect();
                    res_txt = client.RunCommand(prm_ssh);
                    res_txt = client.RunCommand(prm_ssh2);
                    res_txt = client.RunCommand(prm_ssh3);
                    client.Disconnect();
                    client.Dispose();
                    return res_txt.Result;
                }
                catch (Exception ex)
                {
                    return (ex.ToString());
                }

            }
            return ("Usuario no reconocido");
        }

    }
}
