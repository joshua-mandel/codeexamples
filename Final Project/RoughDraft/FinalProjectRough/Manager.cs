using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectRough
{
    public class Manager : Employee
    {
        private bool _isManager;
        string _employeeId;
        string _employeeName;
        string _password;

        public Manager(string employeeId, string employeeName, string password, bool isManager) : base(employeeId, employeeName, password)
        {
            _employeeId = employeeId;
            _employeeName = employeeName;
            _password = password;
            _isManager = isManager;
        }

        public Manager()
        {
            _employeeId = "";
            _employeeName = "";
            _password = "";
            _isManager = true;
        }

        public string ManagerPassword
        {
            get { return _password; }
            set { _password = value; }
        }

        public string ManagerName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        public string ManagerId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        public bool IsManager
        {
            get { return _isManager; }
            set { _isManager = value; }
        }
    }
}
