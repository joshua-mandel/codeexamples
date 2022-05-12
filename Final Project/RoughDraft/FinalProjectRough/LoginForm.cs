using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectRough
{
    public partial class LoginForm : Form
    {
        Employee employee = new Employee();

        Manager manager = new Manager();

        List<Employee> employees = new List<Employee>()
        {
            new Employee("sdowns131", "Sam", "Sd12345"),
            new Employee("vbottini456", "Vinny", "Vb45678"),
            new Employee("ogibson010", "Olidaji", "Og01013")
        };

        List<Manager> managerList = new List<Manager>()
        {
            new Manager("jmandelmvp", "Josh", "Jm12345", true),
            new Manager("egudmasted989", "Evan", "Eg98989", true)
        };
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool foundEmployee = false;

                string employeeId = txtEmployeeId.Text;

                string password = txtPassword.Text;

                if(String.IsNullOrEmpty(employeeId) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter a valid Employee ID and Password");
                }
                else
                {
                    for (int i = 0; i < employees.Count && !foundEmployee; i++)
                    {
                        if(employees[i].EmployeeId == employeeId)
                        {
                            if(employees[i].Password == password)
                            {
                                employee = employees[i];
                                PointOfSaleForm form = new PointOfSaleForm(employee);
                                form.Show();
                                foundEmployee = true;
                                this.Hide();
                            }
                        }
                    }
                    for (int i = 0; i < managerList.Count; i++)
                    {
                        if (managerList[i].ManagerId == employeeId)
                        {
                            if (managerList[i].ManagerPassword == password)
                            {
                                manager = managerList[i];
                                PointOfSaleForm form = new PointOfSaleForm(manager);
                                form.Show();
                                foundEmployee = true;
                                this.Hide();
                            }
                        }
                    }
                }

                if (!foundEmployee)
                {
                    MessageBox.Show("Please enter a valid Employee ID and Password");
                    txtEmployeeId.Text = String.Empty;
                    txtPassword.Text = String.Empty;
                    txtEmployeeId.Focus();
                }
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
