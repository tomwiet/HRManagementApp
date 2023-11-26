namespace HRManagementApp
{
    partial class DismissEmployee
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
            this.lblEmployeInfo = new System.Windows.Forms.Label();
            this.dtpDissmisDate = new System.Windows.Forms.DateTimePicker();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDismissDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmployeInfo
            // 
            this.lblEmployeInfo.AutoSize = true;
            this.lblEmployeInfo.Location = new System.Drawing.Point(51, 17);
            this.lblEmployeInfo.Name = "lblEmployeInfo";
            this.lblEmployeInfo.Size = new System.Drawing.Size(151, 16);
            this.lblEmployeInfo.TabIndex = 0;
            this.lblEmployeInfo.Text = "Informacje o pracowniku";
            // 
            // dtpDissmisDate
            // 
            this.dtpDissmisDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDissmisDate.Location = new System.Drawing.Point(127, 76);
            this.dtpDissmisDate.Name = "dtpDissmisDate";
            this.dtpDissmisDate.Size = new System.Drawing.Size(115, 22);
            this.dtpDissmisDate.TabIndex = 1;
            // 
            // btnDismiss
            // 
            this.btnDismiss.Location = new System.Drawing.Point(86, 123);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(75, 23);
            this.btnDismiss.TabIndex = 2;
            this.btnDismiss.Text = "Zwolnij";
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(167, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblDismissDate
            // 
            this.lblDismissDate.AutoSize = true;
            this.lblDismissDate.Location = new System.Drawing.Point(12, 81);
            this.lblDismissDate.Name = "lblDismissDate";
            this.lblDismissDate.Size = new System.Drawing.Size(101, 16);
            this.lblDismissDate.TabIndex = 4;
            this.lblDismissDate.Text = "Data zwolnienia";
            // 
            // DismissEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 188);
            this.Controls.Add(this.lblDismissDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.dtpDissmisDate);
            this.Controls.Add(this.lblEmployeInfo);
            this.Name = "DismissEmployee";
            this.Text = "Zwolnij pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeInfo;
        private System.Windows.Forms.DateTimePicker dtpDissmisDate;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDismissDate;
    }
}