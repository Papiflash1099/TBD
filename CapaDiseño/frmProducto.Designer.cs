namespace CapaDiseño
{
    partial class frmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.btnProvRegr = new System.Windows.Forms.Button();
            this.txtProvNombre = new System.Windows.Forms.TextBox();
            this.txtProvID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgProv = new System.Windows.Forms.DataGridView();
            this.btnProvElim = new System.Windows.Forms.Button();
            this.BtnProAgregar = new System.Windows.Forms.Button();
            this.btnProvModi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(484, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORMULARIO PRODUCTO";
            // 
            // btnProvRegr
            // 
            this.btnProvRegr.BackColor = System.Drawing.Color.Firebrick;
            this.btnProvRegr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProvRegr.Location = new System.Drawing.Point(971, 470);
            this.btnProvRegr.Name = "btnProvRegr";
            this.btnProvRegr.Size = new System.Drawing.Size(242, 59);
            this.btnProvRegr.TabIndex = 31;
            this.btnProvRegr.Text = "Regresar";
            this.btnProvRegr.UseVisualStyleBackColor = false;
            // 
            // txtProvNombre
            // 
            this.txtProvNombre.Location = new System.Drawing.Point(211, 337);
            this.txtProvNombre.Name = "txtProvNombre";
            this.txtProvNombre.Size = new System.Drawing.Size(264, 30);
            this.txtProvNombre.TabIndex = 27;
            // 
            // txtProvID
            // 
            this.txtProvID.Location = new System.Drawing.Point(211, 220);
            this.txtProvID.Name = "txtProvID";
            this.txtProvID.Size = new System.Drawing.Size(264, 30);
            this.txtProvID.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(60, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(47, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Num. Control";
            // 
            // dtgProv
            // 
            this.dtgProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProv.Location = new System.Drawing.Point(570, 55);
            this.dtgProv.Name = "dtgProv";
            this.dtgProv.RowHeadersWidth = 51;
            this.dtgProv.RowTemplate.Height = 24;
            this.dtgProv.Size = new System.Drawing.Size(643, 400);
            this.dtgProv.TabIndex = 20;
            // 
            // btnProvElim
            // 
            this.btnProvElim.BackColor = System.Drawing.Color.Firebrick;
            this.btnProvElim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProvElim.Location = new System.Drawing.Point(570, 470);
            this.btnProvElim.Name = "btnProvElim";
            this.btnProvElim.Size = new System.Drawing.Size(242, 59);
            this.btnProvElim.TabIndex = 19;
            this.btnProvElim.Text = "Eliminar";
            this.btnProvElim.UseVisualStyleBackColor = false;
            // 
            // BtnProAgregar
            // 
            this.BtnProAgregar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnProAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnProAgregar.Location = new System.Drawing.Point(17, 470);
            this.BtnProAgregar.Name = "BtnProAgregar";
            this.BtnProAgregar.Size = new System.Drawing.Size(249, 59);
            this.BtnProAgregar.TabIndex = 18;
            this.BtnProAgregar.Text = "Agregar";
            this.BtnProAgregar.UseVisualStyleBackColor = false;
            // 
            // btnProvModi
            // 
            this.btnProvModi.BackColor = System.Drawing.Color.Firebrick;
            this.btnProvModi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProvModi.Location = new System.Drawing.Point(298, 470);
            this.btnProvModi.Name = "btnProvModi";
            this.btnProvModi.Size = new System.Drawing.Size(232, 59);
            this.btnProvModi.TabIndex = 17;
            this.btnProvModi.Text = "Modificar";
            this.btnProvModi.UseVisualStyleBackColor = false;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1231, 585);
            this.Controls.Add(this.btnProvRegr);
            this.Controls.Add(this.txtProvNombre);
            this.Controls.Add(this.txtProvID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgProv);
            this.Controls.Add(this.btnProvElim);
            this.Controls.Add(this.BtnProAgregar);
            this.Controls.Add(this.btnProvModi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProvRegr;
        private System.Windows.Forms.TextBox txtProvNombre;
        private System.Windows.Forms.TextBox txtProvID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgProv;
        private System.Windows.Forms.Button btnProvElim;
        private System.Windows.Forms.Button BtnProAgregar;
        private System.Windows.Forms.Button btnProvModi;
    }
}