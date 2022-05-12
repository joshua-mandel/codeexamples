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
    public partial class GiftCardCheckoutForm : Form
    {
        Order order = new Order();
        double giftCardSubtotal = 0;
        double giftCardTax = 0;
        double giftCardTotal = 0;
        double giftCardBalance = 500;

        public GiftCardCheckoutForm(ListBox lbCart, double subtotal, Order passedOrder)
        {
            InitializeComponent();

            lbCheckout.Items.AddRange(lbCart.Items);

            order = passedOrder;

            giftCardSubtotal = subtotal;

            giftCardTax = giftCardSubtotal * 0.085;

            giftCardTotal = giftCardSubtotal + giftCardTax;

            order.PaymentInProgress = true;

            lblSubtotal.Text = $"Subtotal: {giftCardSubtotal:C}";
            lblTaxAmount.Text = $"Tax (8.5%): {giftCardTax:C}";
            lblTotalDue.Text = $"Amount Due: {giftCardTotal:C}";
        }

        private void btnProcessGiftCard_Click(object sender, EventArgs e)
        {
            giftCardBalance = 500;
            string giftCardNum = txtGiftCardNum.Text;

            double paymentAmount = Convert.ToDouble(txtPaymentAmount.Text);


            if (paymentAmount > giftCardTotal + 0.01)
            {
                MessageBox.Show($"Please enter a valid payment amount");
            }
            else if (giftCardNum.Length == 7 && giftCardBalance >= paymentAmount)
            {
                giftCardBalance -= paymentAmount;

                lblRemainingBalance.Text = $"Remaining Balance: {giftCardBalance:C}";

                order.TotalDue -= paymentAmount;

                MessageBox.Show($"Thank you for your purchase. Your remaining balance is {giftCardBalance:C}");

                if (order.TotalDue == 0 || order.TotalDue < 0.02)
                {
                    giftCardSubtotal = 0;

                    giftCardTax = 0;

                    giftCardTotal = 0;

                    lblSubtotal.Text = $"Subtotal: {giftCardSubtotal:C}";
                    lblTaxAmount.Text = $"Tax (8.5%): {giftCardTax:C}";
                    lblTotalDue.Text = $"Amount Due: {giftCardTotal:C}";

                    order.IsPaid = true;
                    order.TotalDue = 0;
                    order.CouponApplied = false;

                    this.Close();
                }
                else if(order.TotalDue > 0.02)
                {
                    giftCardTotal = order.TotalDue;

                    giftCardSubtotal = giftCardTotal / 1.085;

                    giftCardTax = giftCardSubtotal * 0.085;

                    giftCardTotal = giftCardSubtotal + giftCardTax;

                    order.PaymentInProgress = true;

                    lblSubtotal.Text = $"Subtotal: {giftCardSubtotal:C}";
                    lblTaxAmount.Text = $"Tax (8.5%): {giftCardTax:C}";
                    lblTotalDue.Text = $"Amount Due: {giftCardTotal:C}";

                    this.Close();
                }

                
            }
            else
            {
                MessageBox.Show("Please enter a valid gift card or reduce payment amount");
            }
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            if(txtGiftCardCheckBalance.Text == "1111111")
            {
                MessageBox.Show($"Your balance is currently {giftCardBalance:C}");
                txtGiftCardCheckBalance.Clear();
            }
            else
            {
                MessageBox.Show($"Please enter a valid gift card");
            }
        }
    }
}
