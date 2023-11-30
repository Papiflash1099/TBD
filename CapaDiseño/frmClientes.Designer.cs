namespace CapaDiseño
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClieRegr = new System.Windows.Forms.Button();
            this.txtClieCodi = new System.Windows.Forms.TextBox();
            this.txtClieTele = new System.Windows.Forms.TextBox();
            this.txtClieDirec = new System.Windows.Forms.TextBox();
            this.txtClieNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgClie = new System.Windows.Forms.DataGridView();
            this.btnClieElim = new System.Windows.Forms.Button();
            this.BtnClieAgregar = new System.Windows.Forms.Button();
            this.btnClieModi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(397, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORMULARIO CLIENTES";
            // 
            // btnClieRegr
            // 
            this.btnClieRegr.BackColor = System.Drawing.Color.Firebrick;
            this.btnClieRegr.Location = new System.Drawing.Point(970, 469);
            this.btnClieRegr.Name = "btnClieRegr";
            this.btnClieRegr.Size = new System.Drawing.Size(242, 59);
            this.btnClieRegr.TabIndex = 31;
            this.btnClieRegr.Text = "Regresar";
            this.btnClieRegr.UseVisualStyleBackColor = false;
            // 
            // txtClieCodi
            // 
            this.txtClieCodi.Location = new System.Drawing.Point(210, 393);
            this.txtClieCodi.Name = "txtClieCodi";
            this.txtClieCodi.Size = new System.Drawing.Size(264, 30);
            this.txtClieCodi.TabIndex = 30;
            // 
            // txtClieTele
            // 
            this.txtClieTele.Location = new System.Drawing.Point(210, 336);
            this.txtClieTele.Name = "txtClieTele";
            this.txtClieTele.Size = new System.Drawing.Size(264, 30);
            this.txtClieTele.TabIndex = 29;
            // 
            // txtClieDirec
            // 
            this.txtClieDirec.Location = new System.Drawing.Point(210, 271);
            this.txtClieDirec.Name = "txtClieDirec";
            this.txtClieDirec.Size = new System.Drawing.Size(264, 30);
            this.txtClieDirec.TabIndex = 28;
            // 
            // txtClieNombre
            // 
            this.txtClieNombre.Location = new System.Drawing.Point(210, 216);
            this.txtClieNombre.Name = "txtClieNombre";
            this.txtClieNombre.Size = new System.Drawing.Size(264, 30);
            this.txtClieNombre.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(41, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Código Postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(53, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(53, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(53, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre";
            // 
            // dtgClie
            // 
            this.dtgClie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClie.Location = new System.Drawing.Point(569, 54);
            this.dtgClie.Name = "dtgClie";
            this.dtgClie.RowHeadersWidth = 51;
            this.dtgClie.RowTemplate.Height = 24;
            this.dtgClie.Size = new System.Drawing.Size(643, 400);
            this.dtgClie.TabIndex = 20;
            // 
            // btnClieElim
            // 
            this.btnClieElim.BackColor = System.Drawing.Color.Firebrick;
            this.btnClieElim.Location = new System.Drawing.Point(569, 469);
            this.btnClieElim.Name = "btnClieElim";
            this.btnClieElim.Size = new System.Drawing.Size(242, 59);
            this.btnClieElim.TabIndex = 19;
            this.btnClieElim.Text = "Eliminar";
            this.btnClieElim.UseVisualStyleBackColor = false;
            // 
            // BtnClieAgregar
            // 
            this.BtnClieAgregar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnClieAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClieAgregar.Location = new System.Drawing.Point(16, 469);
            this.BtnClieAgregar.Name = "BtnClieAgregar";
            this.BtnClieAgregar.Size = new System.Drawing.Size(249, 59);
            this.BtnClieAgregar.TabIndex = 18;
            this.BtnClieAgregar.Text = "Agregar";
            this.BtnClieAgregar.UseVisualStyleBackColor = false;
            // 
            // btnClieModi
            // 
            this.btnClieModi.BackColor = System.Drawing.Color.Firebrick;
            this.btnClieModi.Location = new System.Drawing.Point(297, 469);
            this.btnClieModi.Name = "btnClieModi";
            this.btnClieModi.Size = new System.Drawing.Size(232, 59);
            this.btnClieModi.TabIndex = 17;
            this.btnClieModi.Text = "Modificar";
            this.btnClieModi.UseVisualStyleBackColor = false;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1229, 583);
            this.Controls.Add(this.btnClieRegr);
            this.Controls.Add(this.txtClieCodi);
            this.Controls.Add(this.txtClieTele);
            this.Controls.Add(this.txtClieDirec);
            this.Controls.Add(this.txtClieNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgClie);
            this.Controls.Add(this.btnClieElim);
            this.Controls.Add(this.BtnClieAgregar);
            this.Controls.Add(this.btnClieModi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClieRegr;
        private System.Windows.Forms.TextBox txtClieCodi;
        private System.Windows.Forms.TextBox txtClieTele;
        private System.Windows.Forms.TextBox txtClieDirec;
        private System.Windows.Forms.TextBox txtClieNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgClie;
        private System.Windows.Forms.Button btnClieElim;
        private System.Windows.Forms.Button BtnClieAgregar;
        private System.Windows.Forms.Button btnClieModi;
    }
}