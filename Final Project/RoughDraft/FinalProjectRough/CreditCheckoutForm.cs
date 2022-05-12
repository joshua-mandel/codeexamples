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
    public partial class CreditCheckoutForm : Form
    {

        //Loads the global variables and object
        Order order = new Order();
        double creditSubtotal = 0;
        double creditTaxDue = 0;
        double creditTotalDue = 0;

        //Loads the Credit Checkout form
        public CreditCheckoutForm(ListBox lbCart, double subtotal, Order passedOrder)
        {
            InitializeComponent();

            creditSubtotal = subtotal;

            creditTaxDue = creditSubtotal * 0.085;

            creditTotalDue = creditSubtotal + creditTaxDue;

            order = passedOrder;
            order.PaymentInProgress = true;

            lblSubtotal.Text = $"Subtotal: {creditSubtotal:C}";
            lblTaxAmount.Text = $"Tax (8.5%): {creditTaxDue:C}";
            lblTotalDue.Text = $"Amount Due: {creditTotalDue:C}";

            
            lbCheckout.Items.AddRange(lbCart.Items);
        }

        //Process payment click event
        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            double result;
            int resultTwo;
            int resultThree;

            //checks for correct number and type of characters in the textboxes
            if (txtCreditCardNum.Text.Length == 16 && 
             double.TryParse(txtCreditCardNum.Text, out result) && 
             txtExpirationDate.Text.Length == 5 && 
             txtExpirationDate.Text.Contains("/") && 
             txtBillingZip.Text.Length == 5 && 
             int.TryParse(txtBillingZip.Text, out resultTwo) &&
             txtCVVNum.Text.Length == 3 && 
             int.TryParse(txtCVVNum.Text, out resultThree))
            {
                order.IsPaid = true;
                order.TotalDue = 0;
                order.PaymentInProgress = false;
                order.CouponApplied = false;

                lblSubtotal.Text = $"Subtotal: {0:C}";
                lblTaxAmount.Text = $"Tax (8.5%): {0:C}";
                lblTotalDue.Text = $"Amount Due: {0:C}";

                MessageBox.Show("Your payment has been processed");
                Close();
            }
            else
            {
                MessageBox.Show("Your payment information is not valid\nPlease try again");
                order.IsPaid = false;
            }
        }
    }
}
