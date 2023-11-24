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
    public partial class AddEditEmployee : Form
    {
        private FileHelper<List<Employee>> _fileHelper =
            new FileHelper<List<Employee>>(Program.FilePath);

        private int _employeeId;

        public AddEditEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();

            _employeeId = employees.

            if(employees != null )
            {
                //znajdz najwieksze id
            }
        }
    }
}
