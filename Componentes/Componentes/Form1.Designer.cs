namespace Componentes
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtColor1 = new System.Windows.Forms.TextBox();
            this.txtColor2 = new System.Windows.Forms.TextBox();
            this.txtColor3 = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblImgError = new System.Windows.Forms.Label();
            this.btnImg = new System.Windows.Forms.Button();
            this.lblImg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(346, 245);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.BtnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.BtnSalir_MouseLeave);
            // 
            // txtColor1
            // 
            this.txtColor1.Location = new System.Drawing.Point(55, 68);
            this.txtColor1.Name = "txtColor1";
            this.txtColor1.Size = new System.Drawing.Size(100, 20);
            this.txtColor1.TabIndex = 1;
            // 
            // txtColor2
            // 
            this.txtColor2.Location = new System.Drawing.Point(55, 107);
            this.txtColor2.Name = "txtColor2";
            this.txtColor2.Size = new System.Drawing.Size(100, 20);
            this.txtColor2.TabIndex = 2;
            // 
            // txtColor3
            // 
            this.txtColor3.Location = new System.Drawing.Point(55, 149);
            this.txtColor3.Name = "txtColor3";
            this.txtColor3.Size = new System.Drawing.Size(100, 20);
            this.txtColor3.TabIndex = 3;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(67, 188);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            this.btnColor.MouseEnter += new System.EventHandler(this.BtnColor_MouseEnter);
            this.btnColor.MouseLeave += new System.EventHandler(this.BtnColor_MouseLeave);
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(321, 68);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(169, 20);
            this.txtImg.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ruta Imagen";
            // 
            // lblImgError
            // 
            this.lblImgError.AutoSize = true;
            this.lblImgError.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblImgError.Location = new System.Drawing.Point(325, 134);
            this.lblImgError.MinimumSize = new System.Drawing.Size(20, 0);
            this.lblImgError.Name = "lblImgError";
            this.lblImgError.Size = new System.Drawing.Size(20, 13);
            this.lblImgError.TabIndex = 13;
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(321, 94);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(90, 23);
            this.btnImg.TabIndex = 14;
            this.btnImg.Text = "Cargar imagen";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.BtnImg_Click);
            this.btnImg.MouseEnter += new System.EventHandler(this.BtnImg_MouseEnter);
            this.btnImg.MouseLeave += new System.EventHandler(this.BtnImg_MouseLeave);
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Location = new System.Drawing.Point(606, 9);
            this.lblImg.MinimumSize = new System.Drawing.Size(600, 500);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(600, 500);
            this.lblImg.TabIndex = 15;
            // 
            // form1
            // 
            this.AcceptButton = this.btnImg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(1247, 534);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.lblImgError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImg);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txtColor3);
            this.Controls.Add(this.txtColor2);
            this.Controls.Add(this.txtColor1);
            this.Controls.Add(this.btnSalir);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1263, 573);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1263, 573);
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Ejercicio 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtColor1;
        private System.Windows.Forms.TextBox txtColor2;
        private System.Windows.Forms.TextBox txtColor3;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblImgError;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Label lblImg;
    }
}

