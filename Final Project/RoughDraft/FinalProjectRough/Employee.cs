using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectRough
{
    public class Employee
    {
        string _employeeId;
        string _employeeName;
        string _password;

        public Employee(string employeeId, string employeeName, string password)
        {
            _employeeId = employeeId;
            _employeeName = employeeName;
            _password = password;
        }

        public Employee()
        {
            _employeeId="";
            _employeeName="";
            _password = "";
        }

        public string EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        
    }
}
