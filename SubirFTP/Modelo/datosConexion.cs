using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubirFTP.Modelo
{
    internal class datosConexion
    {
        public struct Credenciales
        {
            public string Usuario;
            public string Contrasena;

            public Credenciales(string usuario, string contrasena)
            {
                Usuario = usuario;
                Contrasena = contrasena;
            }
        }

        private ArrayList listaCredenciales = new ArrayList();
        private string varRoot;
        private string varPassword;
        private string varHost;
        private string varPuerto;

        public datosConexion()
        {
        }

        public datosConexion(string prmRoot, string prmPassword, string prmHost, string prmPuerto)
        {
            varRoot = prmRoot;
            varPassword = prmPassword;
            varHost = prmHost;
            varPuerto = prmPuerto;
        }

        public ArrayList ListaCredenciales
        {
            get { return listaCredenciales; }
            set { listaCredenciales = value; }
        }

        public string getRoot()
        {
            return varRoot;
        }

        public string getPassword()
        {
            return varPassword;
        }

        public string getHost()
        {
            return varHost;
        }

        public string getPuerto()
        {
            return varPuerto;
        }   

        public void setRoot(string prmRoot)
        {
            varRoot = prmRoot;
        }

        public void setPassword(string prmPassword)
        {
            varPassword = prmPassword;
        }

        public void setHost(string prmHost)
        {
            varHost = prmHost;
        }

        public void setPuerto(string prmPuerto)
        {
            varPuerto = prmPuerto;
        }
    }
}
