namespace CapaDiseño
{
    partial class frmDistribuidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistribuidor));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisRegr = new System.Windows.Forms.Button();
            this.txtDisCodi = new System.Windows.Forms.TextBox();
            this.txtDisTele = new System.Windows.Forms.TextBox();
            this.txtDisDirec = new System.Windows.Forms.TextBox();
            this.txtDisNombre = new System.Windows.Forms.TextBox();
            this.txtDisID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgDis = new System.Windows.Forms.DataGridView();
            this.btnDisElim = new System.Windows.Forms.Button();
            this.BtnDisAgregar = new System.Windows.Forms.Button();
            this.btnDisModi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORMULARIO DISTRIBUIDOR";
            // 
            // btnDisRegr
            // 
            this.btnDisRegr.BackColor = System.Drawing.Color.Firebrick;
            this.btnDisRegr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDisRegr.Location = new System.Drawing.Point(975, 469);
            this.btnDisRegr.Name = "btnDisRegr";
            this.btnDisRegr.Size = new System.Drawing.Size(242, 59);
            this.btnDisRegr.TabIndex = 31;
            this.btnDisRegr.Text = "Regresar";
            this.btnDisRegr.UseVisualStyleBackColor = false;
            // 
            // txtDisCodi
            // 
            this.txtDisCodi.Location = new System.Drawing.Point(215, 393);
            this.txtDisCodi.Name = "txtDisCodi";
            this.txtDisCodi.Size = new System.Drawing.Size(264, 30);
            this.txtDisCodi.TabIndex = 30;
            // 
            // txtDisTele
            // 
            this.txtDisTele.Location = new System.Drawing.Point(215, 341);
            this.txtDisTele.Name = "txtDisTele";
            this.txtDisTele.Size = new System.Drawing.Size(264, 30);
            this.txtDisTele.TabIndex = 29;
            // 
            // txtDisDirec
            // 
            this.txtDisDirec.Location = new System.Drawing.Point(215, 285);
            this.txtDisDirec.Name = "txtDisDirec";
            this.txtDisDirec.Size = new System.Drawing.Size(264, 30);
            this.txtDisDirec.TabIndex = 28;
            // 
            // txtDisNombre
            // 
            this.txtDisNombre.Location = new System.Drawing.Point(215, 230);
            this.txtDisNombre.Name = "txtDisNombre";
            this.txtDisNombre.Size = new System.Drawing.Size(264, 30);
            this.txtDisNombre.TabIndex = 27;
            // 
            // txtDisID
            // 
            this.txtDisID.Location = new System.Drawing.Point(215, 178);
            this.txtDisID.Name = "txtDisID";
            this.txtDisID.Size = new System.Drawing.Size(264, 30);
            this.txtDisID.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Código Postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Num. Control";
            // 
            // dtgDis
            // 
            this.dtgDis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDis.Location = new System.Drawing.Point(574, 54);
            this.dtgDis.Name = "dtgDis";
            this.dtgDis.RowHeadersWidth = 51;
            this.dtgDis.RowTemplate.Height = 24;
            this.dtgDis.Size = new System.Drawing.Size(643, 400);
            this.dtgDis.TabIndex = 20;
            // 
            // btnDisElim
            // 
            this.btnDisElim.BackColor = System.Drawing.Color.Firebrick;
            this.btnDisElim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDisElim.Location = new System.Drawing.Point(574, 469);
            this.btnDisElim.Name = "btnDisElim";
            this.btnDisElim.Size = new System.Drawing.Size(242, 59);
            this.btnDisElim.TabIndex = 19;
            this.btnDisElim.Text = "Eliminar";
            this.btnDisElim.UseVisualStyleBackColor = false;
            // 
            // BtnDisAgregar
            // 
            this.BtnDisAgregar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnDisAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDisAgregar.Location = new System.Drawing.Point(21, 469);
            this.BtnDisAgregar.Name = "BtnDisAgregar";
            this.BtnDisAgregar.Size = new System.Drawing.Size(249, 59);
            this.BtnDisAgregar.TabIndex = 18;
            this.BtnDisAgregar.Text = "Agregar";
            this.BtnDisAgregar.UseVisualStyleBackColor = false;
            // 
            // btnDisModi
            // 
            this.btnDisModi.BackColor = System.Drawing.Color.Firebrick;
            this.btnDisModi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDisModi.Location = new System.Drawing.Point(302, 469);
            this.btnDisModi.Name = "btnDisModi";
            this.btnDisModi.Size = new System.Drawing.Size(232, 59);
            this.btnDisModi.TabIndex = 17;
            this.btnDisModi.Text = "Modificar";
            this.btnDisModi.UseVisualStyleBackColor = false;
            // 
            // frmDistribuidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1238, 583);
            this.Controls.Add(this.btnDisRegr);
            this.Controls.Add(this.txtDisCodi);
            this.Controls.Add(this.txtDisTele);
            this.Controls.Add(this.txtDisDirec);
            this.Controls.Add(this.txtDisNombre);
            this.Controls.Add(this.txtDisID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgDis);
            this.Controls.Add(this.btnDisElim);
            this.Controls.Add(this.BtnDisAgregar);
            this.Controls.Add(this.btnDisModi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmDistribuidor";
            this.Text = "frmDistribuidor";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisRegr;
        private System.Windows.Forms.TextBox txtDisCodi;
        private System.Windows.Forms.TextBox txtDisTele;
        private System.Windows.Forms.TextBox txtDisDirec;
        private System.Windows.Forms.TextBox txtDisNombre;
        private System.Windows.Forms.TextBox txtDisID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgDis;
        private System.Windows.Forms.Button btnDisElim;
        private System.Windows.Forms.Button BtnDisAgregar;
        private System.Windows.Forms.Button btnDisModi;
    }
}