using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagementApp
{
    public partial class AddEditEmployee : Form
    {
        private FileHelper<List<Employee>> _fileHelper =
            new FileHelper<List<Employee>>(Program.FilePath);

        private int _employeeId;
        private Employee _employee;

        public AddEditEmployee(int Id=0)
        {
            InitializeComponent();
            Text = "Dodaj pracownika";
            _employeeId = Id;
            GetEmployeeData();
            tbFirstname.Select();
            
        }

        private void FillEditingForm()
        {

            if(_employee.FirstName != null)
                tbFirstname.Text = _employee.FirstName.Trim();
            if(_employee.LastName != null)
                tbLastName.Text = _employee.LastName.Trim();
            tbEarnings.Text = _employee.Earnings.ToString().Trim();
            dtpEmploymentDate.Value = _employee.EmploymentDate;
            dtpDismissalDate.Value = _employee.DismissalDate;
            if(_employee.Comments != null)
            rtbComments.Text = _employee.Comments.Trim();


        }

        private void GetEmployeeData()
        {
            Text = "Edytuj dane pracownika";
            if (_employeeId != 0)
            {
                var employes = _fileHelper.DeserializeFromFile();
                _employee = employes.FirstOrDefault(x=>x.Id==_employeeId);

                if(_employee == null) 
                {
                    throw new Exception("Nie ma użytkownika o danym ID");
                }
                FillEditingForm();
            }


            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();



            if (_employeeId != 0)

                employees.RemoveAll(x => x.Id == _employeeId);
            else
                AssignIdToNewEmployee(employees);

            
            AddNewEmployeeToList(employees);
            _fileHelper.SerializeToFile(employees);
            
            Close();

            
        }

        private void AddNewEmployeeToList(List<Employee> employees)
        {
            if(!float.TryParse(tbEarnings.Text, out float earnings))
                earnings = 0;

            var employee = new Employee()
            {

                Id = _employeeId,
                FirstName = tbFirstname.Text,
                LastName = tbLastName.Text,
                EmploymentDate = dtpEmploymentDate.Value.Date,
                DismissalDate = dtpDismissalDate.Value.Date,
                Comments = rtbComments.Text,
                Earnings = earnings

            };
            employees.Add(employee);
        }

        private void AssignIdToNewEmployee(List<Employee> employees)
        {
            var employeeWithHighestId = employees.OrderByDescending(x=> x.Id).FirstOrDefault();
            _employeeId = (employeeWithHighestId == null) ? 1 : employeeWithHighestId.Id + 1;
            
        }
    }
}
