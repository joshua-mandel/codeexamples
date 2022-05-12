using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MoreLinq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectRough
{
    public partial class PointOfSaleForm : Form
    {
        //Initialize the Database
        AutoZoneDBDataContext productDb = new AutoZoneDBDataContext();

        //Set the subtotal to 0
        double subtotal = 0;

        Order order = new Order();

        List<GiftCard> giftCards = new List<GiftCard>()
        {
            new GiftCard("1234567", 150),
            new GiftCard("9876543", 200),
            new GiftCard("1112233", 100),
            new GiftCard("1111111", 25000),
            new GiftCard("2222222", 100)
        };

        Employee employeeLoggedIn = new Employee();

        Manager managerLoggedIn = new Manager();

        public PointOfSaleForm(Employee employee)
        {
            InitializeComponent();

            employeeLoggedIn = employee;

            //Set the navigation items for the main menu navigation
            string[] navItems = new string[] { "Main Menu | Point of Sale", "Manager Mode", "Log Out" };
            cbMenuNavigation.Items.AddRange(navItems);
            cbMenuNavigation.SelectedItem = navItems[0];
        }

        public PointOfSaleForm(Manager manager)
        {
            InitializeComponent();

            managerLoggedIn = manager;

            //Set the navigation items for the main menu navigation
            string[] navItems = new string[] { "Main Menu | Point of Sale", "Manager Mode", "Log Out" };
            cbMenuNavigation.Items.AddRange(navItems);
            cbMenuNavigation.SelectedItem = navItems[0];
        }

        private void PointOfSaleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Exit the application if the point of sale form closes to prevent bugs
            Application.Exit();
        }

        private void bthCashCheckout_Click(object sender, EventArgs e)
        {
            //check if the cart is empty
            if(lbCart.Items.Count > 0)
            {
                //if the cash recieved is less than the order amount it will update the cart to what customer paid
                CashCheckoutForm cashCheckout = new CashCheckoutForm(lbCart, subtotal, order);
                cashCheckout.ShowDialog();
                if (order.TotalDue > 0)
                {
                    double newTotalDue = order.TotalDue;
                    double newSubtotal = newTotalDue / (1.085);
                    subtotal = newSubtotal;
                    UpdatePrice();
                }

                //resets the form after customer has paid
                else
                {
                    CartClear();
                    order.TotalDue = 0;
                    order.TotalPaid = 0;
                    order.PaymentInProgress = false;
                    order.IsPaid = false;
                }
            }
        }
        private void btnCreditCheckout_Click(object sender, EventArgs e)
        {
            //check if the cart is empty
            if (lbCart.Items.Count > 0)
            {
                CreditCheckoutForm creditCheckout = new CreditCheckoutForm(lbCart, subtotal, order);
                creditCheckout.ShowDialog();
                if(order.IsPaid)
                {
                    CartClear();
                    order.TotalDue = 0;
                    order.TotalPaid = 0;
                    order.PaymentInProgress = false;
                    order.IsPaid = false;
                }
            }
        }
        private void btnGiftCardCheckout_Click(object sender, EventArgs e)
        {
            //check if the cart is empty
            if (lbCart.Items.Count > 0)
            {
                GiftCardCheckoutForm giftCardCheckout = new GiftCardCheckoutForm(lbCart, subtotal, order);
                giftCardCheckout.ShowDialog();

                if(order.IsPaid)
                {
                    order.PaymentInProgress = false;
                    CartClear();
                    order.TotalDue = 0;
                    order.TotalPaid = 0;
                    UpdatePrice();
                    order.IsPaid = false;
                }
                else
                {
                    double newTotalDue = order.TotalDue;
                    double newSubtotal = newTotalDue / (1.085);
                    subtotal = newSubtotal;
                    UpdatePrice();
                }
            }
        }
        private void btnApplyCoupon_Click(object sender, EventArgs e)
        {
            //check if the cart is empty
            if (lbCart.Items.Count > 0 && !order.CouponApplied)
            {
                ApplyCouponForm applyCouponForm = new ApplyCouponForm(lbCart, subtotal, order);
                applyCouponForm.ShowDialog();

                if (order.TotalDue > 0)
                {
                    double newTotalDue = order.TotalDue;
                    double newSubtotal = newTotalDue / (1.085);
                    subtotal = newSubtotal;
                    UpdatePrice();
                    if(order.CouponApplied)
                    {
                        lblCouponApplied.Visible = true;
                    }
                }
            }
        }
        private void cbMenuNavigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //navigates to different forms of the application
            if(cbMenuNavigation.SelectedIndex == 1)
            {
                if (managerLoggedIn.IsManager)
                {
                    ManagerModeForm managerModeForm = new ManagerModeForm();
                    managerModeForm.ShowDialog();
                    cbMenuNavigation.SelectedIndex = 0;
                    PointOfSaleForm newForm = new PointOfSaleForm(managerLoggedIn);
                    newForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"{employeeLoggedIn.EmployeeName}, Please ask a manager to log in before \nadding, deleting, or editing products in the database.");
                    cbMenuNavigation.SelectedIndex = 0;
                }
                
            }
            if(cbMenuNavigation.SelectedIndex == 2)
            {
                LogOutForm logOutForm = new LogOutForm();
                logOutForm.Show();
                this.Hide();
            }
        }

        //Adds dynamically created buttons based on the number of items in a certain category
        public void cbProductCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears the buttons in the group box if the product category changes
            gbProducts.Controls.Clear();

            //Sets the default margins for the buttons
            int topDistance = 10;
            int leftDistance = 5;
            int buttonCount = 0;

            //adds buttons for cleaning products
            if (cbProductCategories.SelectedIndex == 0)
            {
                var cleaningData = productDb.Products
                .Where(c => c.ProductCategory == "Cleaning Products")
                .Select(c => c).ToList();

                for (int i = 0; i < cleaningData.Count; i++)
                {
                    buttonCount++;
                    Button btn = new Button();
                    gbProducts.Controls.Add(btn);
                    btn.Location = new Point(leftDistance, topDistance);
                    btn.ForeColor = Color.DarkBlue;
                    btn.BackColor = Color.LightCyan;
                    btn.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    btn.Size = new Size(530, 40);
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Click += new EventHandler(ProductAdd);
                    btn.Text = $"{cleaningData[i].ProductName} {cleaningData[i].ProductDescription}\nPrice: {cleaningData[i].UnitPrice:C}";
                    topDistance += 43;
                }
            }

            //adds buttons for motor oil products
            if (cbProductCategories.SelectedIndex == 1)
            {
                var motorOilData = productDb.Products
                .Where(c => c.ProductCategory == "Motor Oil")
                .Select(c => c).ToList();

                for (int i = 0; i < motorOilData.Count; i++)
                {
                    buttonCount++;
                    Button btn = new Button();
                    gbProducts.Controls.Add(btn);
                    btn.Location = new Point(leftDistance, topDistance);
                    btn.ForeColor = Color.DarkBlue;
                    btn.BackColor = Color.LightCyan;
                    btn.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    btn.Size = new Size(530, 40);
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Click += new EventHandler(ProductAdd);
                    btn.Text = $"{motorOilData[i].ProductName} {motorOilData[i].ProductDescription}\nPrice: {motorOilData[i].UnitPrice:C}";
                    topDistance += 43;
                }
            }

            //adds buttons for spark plug products
            if (cbProductCategories.SelectedIndex == 2)
            {
                var sparkPlugsData = productDb.Products
                .Where(c => c.ProductCategory == "Spark Plugs")
                .Select(c => c).ToList();

                for (int i = 0; i < sparkPlugsData.Count; i++)
                {
                    buttonCount++;
                    Button btn = new Button();
                    gbProducts.Controls.Add(btn);
                    btn.Location = new Point(leftDistance, topDistance);
                    btn.ForeColor = Color.DarkBlue;
                    btn.BackColor = Color.LightCyan;
                    btn.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    btn.Size = new Size(530, 40);
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Click += new EventHandler(ProductAdd);
                    btn.Text = $"{sparkPlugsData[i].ProductName} {sparkPlugsData[i].ProductDescription}\nPrice: {sparkPlugsData[i].UnitPrice:C}";
                    topDistance += 43;
                }
            }

            //adds buttons for tire products
            if (cbProductCategories.SelectedIndex == 3)
            {
                var tireData = productDb.Products
                .Where(c => c.ProductCategory == "Tires")
                .Select(c => c).ToList();

                for (int i = 0; i < tireData.Count; i++)
                {
                    buttonCount++;
                    Button btn = new Button();
                    gbProducts.Controls.Add(btn);
                    btn.Location = new Point(leftDistance, topDistance);
                    btn.ForeColor = Color.DarkBlue;
                    btn.BackColor = Color.LightCyan;
                    btn.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    btn.Size = new Size(530, 40);
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Click += new EventHandler(ProductAdd);
                    btn.Text = $"{tireData[i].ProductName} {tireData[i].ProductDescription}\nPrice: {tireData[i].UnitPrice:C}";
                    topDistance += 43;
                }
            }

            //adds buttons for windshield wiper products
            if (cbProductCategories.SelectedIndex == 4)
            {
                var windshieldWiperData = productDb.Products
                .Where(c => c.ProductCategory == "Windshield Wipers")
                .Select(c => c).ToList();

                for (int i = 0; i < windshieldWiperData.Count; i++)
                {
                    buttonCount++;
                    Button btn = new Button();
                    gbProducts.Controls.Add(btn);
                    btn.Location = new Point(leftDistance, topDistance);
                    btn.ForeColor = Color.DarkBlue;
                    btn.BackColor = Color.LightCyan;
                    btn.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    btn.Size = new Size(530, 40);
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Click += new EventHandler(ProductAdd);
                    btn.Text = $"{windshieldWiperData[i].ProductName} {windshieldWiperData[i].ProductDescription}\n" +
                        $"Price: {windshieldWiperData[i].UnitPrice:C}";
                    topDistance += 43;

                }
            }
        }

        private void ProductAdd(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            //copies the text of the clicked button to a variable
            string buttonString = btn.Text;

            //adds cleaning product to cart per button click
            if(cbProductCategories.SelectedIndex == 0)
            {
                var cleaningData = productDb.Products
                .Where(c => c.ProductCategory == "Cleaning Products")
                .Select(c => c).ToList();

                for (int i = 0; i < cleaningData.Count; i++)
                {
                    if(buttonString == $"{cleaningData[i].ProductName} {cleaningData[i].ProductDescription}\n" +
                        $"Price: {cleaningData[i].UnitPrice:C}")
                    {
                        lbCart.Items.Add(new CartItem { Name = $"{cleaningData[i].ProductName} " +
                            $"{cleaningData[i].ProductDescription} Price: {cleaningData[i].UnitPrice:C}", 
                            Value = cleaningData[i].UnitPrice});

                        subtotal += cleaningData[i].UnitPrice;
                        UpdatePrice();
                    }
                }
            }

            //adds motor oil product to cart per button click
            if (cbProductCategories.SelectedIndex == 1)
            {
                var motorOilData = productDb.Products
                .Where(c => c.ProductCategory == "Motor Oil")
                .Select(c => c).ToList();

                for (int i = 0; i < motorOilData.Count; i++)
                {
                    if (buttonString == $"{motorOilData[i].ProductName} {motorOilData[i].ProductDescription}\n" +
                        $"Price: {motorOilData[i].UnitPrice:C}")
                    {
                        lbCart.Items.Add(new CartItem { Name = $"{motorOilData[i].ProductName} " +
                            $"{motorOilData[i].ProductDescription} Price: {motorOilData[i].UnitPrice:C}", 
                            Value = motorOilData[i].UnitPrice });

                        subtotal += motorOilData[i].UnitPrice;
                        UpdatePrice();
                    }
                }
            }

            //adds spark plug product to cart per button click
            if (cbProductCategories.SelectedIndex == 2)
            {
                var sparkPlugsData = productDb.Products
                .Where(c => c.ProductCategory == "Spark Plugs")
                .Select(c => c).ToList();

                for (int i = 0; i < sparkPlugsData.Count; i++)
                {
                    if(buttonString == $"{sparkPlugsData[i].ProductName} {sparkPlugsData[i].ProductDescription}\n" +
                        $"Price: {sparkPlugsData[i].UnitPrice:C}")
                    {
                        lbCart.Items.Add(new CartItem { Name = $"{sparkPlugsData[i].ProductName} " +
                            $"{sparkPlugsData[i].ProductDescription} Price: {sparkPlugsData[i].UnitPrice:C}", 
                            Value = sparkPlugsData[i].UnitPrice });

                        subtotal += sparkPlugsData[i].UnitPrice;
                        UpdatePrice();
                    }
                }
            }

            //adds tire product to cart per button click
            if (cbProductCategories.SelectedIndex == 3)
            {
                var tireData = productDb.Products
                .Where(c => c.ProductCategory == "Tires")
                .Select(c => c).ToList();

                for (int i = 0; i < tireData.Count; i++)
                {
                    if(buttonString == $"{tireData[i].ProductName} {tireData[i].ProductDescription}\n" +
                        $"Price: {tireData[i].UnitPrice:C}")
                    {
                        lbCart.Items.Add(new CartItem { Name = $"{tireData[i].ProductName} " +
                            $"{tireData[i].ProductDescription} Price: {tireData[i].UnitPrice:C}", 
                            Value = tireData[i].UnitPrice });

                        subtotal += tireData[i].UnitPrice;
                        UpdatePrice();
                    }
                }
            }

            //adds windshield wiper product to cart per button click
            if (cbProductCategories.SelectedIndex == 4)
            {
                var windshieldWiperData = productDb.Products
                .Where(c => c.ProductCategory == "Windshield Wipers")
                .Select(c => c).ToList();

                for (int i = 0; i < windshieldWiperData.Count; i++)
                {
                    if (buttonString == $"{windshieldWiperData[i].ProductName} {windshieldWiperData[i].ProductDescription}\n" +
                        $"Price: {windshieldWiperData[i].UnitPrice:C}")
                    {
                        lbCart.Items.Add(new CartItem { Name = $"{windshieldWiperData[i].ProductName} " +
                            $"{windshieldWiperData[i].ProductDescription} Price: {windshieldWiperData[i].UnitPrice:C}", 
                            Value = windshieldWiperData[i].UnitPrice });

                        subtotal += windshieldWiperData[i].UnitPrice;
                        UpdatePrice();
                    }
                }
            }
        }

        //Updates price and resets labels
        private void UpdatePrice()
        {
            lblSubtotal.Text = $"Subtotal: {subtotal:C}";

            double taxAmount = subtotal * 0.085;

            lblTaxAmount.Text = $"Tax (8.5%): {taxAmount:C}";
            double totalAmountDue = subtotal + taxAmount;
            lblTotalDue.Text = $"Total Payment Due: {totalAmountDue:C}";
            order.TotalDue = totalAmountDue;
            if(!order.CouponApplied)
            {
                lblCouponApplied.Visible = false;
            }
        }

        //adds categories to the category list by distinct name
        public void PointOfSaleForm_Load(object sender, EventArgs e)
        {
            var categoryData = productDb.Products
                    .Select(x => x.ProductCategory)
                    .Distinct().ToList();

            for (int i = 0; i < categoryData.Count; i++)
            {
                cbProductCategories.Items.Add(categoryData[i]);
            }
            order.PaymentInProgress = false;
        }

        //Clears all items in cart when button is clicked
        private void btnClearCheckout_Click(object sender, EventArgs e)
        {
            CartClear();
        }

        //Deletes individual items in cart when clicked
        private void lbCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (order.PaymentInProgress)
            {
                MessageBox.Show("Cart editing not available.\nPlease finish your payment\nor contact a manager for help.");
            }
            else
            {
                //checks if selected index is at least zero to prevent exceptions
                if (lbCart.SelectedIndex > -1)
                {
                    CartItem deletedProduct = (CartItem)lbCart.SelectedItem;

                    double deletedItemPrice = deletedProduct.Value;

                    subtotal -= deletedItemPrice;

                    lbCart.Items.RemoveAt(lbCart.SelectedIndex);

                    UpdatePrice();
                }
            }
        }

        //Clears cart and checks if payment is in progress
        private void CartClear()
        {
            if(!order.PaymentInProgress)
            {
                lbCart.Items.Clear();
                subtotal = 0;
                UpdatePrice();
            }
            else
            {
                MessageBox.Show("Cart editing not available.\nPlease finish your payment\nor contact a manager for help.");
            }
        }

        //Manager Override
        private void btnLoyaltyRewards_Click(object sender, EventArgs e)
        {
            if(order.PaymentInProgress)
            {
                List<Employee> employees = new List<Employee>()
                {
                    new Manager("jmandelmvp", "Josh", "Jm12345", true),
                    new Employee("sdowns131", "Sam", "Sd12345"),
                    new Employee("vbottini456", "Vinny", "Vb45678"),
                    new Manager("egudmasted989", "Evan", "Eg98989", true),
                    new Employee("ogibson010", "Olidaji", "Og01013")
                };
                List<Manager> managers = new List<Manager>()
                {
                    new Manager("jmandelmvp", "Josh", "Jm12345", true),
                    new Manager("egudmasted989", "Evan", "Eg98989", true)
                };

                bool managerFound = false;

                for (int i = 0; i < managers.Count; i++)
                {
                    if (txtManagerOverride.Text == managers[i].ManagerPassword)
                    {
                        lblCouponApplied.Visible = false;
                        order.CouponApplied = false;
                        order.PaymentInProgress = false;
                        CartClear();
                        managerFound = true;
                    }
                }

                txtManagerOverride.Text = String.Empty;
                txtManagerOverride.Focus();

                if (!managerFound)
                {
                    MessageBox.Show("Please enter a valid manager password");
                }
                else
                {
                    MessageBox.Show("Your cart has been cleared\n if there was a payment made you will recieve a refund in 3-5 days.");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int topDistance = 10;
            int leftDistance = 5;
            int buttonCount = 0;
            bool foundItems = false;

            gbProducts.Controls.Clear();

            string searchProduct = txtSearchBox.Text;

            var data = productDb.Products
              .Select(c => c).ToList();

            for (int i = 0; i < data.Count; i++)
            {
                if (searchProduct.Length > 2 && !String.IsNullOrEmpty(searchProduct) && (data[i].ProductName.ToLower().Contains(searchProduct.ToLower()) ||
                    data[i].ProductDescription.ToLower().Contains(searchProduct.ToLower())) || 
                    data[i].ProductCategory.ToLower().Equals(searchProduct.ToLower()))
                {
                    foundItems = true;
                    buttonCount++;
                    Button btn = new Button();
                    gbProducts.Controls.Add(btn);
                    btn.Location = new Point(leftDistance, topDistance);
                    btn.ForeColor = Color.DarkBlue;
                    btn.BackColor = Color.LightCyan;
                    btn.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    btn.Size = new Size(530, 40);
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Click += new EventHandler(SearchAdd);
                    btn.Text = $"{data[i].ProductName} {data[i].ProductDescription}\nPrice: {data[i].UnitPrice:C}";
                    topDistance += 43;
                }
            }

            if(!foundItems && String.IsNullOrEmpty(searchProduct))
            {
                MessageBox.Show($"Please refine your search");
                txtSearchBox.Clear();
            }
            else if(!foundItems)
            {
                MessageBox.Show($"Please broaden your search");
                txtSearchBox.Clear();
            }
        }

        private void SearchAdd(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            //copies the text of the clicked button to a variable
            string buttonString = btn.Text;

            var data = productDb.Products
                .Select(c => c).ToList();

            for (int i = 0; i < data.Count; i++)
            {
                if (buttonString == $"{data[i].ProductName} {data[i].ProductDescription}\n" +
                    $"Price: {data[i].UnitPrice:C}")
                {
                    lbCart.Items.Add(new CartItem
                    {
                        Name = $"{data[i].ProductName} " +
                        $"{data[i].ProductDescription} Price: {data[i].UnitPrice:C}",
                        Value = data[i].UnitPrice
                    });

                    subtotal += data[i].UnitPrice;
                    UpdatePrice();
                }
            }
        }
    }
}
