using SubirFTP.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubirFTP.Logica
{
    internal class gestionDatosAcceso
    {
        public void escribirTXT(datosConexion prmCredenciales)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "datosAcceso.txt");

            // Check if file already exists. If yes, delete it.     
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            // Create a new file     
            using (FileStream fs = File.Create(path)) ;
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(path, false);
                sw.WriteLine(cifradoCadena(prmCredenciales.getRoot()));
                sw.WriteLine(cifradoCadena(prmCredenciales.getPassword()));
                sw.WriteLine(cifradoCadena(prmCredenciales.getHost()));
                sw.WriteLine(cifradoCadena(prmCredenciales.getPuerto()));

                // Escribir la lista de credenciales
                foreach (datosConexion.Credenciales cred in prmCredenciales.ListaCredenciales)
                {
                    sw.WriteLine(cifradoCadena(cred.Usuario));
                    sw.WriteLine(cifradoCadena(cred.Contrasena));
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Se guardaron los datos de acceso.");
            }
        }

        public datosConexion leerTXT()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "datosAcceso.txt");
            datosConexion var_credenciales = new datosConexion();
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(path);
                //Read the first lines of text
                var_credenciales.setRoot(desecriptarCadena(sr.ReadLine()));
                var_credenciales.setPassword(desecriptarCadena(sr.ReadLine()));
                var_credenciales.setHost(desecriptarCadena(sr.ReadLine()));
                var_credenciales.setPuerto(desecriptarCadena(sr.ReadLine()));

                // Leer la lista de credenciales
                while (!sr.EndOfStream)
                {
                    string usuario = desecriptarCadena(sr.ReadLine());
                    string contrasena = desecriptarCadena(sr.ReadLine());
                    var_credenciales.ListaCredenciales.Add(new datosConexion.Credenciales(usuario, contrasena));
                }

                //close the file
                sr.Close();
                return var_credenciales;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;
            }
            finally
            {
                Console.WriteLine("Datos recuperados");
            }
        }



        public string cifradoCadena(string prmCadena)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(prmCadena);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        public string desecriptarCadena(string prmCadena)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(prmCadena);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
        public bool validarCredenciales()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "datosAcceso.txt");

            if (!File.Exists(path))
            {
                return false;
            }
            return true;

        }
    }
}
