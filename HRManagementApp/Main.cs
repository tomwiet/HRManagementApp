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
            if(dgvEmployees.Columns["id"].Visible)
                dgvEmployees.Columns["id"].DisplayIndex = 0; 
            dgvEmployees.Columns["FirstName"].DisplayIndex = 1;
            dgvEmployees.Columns["LastName"].DisplayIndex = 2;
            dgvEmployees.Columns["EmploymentDate"].DisplayIndex = 3;
            dgvEmployees.Columns["DismissalDate"].DisplayIndex = 4;
            dgvEmployees.Columns["Earnings"].DisplayIndex = 5;
            dgvEmployees.Columns["Comments"].DisplayIndex = 6;
        }

        private void SetDgvHeaders()
        {
            dgvEmployees.Columns["id"].Visible = true;
            dgvEmployees.Columns["FirstName"].HeaderText = "Imię";
            dgvEmployees.Columns["LastName"].HeaderText = "Nazwisko";
            dgvEmployees.Columns["EmploymentDate"].HeaderText = "Data zatrudnienia";          
            dgvEmployees.Columns["DismissalDate"].HeaderText = "Data zwolnienia";
            dgvEmployees.Columns["Earnings"].HeaderText = "Zarobki";
            dgvEmployees.Columns["Comments"].HeaderText = "Uwagi";           
        }


        private void GetEmployeeData()
        {
            dgvEmployees.DataSource = 
                _fileHelper.DeserializeFromFile().OrderBy(x=>x.Id).ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditEmployee addEditEmployee = new AddEditEmployee();
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.ShowDialog();
        }

        private void AddEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
           GetEmployeeData();
        }
    }
}
