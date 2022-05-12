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
    public partial class CashCheckoutForm : Form
    {
        //sets all checkout variables
        double taxAmount = 0;
        double totalDue = 0;
        double amountPaid = 0;
        double changeDue = 0;
        double newSubtotal;
        double newTax;

        //sets the null order object
        Order order = new Order();

        public CashCheckoutForm(ListBox lbCart, double subtotal, Order passedOrder)
        {
            
            //sets the order passed by ref to form global variable
            order = passedOrder;
            order.PaymentInProgress = true;
            
            InitializeComponent();
            lbCheckout.Items.AddRange(lbCart.Items);

            lblSubtotal.Text = $"Subtotal: {subtotal:C}";

            taxAmount = subtotal * 0.085;

            lblTaxAmount.Text = $"Tax (8.5%): {taxAmount:C}";

            totalDue = subtotal + taxAmount;

            lblTotalDue.Text = $"Amount Due: {totalDue:C}";

            order.TotalDue = totalDue;
        }

        //all of the buttons for the cash application
        private void btnPennyAdd_Click(object sender, EventArgs e)
        {
            amountPaid += 0.01;
            CashHandOver();
        }

        private void btnNickelAdd_Click(object sender, EventArgs e)
        {
            amountPaid += 0.05;
            CashHandOver();
        }

        private void btnDimeAdd_Click(object sender, EventArgs e)
        {
            amountPaid += 0.1;
            CashHandOver();
        }

        private void btnQuarterAdd_Click(object sender, EventArgs e)
        {
            amountPaid += 0.25;
            CashHandOver();
        }
        
        private void btnDollarAdd_Click(object sender, EventArgs e)
        {
            amountPaid ++;
            CashHandOver();
        }

        private void btnFiveAdd_Click(object sender, EventArgs e)
        {
            amountPaid += 5;
            CashHandOver();
        }

        private void btnTenAdd_Click(object sender, EventArgs e)
        {
            amountPaid += 10;
            CashHandOver();
        }

        private void btnTwentyAdd_Click(object sender, EventArgs e)
        {
            amountPaid += 20;
            CashHandOver();
        }

        private void btnFiftyAdd_Click(object sender, EventArgs e)
        {
            amountPaid += 50;
            CashHandOver();
        }

        private void btnHundredAdd_Click(object sender, EventArgs e)
        {
            amountPaid += 100;
            CashHandOver();
        }

        private void CashHandOver()
        {
            txtCashTendered.Text = amountPaid.ToString("N2");
        }

        //when the text in the textbox changes, update the amount paid and verify character types
        private void txtCashTendered_TextChanged(object sender, EventArgs e)
        {
            double result;

            if (string.IsNullOrEmpty(txtCashTendered.Text))
            {
                amountPaid = 0;
            }
            else if (Double.TryParse(txtCashTendered.Text, out result) && Convert.ToDouble(txtCashTendered.Text) > 0)
            {
                amountPaid = Convert.ToDouble(result);
            }
            else
            {
                MessageBox.Show("Please enter a valid amount paid");
                txtCashTendered.Clear();
                txtCashTendered.Focus();
                amountPaid = 0;
            }
        }

        //accept payment click event
        public void btnAcceptPayment_Click(object sender, EventArgs e)
        {
            order.TotalPaid = amountPaid;

            //if amount paid isnt enough, update order object and update main page
            if(amountPaid > 0 && amountPaid < totalDue)
            {
                totalDue -= amountPaid;
                order.IsPaid = false;

                order.TotalDue = totalDue;
                newSubtotal = totalDue / (1.085);

                newTax = newSubtotal * 0.085;

                lblSubtotal.Text = $"Subtotal: {newSubtotal:C}";
                lblTaxAmount.Text = $"Tax (8.5%): {newTax:C}";
                lblTotalDue.Text = $"Amount Due: {totalDue:C}";

                MessageBox.Show($"Customer still owes {totalDue:C}");
                this.Close();
            }

            //give correct change and update main page to blank order
            else if(amountPaid >= totalDue)
            {
                changeDue = amountPaid - totalDue;
                order.IsPaid = true;
                order.CouponApplied = false;
                order.TotalDue = 0;
                lblSubtotal.Text = $"Subtotal: $0.00";
                lblTaxAmount.Text = $"Tax (8.5%): $0.00";
                lblTotalDue.Text = $"Amount Due: $0.00";
                MessageBox.Show($"Change Due: {changeDue:C}");
                order.PaymentInProgress = false;
                this.Close();
            }
        }
    }
}
