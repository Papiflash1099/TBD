using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using FontAwesome.Sharp;
using CapaLogica;

namespace CapaDiseño
{
    public partial class MenuPrincipal : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public MenuPrincipal(Usuario objUsuario)
        {
            usuarioActual = objUsuario;

            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            List<Permiso> listaPermisos = new CL_Permiso().listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconmenu in menuPestañas.Items)
            {
                bool encontrado = listaPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }
            lblUsuario.Text= usuarioActual.NombreCompleto;
        }

        private void abrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;


            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.OrangeRed;

            pnlPantallas.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void menuCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuInventario, new frmCategoria());
        }

        private void menuProducto_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuInventario, new frmProducto());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void menuAcerca_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmInfo());
        }

        private void subMnuRegistrar_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuDistribuidor, new frmDistribuidor());

        }

        private void subMnuVerDistri_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuDistribuidor, new frmDetalle_Distribuidor());

        }

        private void subMnuCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmCompras());

        }

        private void subMnuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmDetalle_Compra());

        }

        private void pnlPantallas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
