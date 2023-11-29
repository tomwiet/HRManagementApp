namespace HRManagementApp
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployeesAll = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.tcEmployees = new System.Windows.Forms.TabControl();
            this.tcpEmployeesActual = new System.Windows.Forms.TabPage();
            this.dgvEmployeesActual = new System.Windows.Forms.DataGridView();
            this.tcpEmployeesDismissed = new System.Windows.Forms.TabPage();
            this.dgvEmployeesDissmised = new System.Windows.Forms.DataGridView();
            this.tcpEmployeesAll = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesAll)).BeginInit();
            this.tcEmployees.SuspendLayout();
            this.tcpEmployeesActual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesActual)).BeginInit();
            this.tcpEmployeesDismissed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesDissmised)).BeginInit();
            this.tcpEmployeesAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployeesAll
            // 
            this.dgvEmployeesAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeesAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeesAll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEmployeesAll.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeesAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeesAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeesAll.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeesAll.Location = new System.Drawing.Point(6, 6);
            this.dgvEmployeesAll.MultiSelect = false;
            this.dgvEmployeesAll.Name = "dgvEmployeesAll";
            this.dgvEmployeesAll.ReadOnly = true;
            this.dgvEmployeesAll.RowHeadersWidth = 51;
            this.dgvEmployeesAll.RowTemplate.Height = 24;
            this.dgvEmployeesAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeesAll.Size = new System.Drawing.Size(1115, 380);
            this.dgvEmployeesAll.TabIndex = 0;
            this.dgvEmployeesAll.SelectionChanged += new System.EventHandler(this.dgvEmployeesAll_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(18, 452);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMainTitle.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMainTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMainTitle.Location = new System.Drawing.Point(0, 0);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(245, 33);
            this.lblMainTitle.TabIndex = 2;
            this.lblMainTitle.Text = "Pracownicy firmy";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(124, 452);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDismiss
            // 
            this.btnDismiss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDismiss.Location = new System.Drawing.Point(230, 452);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(100, 30);
            this.btnDismiss.TabIndex = 4;
            this.btnDismiss.Text = "Zwolnij";
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // tcEmployees
            // 
            this.tcEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcEmployees.Controls.Add(this.tcpEmployeesActual);
            this.tcEmployees.Controls.Add(this.tcpEmployeesDismissed);
            this.tcEmployees.Controls.Add(this.tcpEmployeesAll);
            this.tcEmployees.Location = new System.Drawing.Point(25, 35);
            this.tcEmployees.Name = "tcEmployees";
            this.tcEmployees.SelectedIndex = 0;
            this.tcEmployees.Size = new System.Drawing.Size(1125, 411);
            this.tcEmployees.TabIndex = 5;
            this.tcEmployees.SelectedIndexChanged += new System.EventHandler(this.tcEmployees_SelectedIndexChanged);
            // 
            // tcpEmployeesActual
            // 
            this.tcpEmployeesActual.Controls.Add(this.dgvEmployeesActual);
            this.tcpEmployeesActual.Location = new System.Drawing.Point(4, 25);
            this.tcpEmployeesActual.Name = "tcpEmployeesActual";
            this.tcpEmployeesActual.Padding = new System.Windows.Forms.Padding(3);
            this.tcpEmployeesActual.Size = new System.Drawing.Size(1117, 382);
            this.tcpEmployeesActual.TabIndex = 1;
            this.tcpEmployeesActual.Text = "Aktualni";
            this.tcpEmployeesActual.UseVisualStyleBackColor = true;
            // 
            // dgvEmployeesActual
            // 
            this.dgvEmployeesActual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeesActual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeesActual.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEmployeesActual.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeesActual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployeesActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeesActual.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployeesActual.Location = new System.Drawing.Point(1, 1);
            this.dgvEmployeesActual.MultiSelect = false;
            this.dgvEmployeesActual.Name = "dgvEmployeesActual";
            this.dgvEmployeesActual.ReadOnly = true;
            this.dgvEmployeesActual.RowHeadersWidth = 51;
            this.dgvEmployeesActual.RowTemplate.Height = 24;
            this.dgvEmployeesActual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeesActual.Size = new System.Drawing.Size(1115, 380);
            this.dgvEmployeesActual.TabIndex = 1;
            // 
            // tcpEmployeesDismissed
            // 
            this.tcpEmployeesDismissed.Controls.Add(this.dgvEmployeesDissmised);
            this.tcpEmployeesDismissed.Location = new System.Drawing.Point(4, 25);
            this.tcpEmployeesDismissed.Name = "tcpEmployeesDismissed";
            this.tcpEmployeesDismissed.Size = new System.Drawing.Size(1117, 382);
            this.tcpEmployeesDismissed.TabIndex = 2;
            this.tcpEmployeesDismissed.Text = "Zwolnieni";
            this.tcpEmployeesDismissed.UseVisualStyleBackColor = true;
            // 
            // dgvEmployeesDissmised
            // 
            this.dgvEmployeesDissmised.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeesDissmised.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeesDissmised.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEmployeesDissmised.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeesDissmised.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmployeesDissmised.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeesDissmised.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployeesDissmised.Location = new System.Drawing.Point(1, 1);
            this.dgvEmployeesDissmised.MultiSelect = false;
            this.dgvEmployeesDissmised.Name = "dgvEmployeesDissmised";
            this.dgvEmployeesDissmised.ReadOnly = true;
            this.dgvEmployeesDissmised.RowHeadersWidth = 51;
            this.dgvEmployeesDissmised.RowTemplate.Height = 24;
            this.dgvEmployeesDissmised.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeesDissmised.Size = new System.Drawing.Size(1115, 380);
            this.dgvEmployeesDissmised.TabIndex = 1;
            // 
            // tcpEmployeesAll
            // 
            this.tcpEmployeesAll.Controls.Add(this.dgvEmployeesAll);
            this.tcpEmployeesAll.Location = new System.Drawing.Point(4, 25);
            this.tcpEmployeesAll.Name = "tcpEmployeesAll";
            this.tcpEmployeesAll.Padding = new System.Windows.Forms.Padding(3);
            this.tcpEmployeesAll.Size = new System.Drawing.Size(1117, 382);
            this.tcpEmployeesAll.TabIndex = 0;
            this.tcpEmployeesAll.Text = "Wszyscy";
            this.tcpEmployeesAll.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 494);
            this.Controls.Add(this.tcEmployees);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.btnAdd);
            this.Name = "Main";
            this.Text = "HR Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesAll)).EndInit();
            this.tcEmployees.ResumeLayout(false);
            this.tcpEmployeesActual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesActual)).EndInit();
            this.tcpEmployeesDismissed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesDissmised)).EndInit();
            this.tcpEmployeesAll.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeesAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.TabControl tcEmployees;
        private System.Windows.Forms.TabPage tcpEmployeesAll;
        private System.Windows.Forms.TabPage tcpEmployeesActual;
        private System.Windows.Forms.TabPage tcpEmployeesDismissed;
        private System.Windows.Forms.DataGridView dgvEmployeesActual;
        private System.Windows.Forms.DataGridView dgvEmployeesDissmised;
    }
}

