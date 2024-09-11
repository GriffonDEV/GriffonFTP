using SubirFTP.Logica;
using SubirFTP.Modelo;
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
    public partial class UsuarioSSH : Form
    {
        datosConexion datosConexion;
        gestionDatosAcceso gestionDatosAcceso = new gestionDatosAcceso();
        public UsuarioSSH()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            datosConexion = new datosConexion(txtUsuario.Text, txtPass.Text, txtHost.Text, txtPuerto.Text);
            gestionDatosAcceso.escribirTXT(datosConexion);
            this.Close();
            new MenuPrincipal().Show();
        }
    }
}
