namespace CapaDiseño
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.label1 = new System.Windows.Forms.Label();
            this.btnProvModi = new System.Windows.Forms.Button();
            this.BtnProAgregar = new System.Windows.Forms.Button();
            this.btnProvElim = new System.Windows.Forms.Button();
            this.dtgProv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProvID = new System.Windows.Forms.TextBox();
            this.txtProvNombre = new System.Windows.Forms.TextBox();
            this.txtProvDirec = new System.Windows.Forms.TextBox();
            this.txtProvTele = new System.Windows.Forms.TextBox();
            this.txtProvCodi = new System.Windows.Forms.TextBox();
            this.btnProvRegr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORMULARIO PROVEEDORES";
            // 
            // btnProvModi
            // 
            this.btnProvModi.BackColor = System.Drawing.Color.Firebrick;
            this.btnProvModi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProvModi.Location = new System.Drawing.Point(312, 492);
            this.btnProvModi.Name = "btnProvModi";
            this.btnProvModi.Size = new System.Drawing.Size(232, 59);
            this.btnProvModi.TabIndex = 2;
            this.btnProvModi.Text = "Modificar";
            this.btnProvModi.UseVisualStyleBackColor = false;
            // 
            // BtnProAgregar
            // 
            this.BtnProAgregar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnProAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnProAgregar.Location = new System.Drawing.Point(31, 492);
            this.BtnProAgregar.Name = "BtnProAgregar";
            this.BtnProAgregar.Size = new System.Drawing.Size(249, 59);
            this.BtnProAgregar.TabIndex = 3;
            this.BtnProAgregar.Text = "Agregar";
            this.BtnProAgregar.UseVisualStyleBackColor = false;
            // 
            // btnProvElim
            // 
            this.btnProvElim.BackColor = System.Drawing.Color.Firebrick;
            this.btnProvElim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProvElim.Location = new System.Drawing.Point(584, 492);
            this.btnProvElim.Name = "btnProvElim";
            this.btnProvElim.Size = new System.Drawing.Size(242, 59);
            this.btnProvElim.TabIndex = 4;
            this.btnProvElim.Text = "Eliminar";
            this.btnProvElim.UseVisualStyleBackColor = false;
            // 
            // dtgProv
            // 
            this.dtgProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProv.Location = new System.Drawing.Point(584, 77);
            this.dtgProv.Name = "dtgProv";
            this.dtgProv.RowHeadersWidth = 51;
            this.dtgProv.RowTemplate.Height = 24;
            this.dtgProv.Size = new System.Drawing.Size(643, 400);
            this.dtgProv.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Num. Control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Código Postal";
            // 
            // txtProvID
            // 
            this.txtProvID.Location = new System.Drawing.Point(225, 201);
            this.txtProvID.Name = "txtProvID";
            this.txtProvID.Size = new System.Drawing.Size(264, 30);
            this.txtProvID.TabIndex = 11;
            // 
            // txtProvNombre
            // 
            this.txtProvNombre.Location = new System.Drawing.Point(225, 253);
            this.txtProvNombre.Name = "txtProvNombre";
            this.txtProvNombre.Size = new System.Drawing.Size(264, 30);
            this.txtProvNombre.TabIndex = 12;
            // 
            // txtProvDirec
            // 
            this.txtProvDirec.Location = new System.Drawing.Point(225, 308);
            this.txtProvDirec.Name = "txtProvDirec";
            this.txtProvDirec.Size = new System.Drawing.Size(264, 30);
            this.txtProvDirec.TabIndex = 13;
            // 
            // txtProvTele
            // 
            this.txtProvTele.Location = new System.Drawing.Point(225, 364);
            this.txtProvTele.Name = "txtProvTele";
            this.txtProvTele.Size = new System.Drawing.Size(264, 30);
            this.txtProvTele.TabIndex = 14;
            // 
            // txtProvCodi
            // 
            this.txtProvCodi.Location = new System.Drawing.Point(225, 416);
            this.txtProvCodi.Name = "txtProvCodi";
            this.txtProvCodi.Size = new System.Drawing.Size(264, 30);
            this.txtProvCodi.TabIndex = 15;
            // 
            // btnProvRegr
            // 
            this.btnProvRegr.BackColor = System.Drawing.Color.Firebrick;
            this.btnProvRegr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProvRegr.Location = new System.Drawing.Point(985, 492);
            this.btnProvRegr.Name = "btnProvRegr";
            this.btnProvRegr.Size = new System.Drawing.Size(242, 59);
            this.btnProvRegr.TabIndex = 16;
            this.btnProvRegr.Text = "Regresar";
            this.btnProvRegr.UseVisualStyleBackColor = false;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1254, 602);
            this.Controls.Add(this.btnProvRegr);
            this.Controls.Add(this.txtProvCodi);
            this.Controls.Add(this.txtProvTele);
            this.Controls.Add(this.txtProvDirec);
            this.Controls.Add(this.txtProvNombre);
            this.Controls.Add(this.txtProvID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgProv);
            this.Controls.Add(this.btnProvElim);
            this.Controls.Add(this.BtnProAgregar);
            this.Controls.Add(this.btnProvModi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProvModi;
        private System.Windows.Forms.Button BtnProAgregar;
        private System.Windows.Forms.Button btnProvElim;
        private System.Windows.Forms.DataGridView dtgProv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProvID;
        private System.Windows.Forms.TextBox txtProvNombre;
        private System.Windows.Forms.TextBox txtProvDirec;
        private System.Windows.Forms.TextBox txtProvTele;
        private System.Windows.Forms.TextBox txtProvCodi;
        private System.Windows.Forms.Button btnProvRegr;
    }
}