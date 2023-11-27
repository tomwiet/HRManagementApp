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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployeesAll = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.tcEmployees = new System.Windows.Forms.TabControl();
            this.tcpEmployeesActual = new System.Windows.Forms.TabPage();
            this.dgvEmpleyedActual = new System.Windows.Forms.DataGridView();
            this.tcpEmployeesDismissed = new System.Windows.Forms.TabPage();
            this.dgvEmployeesDissmised = new System.Windows.Forms.DataGridView();
            this.tcpEmployeesAll = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesAll)).BeginInit();
            this.tcEmployees.SuspendLayout();
            this.tcpEmployeesActual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleyedActual)).BeginInit();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeesAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEmployeesAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeesAll.DefaultCellStyle = dataGridViewCellStyle8;
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
            this.tcpEmployeesActual.Controls.Add(this.dgvEmpleyedActual);
            this.tcpEmployeesActual.Location = new System.Drawing.Point(4, 25);
            this.tcpEmployeesActual.Name = "tcpEmployeesActual";
            this.tcpEmployeesActual.Padding = new System.Windows.Forms.Padding(3);
            this.tcpEmployeesActual.Size = new System.Drawing.Size(1117, 382);
            this.tcpEmployeesActual.TabIndex = 1;
            this.tcpEmployeesActual.Text = "Aktualni";
            this.tcpEmployeesActual.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleyedActual
            // 
            this.dgvEmpleyedActual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleyedActual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleyedActual.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEmpleyedActual.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleyedActual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEmpleyedActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleyedActual.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEmpleyedActual.Location = new System.Drawing.Point(1, 1);
            this.dgvEmpleyedActual.MultiSelect = false;
            this.dgvEmpleyedActual.Name = "dgvEmpleyedActual";
            this.dgvEmpleyedActual.ReadOnly = true;
            this.dgvEmpleyedActual.RowHeadersWidth = 51;
            this.dgvEmpleyedActual.RowTemplate.Height = 24;
            this.dgvEmpleyedActual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleyedActual.Size = new System.Drawing.Size(1115, 380);
            this.dgvEmpleyedActual.TabIndex = 1;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeesDissmised.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEmployeesDissmised.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeesDissmised.DefaultCellStyle = dataGridViewCellStyle12;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleyedActual)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvEmpleyedActual;
        private System.Windows.Forms.DataGridView dgvEmployeesDissmised;
    }
}

