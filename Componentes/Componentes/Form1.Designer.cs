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
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(346, 245);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
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
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(171, 68);
            this.txtR.Name = "txtR";
            this.txtR.ReadOnly = true;
            this.txtR.Size = new System.Drawing.Size(18, 20);
            this.txtR.TabIndex = 5;
            this.txtR.Text = "R";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(171, 149);
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.Size = new System.Drawing.Size(18, 20);
            this.txtB.TabIndex = 6;
            this.txtB.Text = "B";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(171, 107);
            this.txtG.Name = "txtG";
            this.txtG.ReadOnly = true;
            this.txtG.Size = new System.Drawing.Size(18, 20);
            this.txtG.TabIndex = 7;
            this.txtG.Text = "G";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txtColor3);
            this.Controls.Add(this.txtColor2);
            this.Controls.Add(this.txtColor1);
            this.Controls.Add(this.btnSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
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
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtG;
    }
}

