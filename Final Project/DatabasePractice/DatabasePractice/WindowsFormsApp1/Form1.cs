using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        RankenDataContext RankenDB = new RankenDataContext();



        public Form1()
        {

            InitializeComponent();

            //LINQ

            //select from where orderby

            var data = RankenDB.Students
                .Select(s => s);

            List<Student> students = data.ToList();

            foreach (Student student in students)
            {
                lblResult.Text += $"{student.FirstName} {student.LastName}\n";
            }

            //Create
            //Student student1 = new Student();
            //student1.FirstName = "Holy";
            //student1.LastName = "Moly";

            //RankenDB.Students.InsertOnSubmit(student1);
            RankenDB.SubmitChanges();

            lblResult.Text = String.Empty;

            foreach (Student student in students)
            {
                lblResult.Text += $"{student.FirstName} {student.LastName}\n";
            }
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            var data = RankenDB.Students
                .Where(s => s.FirstName == "Evan")
                .Select(s => s);

            List<Student> students = data.ToList();

            students[0].FirstName = "Elizabeth";

            RankenDB.SubmitChanges();

            foreach (Student student in students)
            {
                lblResult.Text += $"{student.FirstName} {student.LastName}\n";
            }
        }
    }
}
