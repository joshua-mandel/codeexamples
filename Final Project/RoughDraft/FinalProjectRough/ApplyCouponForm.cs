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
    public partial class ApplyCouponForm : Form
    {
        Order order = new Order();

        double couponSubtotal = 0;
        double couponTaxDue = 0;
        double couponTotalDue = 0;
        double couponSubtotalDiscount = 0;

        public ApplyCouponForm(ListBox lbCart, double subtotal, Order passedOrder)
        {
            InitializeComponent();

            order = passedOrder;

            lbCheckout.Items.AddRange(lbCart.Items);

            couponSubtotal = subtotal;

            couponTaxDue = couponSubtotal * 0.085;

            couponTotalDue = couponSubtotal + couponTaxDue;

            lblSubtotal.Text = $"Subtotal: {couponSubtotal:C}";
            lblTaxAmount.Text = $"Tax (8.5%): {couponTaxDue:C}";
            lblTotalDue.Text = $"Total Payment Due: {couponTotalDue:C}";

            order.PaymentInProgress = true;
        }

        private void btnApplyCoupon_Click(object sender, EventArgs e)
        {
            if(txtCouponNum.Text == "APPLY15" && !order.CouponApplied)
            {
                couponSubtotalDiscount = couponSubtotal * 0.15;

                MessageBox.Show($"Your coupon code {txtCouponNum.Text} has been applied");

                UpdatePrice();
            }
            else if(txtCouponNum.Text == "APPLY10" && !order.CouponApplied)
            {
                couponSubtotalDiscount = couponSubtotal * 0.1;

                MessageBox.Show($"Your coupon code {txtCouponNum.Text} has been applied");

                UpdatePrice();
            }
            else if(txtCouponNum.Text == "APPLY5" && !order.CouponApplied)
            {
                couponSubtotalDiscount = couponSubtotal * 0.05;

                MessageBox.Show($"Your coupon code {txtCouponNum.Text} has been applied");

                UpdatePrice();
            }
            else
            {
                MessageBox.Show($"Your coupon code has either already been applied or is not valid");
            }

            txtCouponNum.Clear();
            txtCouponNum.Focus();
        }

        private void UpdatePrice()
        {
            couponSubtotal -= couponSubtotalDiscount;

            couponTaxDue = couponSubtotal * 0.085;

            couponTotalDue = couponSubtotal + couponTaxDue;

            lblSubtotal.Text = $"Subtotal: {couponSubtotal:C}";
            lblTaxAmount.Text = $"Tax (8.5%): {couponTaxDue:C}";
            lblTotalDue.Text = $"Total Payment Due: {couponTotalDue:C}";
            lblDiscountAmount.Text = $"Discount Amount: {couponSubtotalDiscount:C}";

            order.TotalDue = couponTotalDue;
            order.CouponApplied = true;
        }
    }
}
