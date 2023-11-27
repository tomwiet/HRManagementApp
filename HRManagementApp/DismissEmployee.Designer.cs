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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmployeInfo
            // 
            this.lblEmployeInfo.AutoSize = true;
            this.lblEmployeInfo.Location = new System.Drawing.Point(12, 41);
            this.lblEmployeInfo.Name = "lblEmployeInfo";
            this.lblEmployeInfo.Size = new System.Drawing.Size(161, 16);
            this.lblEmployeInfo.TabIndex = 0;
            this.lblEmployeInfo.Text = "{Informacje o pracowniku}";
            // 
            // dtpDissmisDate
            // 
            this.dtpDissmisDate.Checked = false;
            this.dtpDissmisDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDissmisDate.Location = new System.Drawing.Point(127, 76);
            this.dtpDissmisDate.Name = "dtpDissmisDate";
            this.dtpDissmisDate.Size = new System.Drawing.Size(115, 22);
            this.dtpDissmisDate.TabIndex = 1;
            // 
            // btnDismiss
            // 
            this.btnDismiss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(167, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDismissDate
            // 
            this.lblDismissDate.AutoSize = true;
            this.lblDismissDate.Location = new System.Drawing.Point(12, 76);
            this.lblDismissDate.Name = "lblDismissDate";
            this.lblDismissDate.Size = new System.Drawing.Size(101, 16);
            this.lblDismissDate.TabIndex = 4;
            this.lblDismissDate.Text = "Data zwolnienia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informacje o zwalnianym pracowniku";
            // 
            // DismissEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 166);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}