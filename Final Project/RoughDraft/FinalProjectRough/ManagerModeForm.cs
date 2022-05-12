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
    public partial class ManagerModeForm : Form
    {
        //Initialize the Database
        AutoZoneDBDataContext productDb = new AutoZoneDBDataContext();

        public ManagerModeForm()
        {
            InitializeComponent();

            //Set the navigation items for the main menu navigation
            string[] navItems = new string[] { "Manager Mode", "Main Menu | Point of Sale"};
            cbMenuNavigation.Items.AddRange(navItems);
            cbMenuNavigation.SelectedItem = navItems[0];

            var categoryData = productDb.Products
                    .Select(x => x.ProductCategory)
                    .Distinct().ToList();

            for (int i = 0; i < categoryData.Count; i++)
            {
                cbProductCategoryAdd.Items.Add(categoryData[i]);
                cbProductCategoryUpdate.Items.Add(categoryData[i]);
            }
        }

        private void cbMenuNavigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //navigates to different forms of the application
            if (cbMenuNavigation.SelectedIndex == 1)
            {
                this.Close();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            

            try
            {
                string productCategory;
                string productName;
                int result;
                double resultTwo;
                int resultThree;
                int productNum = 0;
                double priceAdd;
                int productInventory;
                string productDescription;

                if (!String.IsNullOrEmpty(cbProductCategoryAdd.Text))
                {
                    productCategory = cbProductCategoryAdd.Text;
                }
                else
                {
                    productCategory = null;
                }

                productName = txtProductNameAdd.Text;

                productDescription = txtProductDescriptionAdd.Text;

                if (Int32.TryParse(txtProductNumAdd.Text, out result))
                {
                    productNum = Convert.ToInt32(result);
                }

                if (Double.TryParse(txtProductPriceAdd.Text, out resultTwo))
                {
                    priceAdd = Convert.ToDouble(resultTwo);
                }
                else
                {
                    priceAdd = 0;
                }

                if(Int32.TryParse(txtInventoryAdd.Text, out resultThree))
                {
                    productInventory = Convert.ToInt32(resultThree);
                }
                else
                {
                    productInventory = 0;
                }

                if(productCategory != null && !String.IsNullOrEmpty(productName) && !String.IsNullOrEmpty(productDescription) && productNum >= 100 && priceAdd > 0 && productInventory > 0)
                {
                    Product productInsert = new Product()
                    {
                        ProductName = productName,
                        ProductCategory = productCategory,
                        ProductDescription = productDescription,
                        ProductId = productNum,
                        UnitPrice = priceAdd,
                        Inventory = productInventory
                    };

                    productDb.Products.InsertOnSubmit(productInsert);

                    productDb.SubmitChanges();

                    MessageBox.Show("Your product was added to the database.");

                    ClearAddControls();
                }
                else
                {
                    ClearAddControls();
                    MessageBox.Show("Your product was not added. Please check all values before submitting a new product.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Your product was not added. Please check all values before submitting a new product.");
                ClearAddControls();
            }
        }

        private void ClearAddControls()
        {
            txtProductNameAdd.Clear();
            txtInventoryAdd.Clear();
            txtProductDescriptionAdd.Clear();
            txtProductNumAdd.Clear();
            txtProductPriceAdd.Clear();
            txtInventoryAdd.Clear();
            cbProductCategoryAdd.Items.Clear();
            txtProductNameAdd.Focus();

            //Set the categories in drop down list after clearing

            var categoryData = productDb.Products
                    .Select(x => x.ProductCategory)
                    .Distinct().ToList();

            for (int i = 0; i < categoryData.Count; i++)
            {
                cbProductCategoryAdd.Items.Add(categoryData[i]);
            }
        }

        private void cbProductCategoryUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbProductCategoryUpdate.SelectedIndex == 0)
            {
                cbProductNameUpdate.Items.Clear();

                var cleaningData = productDb.Products
               .Where(c => c.ProductCategory == "Cleaning Products")
               .Select(c => c).Distinct().ToList();

                for (int i = 0; i < cleaningData.Count; i++)
                {
                    cbProductNameUpdate.Items.Add($"{cleaningData[i].ProductName} {cleaningData[i].ProductDescription}");
                }
            }

            if(cbProductCategoryUpdate.SelectedIndex == 1)
            {
                cbProductNameUpdate.Items.Clear();

                var motorOilData = productDb.Products
                .Where(c => c.ProductCategory == "Motor Oil")
                .Select(c => c).Distinct().ToList();

                for (int i = 0; i < motorOilData.Count; i++)
                {
                    cbProductNameUpdate.Items.Add($"{motorOilData[i].ProductName} {motorOilData[i].ProductDescription}");
                }
            }

            if(cbProductCategoryUpdate.SelectedIndex == 2)
            {
                cbProductNameUpdate.Items.Clear();

                var sparkPlugsData = productDb.Products
                .Where(c => c.ProductCategory == "Spark Plugs")
                .Select(c => c).Distinct().ToList();

                for (int i = 0; i < sparkPlugsData.Count; i++)
                {
                    cbProductNameUpdate.Items.Add($"{sparkPlugsData[i].ProductName} {sparkPlugsData[i].ProductDescription}");
                }
            }

            if(cbProductCategoryUpdate.SelectedIndex == 3)
            {
                cbProductNameUpdate.Items.Clear();

                var tireData = productDb.Products
                .Where(c => c.ProductCategory == "Tires")
                .Select(c => c).Distinct().ToList();

                for (int i = 0; i < tireData.Count; i++)
                {
                    cbProductNameUpdate.Items.Add($"{tireData[i].ProductName} {tireData[i].ProductDescription}");
                }
            }

            if(cbProductCategoryUpdate.SelectedIndex == 4)
            {
                cbProductNameUpdate.Items.Clear();

                var windshieldWiperData = productDb.Products
                .Where(c => c.ProductCategory == "Windshield Wipers")
                .Select(c => c).ToList();

                for (int i = 0; i < windshieldWiperData.Count; i++)
                {
                    cbProductNameUpdate.Items.Add($"{windshieldWiperData[i].ProductName} {windshieldWiperData[i].ProductDescription}");
                }
            }
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
             var data = productDb.Products
                .Select(c => c).ToList();

            bool foundItem = false;

            for (int i = 0; i < data.Count; i++)
            {
                if(cbProductNameUpdate.SelectedItem != null && cbProductNameUpdate.SelectedItem.ToString() == $"{data[i].ProductName} {data[i].ProductDescription}")
                {
                    UpdateProductForm updateProductForm = new UpdateProductForm(data[i]);
                    updateProductForm.ShowDialog();
                    this.Close();
                    foundItem = true;
                }
            }
            if (!foundItem)
            {
                MessageBox.Show("Please select an item");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var data = productDb.Products
                .Select(c => c).ToList();

            bool foundItem = false;

            for (int i = 0; i < data.Count; i++)
            {
                if (cbProductNameUpdate.SelectedItem != null && cbProductNameUpdate.SelectedItem.ToString() == $"{data[i].ProductName} {data[i].ProductDescription}")
                {
                    AreYouSureForm areYouSure = new AreYouSureForm(data[i]);
                    foundItem = true;
                    areYouSure.ShowDialog();
                    cbProductNameUpdate.Items.Clear();
                }

            }
            if(!foundItem)
            {
                MessageBox.Show("Please select an item");
            }
        }
    }
}
