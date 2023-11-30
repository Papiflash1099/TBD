namespace CapaDiseño
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPestañas = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuInventario = new FontAwesome.Sharp.IconMenuItem();
            this.menuCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.menuProducto = new FontAwesome.Sharp.IconMenuItem();
            this.menuDistribuidor = new FontAwesome.Sharp.IconMenuItem();
            this.subMnuRegistrar = new FontAwesome.Sharp.IconMenuItem();
            this.subMnuVerDistri = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.subMnuCompra = new FontAwesome.Sharp.IconMenuItem();
            this.subMnuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuAcerca = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.lblVentas = new System.Windows.Forms.Label();
            this.pnlPantallas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuPestañas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPestañas
            // 
            this.menuPestañas.BackColor = System.Drawing.Color.White;
            this.menuPestañas.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPestañas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPestañas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuInventario,
            this.menuDistribuidor,
            this.menuCompras,
            this.menuClientes,
            this.menuProveedores,
            this.menuAcerca});
            this.menuPestañas.Location = new System.Drawing.Point(0, 59);
            this.menuPestañas.Name = "menuPestañas";
            this.menuPestañas.Size = new System.Drawing.Size(119, 614);
            this.menuPestañas.TabIndex = 0;
            this.menuPestañas.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 50;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(113, 69);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuInventario
            // 
            this.menuInventario.AutoSize = false;
            this.menuInventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCategoria,
            this.menuProducto});
            this.menuInventario.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.menuInventario.IconColor = System.Drawing.Color.Black;
            this.menuInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuInventario.IconSize = 50;
            this.menuInventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuInventario.Name = "menuInventario";
            this.menuInventario.Size = new System.Drawing.Size(113, 69);
            this.menuInventario.Text = "Inventario";
            // 
            // menuCategoria
            // 
            this.menuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuCategoria.IconColor = System.Drawing.Color.Black;
            this.menuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCategoria.Name = "menuCategoria";
            this.menuCategoria.Size = new System.Drawing.Size(157, 26);
            this.menuCategoria.Text = "Categoria";
            this.menuCategoria.Click += new System.EventHandler(this.menuCategoria_Click);
            // 
            // menuProducto
            // 
            this.menuProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuProducto.IconColor = System.Drawing.Color.Black;
            this.menuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProducto.Name = "menuProducto";
            this.menuProducto.Size = new System.Drawing.Size(157, 26);
            this.menuProducto.Text = "Producto";
            this.menuProducto.Click += new System.EventHandler(this.menuProducto_Click);
            // 
            // menuDistribuidor
            // 
            this.menuDistribuidor.AutoSize = false;
            this.menuDistribuidor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuRegistrar,
            this.subMnuVerDistri});
            this.menuDistribuidor.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.menuDistribuidor.IconColor = System.Drawing.Color.Black;
            this.menuDistribuidor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuDistribuidor.IconSize = 50;
            this.menuDistribuidor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuDistribuidor.Name = "menuDistribuidor";
            this.menuDistribuidor.Size = new System.Drawing.Size(113, 69);
            this.menuDistribuidor.Text = "Distribuidor";
            // 
            // subMnuRegistrar
            // 
            this.subMnuRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMnuRegistrar.IconColor = System.Drawing.Color.Black;
            this.subMnuRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMnuRegistrar.Name = "subMnuRegistrar";
            this.subMnuRegistrar.Size = new System.Drawing.Size(165, 26);
            this.subMnuRegistrar.Text = "Registrar";
            this.subMnuRegistrar.Click += new System.EventHandler(this.subMnuRegistrar_Click);
            // 
            // subMnuVerDistri
            // 
            this.subMnuVerDistri.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMnuVerDistri.IconColor = System.Drawing.Color.Black;
            this.subMnuVerDistri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMnuVerDistri.Name = "subMnuVerDistri";
            this.subMnuVerDistri.Size = new System.Drawing.Size(165, 26);
            this.subMnuVerDistri.Text = "Ver Detalle";
            this.subMnuVerDistri.Click += new System.EventHandler(this.subMnuVerDistri_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.AutoSize = false;
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuCompra,
            this.subMnuVerDetalleCompra});
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.menuCompras.IconColor = System.Drawing.Color.Black;
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 50;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(113, 69);
            this.menuCompras.Text = "Compras";
            // 
            // subMnuCompra
            // 
            this.subMnuCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMnuCompra.IconColor = System.Drawing.Color.Black;
            this.subMnuCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMnuCompra.Name = "subMnuCompra";
            this.subMnuCompra.Size = new System.Drawing.Size(165, 26);
            this.subMnuCompra.Text = "Registrar";
            this.subMnuCompra.Click += new System.EventHandler(this.subMnuCompra_Click);
            // 
            // subMnuVerDetalleCompra
            // 
            this.subMnuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMnuVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.subMnuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMnuVerDetalleCompra.Name = "subMnuVerDetalleCompra";
            this.subMnuVerDetalleCompra.Size = new System.Drawing.Size(165, 26);
            this.subMnuVerDetalleCompra.Text = "Ver Detalle";
            this.subMnuVerDetalleCompra.Click += new System.EventHandler(this.subMnuVerDetalleCompra_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 50;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(113, 69);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.AutoSize = false;
            this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuProveedores.IconColor = System.Drawing.Color.Black;
            this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedores.IconSize = 45;
            this.menuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(113, 69);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // menuAcerca
            // 
            this.menuAcerca.AutoSize = false;
            this.menuAcerca.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuAcerca.IconColor = System.Drawing.Color.Black;
            this.menuAcerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAcerca.IconSize = 50;
            this.menuAcerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAcerca.Name = "menuAcerca";
            this.menuAcerca.Size = new System.Drawing.Size(113, 69);
            this.menuAcerca.Text = "Acerca de";
            this.menuAcerca.Click += new System.EventHandler(this.menuAcerca_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.OrangeRed;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1383, 59);
            this.menuTitulo.TabIndex = 0;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.BackColor = System.Drawing.Color.OrangeRed;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.White;
            this.lblVentas.Location = new System.Drawing.Point(16, 11);
            this.lblVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(187, 39);
            this.lblVentas.TabIndex = 1;
            this.lblVentas.Text = "Bienvenido";
            // 
            // pnlPantallas
            // 
            this.pnlPantallas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPantallas.Location = new System.Drawing.Point(119, 59);
            this.pnlPantallas.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPantallas.Name = "pnlPantallas";
            this.pnlPantallas.Size = new System.Drawing.Size(1264, 614);
            this.pnlPantallas.TabIndex = 2;
            this.pnlPantallas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPantallas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1059, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.OrangeRed;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(1168, 12);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(126, 29);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 673);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPantallas);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.menuPestañas);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menuPestañas;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuPestañas.ResumeLayout(false);
            this.menuPestañas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPestañas;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label lblVentas;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuInventario;
        private FontAwesome.Sharp.IconMenuItem menuDistribuidor;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuAcerca;
        private System.Windows.Forms.Panel pnlPantallas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem menuCategoria;
        private FontAwesome.Sharp.IconMenuItem menuProducto;
        private FontAwesome.Sharp.IconMenuItem subMnuRegistrar;
        private FontAwesome.Sharp.IconMenuItem subMnuVerDistri;
        private FontAwesome.Sharp.IconMenuItem subMnuCompra;
        private FontAwesome.Sharp.IconMenuItem subMnuVerDetalleCompra;
    }
}

