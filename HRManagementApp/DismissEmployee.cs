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
    public partial class DismissEmployee : Form
    {
        FileHelper<List<Employee>> _fileHelper = 
                new FileHelper<List<Employee>>(Program.FilePath);
        private int _employeeId;
        private Employee _employe;
        public DismissEmployee(int selectedEmployeId)
        { 
            
            InitializeComponent();
            _employeeId = selectedEmployeId;
            GetEmployeToDismiss();

        }

        private void GetEmployeToDismiss()
        {
            var employees = _fileHelper.DeserializeFromFile();
            _employe = employees.FirstOrDefault(x => x.Id == _employeeId);
            lblEmployeInfo.Text += $" {_employe.FirstName} " +
                $"{_employe.LastName} " +
                $"zatrudniony od {_employe.EmploymentDate.ToShortDateString()}"; 
           
         }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();
            _employe.DismissalDate = dtpDissmisDate.Value.Date;
            employees.RemoveAll(x => x.Id == _employeeId);
            employees.Add(_employe);
            _fileHelper.SerializeToFile(employees);
            Close();
        }
    }
}
