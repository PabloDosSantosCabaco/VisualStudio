namespace Hilos_2
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
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblErrorPID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(44, 60);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(454, 342);
            this.txtInfo.TabIndex = 0;
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(621, 89);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(100, 20);
            this.txtPID.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(504, 60);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(111, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View Processes";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(504, 89);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(111, 23);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Process Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(504, 118);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close Process";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(504, 147);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(111, 23);
            this.btnKill.TabIndex = 5;
            this.btnKill.Text = "Kill Process";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(504, 176);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(111, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run app";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblErrorPID
            // 
            this.lblErrorPID.AutoSize = true;
            this.lblErrorPID.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorPID.Location = new System.Drawing.Point(748, 97);
            this.lblErrorPID.Name = "lblErrorPID";
            this.lblErrorPID.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPID.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErrorPID);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.txtInfo);
            this.Name = "Form1";
            this.Text = "Procesos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblErrorPID;
    }
}

