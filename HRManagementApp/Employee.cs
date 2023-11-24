using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp
{
    internal class Employee
    {
        public int Id { get; set; } 
        public string FitsName { get; set; }
        public string LastName { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime DismissalDate { get; set; }
        public float Earnings { get; set; }
        public string Coments {  get; set; }

    }
}
