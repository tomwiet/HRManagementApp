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
            SetDgvHeaders();
            SetDgvColumns();

        }

        private void SetDgvColumns()
        {
            if(dgvEmployeesAll.Columns["id"].Visible)
                dgvEmployeesAll.Columns["id"].DisplayIndex = 0; 
            dgvEmployeesAll.Columns["FirstName"].DisplayIndex = 1;
            dgvEmployeesAll.Columns["LastName"].DisplayIndex = 2;
            dgvEmployeesAll.Columns["EmploymentDate"].DisplayIndex = 3;
            dgvEmployeesAll.Columns["DismissalDate"].DisplayIndex = 4;
            dgvEmployeesAll.Columns["Earnings"].DisplayIndex = 5;
            dgvEmployeesAll.Columns["Comments"].DisplayIndex = 6;
        }

        private void SetDgvHeaders()
        {
            dgvEmployeesAll.Columns["id"].Visible = false;
            dgvEmployeesAll.Columns["FirstName"].HeaderText = "Imię";
            dgvEmployeesAll.Columns["LastName"].HeaderText = "Nazwisko";
            dgvEmployeesAll.Columns["EmploymentDate"].HeaderText = "Data zatrudnienia";          
            dgvEmployeesAll.Columns["DismissalDate"].HeaderText = "Data zwolnienia";
            dgvEmployeesAll.Columns["Earnings"].HeaderText = "Zarobki";
            dgvEmployeesAll.Columns["Comments"].HeaderText = "Uwagi";           
        }


        private void GetEmployeeData()
        {
            var employees = _fileHelper.DeserializeFromFile();
            dgvEmployeesAll.DataSource = 
                employees.OrderBy(x=>x.Id).ToList();

            dgvEmpleyedActual.DataSource 
                = employees.Select(x => x.DismissalDate == null).ToList();

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

        private void btnEdit_Click(object sender, EventArgs e)
        {   
            
            
            if(dgvEmployeesAll.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Musisz zaznaczyć pracownika do edycji");
                return;
            }
            var selectedEmployeId 
                = (int) dgvEmployeesAll.SelectedRows[0].Cells[0].Value;

            AddEditEmployee editEmployee = new AddEditEmployee(selectedEmployeId);
            editEmployee.FormClosing += AddEditEmployee_FormClosing;
            editEmployee.ShowDialog();

        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            if (dgvEmployeesAll.SelectedRows.Count == 0)
            {
                MessageBox.Show("Musisz zaznaczyć pracownika do zwolnienia");
                return;
            }
            var selectedEmployeId
                = (int)dgvEmployeesAll.SelectedRows[0].Cells[0].Value;
            DismissEmployee dismissEmploye = new DismissEmployee(selectedEmployeId);
            dismissEmploye.FormClosing += AddEditEmployee_FormClosing;
            dismissEmploye.ShowDialog();
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployeesAll.SelectedRows.Count == 1)
            {
                btnDismiss.Enabled = true;
                var date = dgvEmployeesAll.SelectedRows[0].Cells[4].Value;
                if(date != null) btnDismiss.Enabled = false;
            }
            
        }
    }
}
