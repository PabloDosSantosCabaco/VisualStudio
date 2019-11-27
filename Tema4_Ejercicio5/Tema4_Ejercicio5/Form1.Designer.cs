namespace Tema4_Ejercicio5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstBox1 = new System.Windows.Forms.ListBox();
            this.lstBox2 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnToR = new System.Windows.Forms.Button();
            this.btnToL = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblIndices = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lstBox1
            // 
            this.lstBox1.FormattingEnabled = true;
            this.lstBox1.Location = new System.Drawing.Point(137, 107);
            this.lstBox1.Name = "lstBox1";
            this.lstBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBox1.Size = new System.Drawing.Size(120, 95);
            this.lstBox1.TabIndex = 0;
            // 
            // lstBox2
            // 
            this.lstBox2.FormattingEnabled = true;
            this.lstBox2.Location = new System.Drawing.Point(496, 107);
            this.lstBox2.Name = "lstBox2";
            this.lstBox2.Size = new System.Drawing.Size(120, 95);
            this.lstBox2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(335, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(335, 126);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Quitar";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnToR
            // 
            this.btnToR.Location = new System.Drawing.Point(335, 155);
            this.btnToR.Name = "btnToR";
            this.btnToR.Size = new System.Drawing.Size(75, 23);
            this.btnToR.TabIndex = 4;
            this.btnToR.Text = "Traspasar>";
            this.btnToR.UseVisualStyleBackColor = true;
            // 
            // btnToL
            // 
            this.btnToL.Location = new System.Drawing.Point(335, 184);
            this.btnToL.Name = "btnToL";
            this.btnToL.Size = new System.Drawing.Size(75, 23);
            this.btnToL.TabIndex = 5;
            this.btnToL.Text = "<Traspasar";
            this.btnToL.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(148, 227);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 6;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(134, 80);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(35, 13);
            this.lblSelected.TabIndex = 7;
            this.lblSelected.Text = "label1";
            // 
            // lblIndices
            // 
            this.lblIndices.AutoSize = true;
            this.lblIndices.Location = new System.Drawing.Point(134, 267);
            this.lblIndices.Name = "lblIndices";
            this.lblIndices.Size = new System.Drawing.Size(35, 13);
            this.lblIndices.TabIndex = 8;
            this.lblIndices.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIndices);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnToL);
            this.Controls.Add(this.btnToR);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstBox2);
            this.Controls.Add(this.lstBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox1;
        private System.Windows.Forms.ListBox lstBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnToR;
        private System.Windows.Forms.Button btnToL;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblIndices;
        private System.Windows.Forms.Timer timer1;
    }
}

