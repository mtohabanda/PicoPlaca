namespace PicoPlacaApp
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
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtLicensePlateNumber = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnCheckPermission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(26, 47);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(117, 13);
            this.lblLicensePlate.TabIndex = 0;
            this.lblLicensePlate.Text = "License Plate Number: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(27, 81);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(27, 115);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time:";
            // 
            // txtLicensePlateNumber
            // 
            this.txtLicensePlateNumber.Location = new System.Drawing.Point(149, 40);
            this.txtLicensePlateNumber.Name = "txtLicensePlateNumber";
            this.txtLicensePlateNumber.Size = new System.Drawing.Size(97, 20);
            this.txtLicensePlateNumber.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(147, 74);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(99, 20);
            this.txtDate.TabIndex = 4;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(147, 112);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(99, 20);
            this.txtTime.TabIndex = 5;
            // 
            // btnCheckPermission
            // 
            this.btnCheckPermission.Location = new System.Drawing.Point(77, 161);
            this.btnCheckPermission.Name = "btnCheckPermission";
            this.btnCheckPermission.Size = new System.Drawing.Size(118, 64);
            this.btnCheckPermission.TabIndex = 6;
            this.btnCheckPermission.Text = "Check Car Permission On Road";
            this.btnCheckPermission.UseVisualStyleBackColor = true;
            this.btnCheckPermission.Click += new System.EventHandler(this.btnCheckPermission_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCheckPermission);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtLicensePlateNumber);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblLicensePlate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtLicensePlateNumber;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnCheckPermission;
    }
}

