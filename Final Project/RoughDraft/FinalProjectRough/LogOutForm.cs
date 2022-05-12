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
    public partial class LogOutForm : Form
    {

        Employee employee = new Employee();

        public LogOutForm()
        {
            InitializeComponent();
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PointOfSaleForm pointOfSaleForm = new PointOfSaleForm(employee);
            pointOfSaleForm.Show();
            this.Close();
        }
    }
}
