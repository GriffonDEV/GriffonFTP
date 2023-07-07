using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubirFTP.Modelo
{
    internal class datosConexion
    {
        private string varUsuario;
        private string varPassword;
        private string varHost;

        public datosConexion()
        {
        }

        public datosConexion(string prmUsuario, string prmPassword, string prmHost)
        {
            varUsuario = prmUsuario;
            varPassword = prmPassword;
            varHost = prmHost;
        }

        public void setUsuario(string prmUsuario)
        {
            varUsuario = prmUsuario;
        }
        public void setPassword(string prmPassword)
        {
            varPassword = prmPassword;
        }
        public void setHost(string prmHost)
        {
            varHost = prmHost;
        }

        public string getUsuario()
        {
            return varUsuario;
        }

        public string getPassword()
        {
            return varPassword;
        }
        public string getHost()
        {
            return varHost;
        }
    }
}

