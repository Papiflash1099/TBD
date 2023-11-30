namespace CapaDiseño
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.label1 = new System.Windows.Forms.Label();
            this.btnProvRegr = new System.Windows.Forms.Button();
            this.txtProvTele = new System.Windows.Forms.TextBox();
            this.txtProvDirec = new System.Windows.Forms.TextBox();
            this.txtProvNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(444, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORMULARIO CATEGORIA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProvRegr
            // 
            this.btnProvRegr.BackColor = System.Drawing.Color.Firebrick;
            this.btnProvRegr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProvRegr.Location = new System.Drawing.Point(973, 448);
            this.btnProvRegr.Name = "btnProvRegr";
            this.btnProvRegr.Size = new System.Drawing.Size(242, 59);
            this.btnProvRegr.TabIndex = 31;
            this.btnProvRegr.Text = "Regresar";
            this.btnProvRegr.UseVisualStyleBackColor = false;
            // 
            // txtProvTele
            // 
            this.txtProvTele.Location = new System.Drawing.Point(213, 320);
            this.txtProvTele.Name = "txtProvTele";
            this.txtProvTele.Size = new System.Drawing.Size(264, 30);
            this.txtProvTele.TabIndex = 29;
            // 
            // txtProvDirec
            // 
            this.txtProvDirec.Location = new System.Drawing.Point(213, 264);
            this.txtProvDirec.Name = "txtProvDirec";
            this.txtProvDirec.Size = new System.Drawing.Size(264, 30);
            this.txtProvDirec.TabIndex = 28;
            // 
            // txtProvNombre
            // 
            this.txtProvNombre.Location = new System.Drawing.Point(213, 209);
            this.txtProvNombre.Name = "txtProvNombre";
            this.txtProvNombre.Size = new System.Drawing.Size(264, 30);
            this.txtProvNombre.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(56, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha Registro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(56, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(56, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre";
            // 
            // dtgProv
            // 
            this.dtgProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProv.Location = new System.Drawing.Point(572, 68);
            this.dtgProv.Name = "dtgProv";
            this.dtgProv.RowHeadersWidth = 51;
            this.dtgProv.RowTemplate.Height = 24;
            this.dtgProv.Size = new System.Drawing.Size(643, 365);
            this.dtgProv.TabIndex = 20;
            // 
            // btnProvElim
            // 
            this.btnProvElim.BackColor = System.Drawing.Color.Firebrick;
            this.btnProvElim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProvElim.Location = new System.Drawing.Point(572, 448);
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
            this.BtnProAgregar.Location = new System.Drawing.Point(19, 448);
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
            this.btnProvModi.Location = new System.Drawing.Point(300, 448);
            this.btnProvModi.Name = "btnProvModi";
            this.btnProvModi.Size = new System.Drawing.Size(232, 59);
            this.btnProvModi.TabIndex = 17;
            this.btnProvModi.Text = "Modificar";
            this.btnProvModi.UseVisualStyleBackColor = false;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1242, 552);
            this.Controls.Add(this.btnProvRegr);
            this.Controls.Add(this.txtProvTele);
            this.Controls.Add(this.txtProvDirec);
            this.Controls.Add(this.txtProvNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgProv);
            this.Controls.Add(this.btnProvElim);
            this.Controls.Add(this.BtnProAgregar);
            this.Controls.Add(this.btnProvModi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProvRegr;
        private System.Windows.Forms.TextBox txtProvTele;
        private System.Windows.Forms.TextBox txtProvDirec;
        private System.Windows.Forms.TextBox txtProvNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgProv;
        private System.Windows.Forms.Button btnProvElim;
        private System.Windows.Forms.Button BtnProAgregar;
        private System.Windows.Forms.Button btnProvModi;
    }
}