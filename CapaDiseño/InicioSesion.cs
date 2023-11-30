using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;

namespace CapaDiseño
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            List<Usuario> test = new CL_Usuario().listar();


            Usuario ousuario = new CL_Usuario().listar().Where(u => u.Documento == txtControl.Text && u.Clave == txtContra.Text).FirstOrDefault();


            if(ousuario != null)
            {
                MenuPrincipal pantalla = new MenuPrincipal(ousuario);

                pantalla.Show();
                this.Hide();

                pantalla.FormClosing += frmCerrar;
            }
            else
            {
                MessageBox.Show("no se encontro el usuario","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

           
        }

        private void frmCerrar(object sender, FormClosingEventArgs e)
        {
            txtControl.Text = "";
            txtContra.Text = "";
            this.Show();
        }
    }
}
