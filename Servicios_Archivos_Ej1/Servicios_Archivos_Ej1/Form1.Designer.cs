namespace Servicios_Archivos_Ej1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDir = new System.Windows.Forms.TextBox();
            this.btnDir = new System.Windows.Forms.Button();
            this.lstDirs = new System.Windows.Forms.ListBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblDirectorios = new System.Windows.Forms.Label();
            this.lblArchivos = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.txtFiles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(56, 94);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(200, 20);
            this.txtDir.TabIndex = 0;
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(56, 120);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(75, 23);
            this.btnDir.TabIndex = 1;
            this.btnDir.Text = "Go";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.BtnDir_Click);
            // 
            // lstDirs
            // 
            this.lstDirs.FormattingEnabled = true;
            this.lstDirs.Location = new System.Drawing.Point(56, 195);
            this.lstDirs.Name = "lstDirs";
            this.lstDirs.Size = new System.Drawing.Size(190, 160);
            this.lstDirs.TabIndex = 2;
            this.lstDirs.SelectedIndexChanged += new System.EventHandler(this.LstDirs_SelectedIndexChanged);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(294, 195);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(190, 160);
            this.lstFiles.TabIndex = 3;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.LstFiles_SelectedIndexChanged);
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.Location = new System.Drawing.Point(53, 37);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(219, 20);
            this.lblInfo1.TabIndex = 5;
            this.lblInfo1.Text = "Introduce un nuevo directorio:";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(54, 70);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(276, 13);
            this.lblInfo2.TabIndex = 6;
            this.lblInfo2.Text = "(puedes usar variables de entorno encerradolas entre \'%\')";
            // 
            // lblDirectorios
            // 
            this.lblDirectorios.AutoSize = true;
            this.lblDirectorios.Location = new System.Drawing.Point(54, 169);
            this.lblDirectorios.Name = "lblDirectorios";
            this.lblDirectorios.Size = new System.Drawing.Size(60, 13);
            this.lblDirectorios.TabIndex = 7;
            this.lblDirectorios.Text = "Directorios:";
            // 
            // lblArchivos
            // 
            this.lblArchivos.AutoSize = true;
            this.lblArchivos.Location = new System.Drawing.Point(291, 169);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(51, 13);
            this.lblArchivos.TabIndex = 8;
            this.lblArchivos.Text = "Archivos:";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(523, 42);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(124, 13);
            this.lblContenido.TabIndex = 9;
            this.lblContenido.Text = "Archivo no seleccionado";
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrores.Location = new System.Drawing.Point(53, 400);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(0, 20);
            this.lblErrores.TabIndex = 10;
            // 
            // txtFiles
            // 
            this.txtFiles.Location = new System.Drawing.Point(526, 70);
            this.txtFiles.Multiline = true;
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFiles.Size = new System.Drawing.Size(200, 300);
            this.txtFiles.TabIndex = 11;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFiles);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblArchivos);
            this.Controls.Add(this.lblDirectorios);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.lstDirs);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.txtDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Archivos_Ejercicio_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.ListBox lstDirs;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblDirectorios;
        private System.Windows.Forms.Label lblArchivos;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.TextBox txtFiles;
    }
}

