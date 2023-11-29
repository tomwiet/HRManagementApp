using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagementApp
{
    public partial class Main : Form
    {
        private FileHelper<List<Employee>> _fileHelper =
            new FileHelper<List<Employee>>(Program.FilePath);
        
        public Main()
        {
            InitializeComponent();
            GetEmployeeData();
            
            SetDgvHeaders(dgvEmployeesActual);
            SetDgvColumns(dgvEmployeesActual);

            SetDgvHeaders(dgvEmployeesDissmised);
            SetDgvColumns(dgvEmployeesDissmised);
            
            SetDgvHeaders(dgvEmployeesAll);
            SetDgvColumns(dgvEmployeesAll);

        }

        private void SetDgvColumns(DataGridView dgv)
        {
           
            if (dgv.Columns["id"].Visible)
                dgv.Columns["id"].DisplayIndex = 0; 
            dgv.Columns["FirstName"].DisplayIndex = 1;
            dgv.Columns["LastName"].DisplayIndex = 2;
            dgv.Columns["EmploymentDate"].DisplayIndex = 3;
            dgv.Columns["DismissalDate"].DisplayIndex = 4;
            dgv.Columns["Earnings"].DisplayIndex = 5;
            dgv.Columns["Comments"].DisplayIndex = 6;
        }

        private void SetDgvHeaders(DataGridView dgv)
        {
            dgv.Columns["id"].Visible = false;
            dgv.Columns["FirstName"].HeaderText = "Imię";
            dgv.Columns["LastName"].HeaderText = "Nazwisko";
            dgv.Columns["EmploymentDate"].HeaderText = "Data zatrudnienia";          
            dgv.Columns["DismissalDate"].HeaderText = "Data zwolnienia";
            dgv.Columns["Earnings"].HeaderText = "Zarobki";
            dgv.Columns["Comments"].HeaderText = "Uwagi";           
        }


        private void GetEmployeeData()
        {
            var employees = _fileHelper.DeserializeFromFile();
            dgvEmployeesAll.DataSource = 
                employees.OrderBy(x=>x.Id).ToList();

            dgvEmployeesActual.DataSource
                = employees.FindAll(x => x.DismissalDate == null).OrderBy(x => x.Id).ToList();
            dgvEmployeesDissmised.DataSource =
                employees.FindAll(x => x.DismissalDate != null).OrderBy(x => x.Id).ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditEmployee addEmployee = new AddEditEmployee();
            addEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEmployee.ShowDialog();
        }

        private void AddEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
           GetEmployeeData();
        }
        private int? GetSelectedEmployeId(string nothingSelectedMessage)
        {
            var dgv = tcEmployees.SelectedTab.Controls.OfType<DataGridView>().First();

            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show(nothingSelectedMessage);
                return null;
            }
            
                return (int)dgv.SelectedRows[0].Cells[0].Value;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedEmployeId = GetSelectedEmployeId("Musisz zaznaczyć pracownika do edycji");

            if (selectedEmployeId == null)
                return;

            AddEditEmployee editEmployee = new AddEditEmployee((int)selectedEmployeId);
            editEmployee.FormClosing += AddEditEmployee_FormClosing;
            editEmployee.ShowDialog();

        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {

            var selectedEmployeId = GetSelectedEmployeId("Musisz zaznaczyć pracownika do zwolnienia");

            if(selectedEmployeId == null) 
                return;
            
            DismissEmployee dismissEmploye = new DismissEmployee((int)selectedEmployeId);
            dismissEmploye.FormClosing += AddEditEmployee_FormClosing;
            dismissEmploye.ShowDialog();
        }
        private void dgvEmployeesAll_SelectionChanged(object sender, EventArgs e)
        {
          
                if (dgvEmployeesAll.SelectedRows.Count == 1)
                {
                    btnDismiss.Enabled = true;
                    var date = dgvEmployeesAll.SelectedRows[0].Cells[4].Value;
                    if (date != null) btnDismiss.Enabled = false;
                }
            
        }

        private void tcEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDismiss.Enabled = true;
            if (tcEmployees.SelectedIndex == 1)
                btnDismiss.Enabled = false;
        }
    }
}
