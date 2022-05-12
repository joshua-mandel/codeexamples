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
    public partial class UpdateProductForm : Form
    {
        AutoZoneDBDataContext productDb = new AutoZoneDBDataContext();

        Product updateProduct = new Product();

        public UpdateProductForm(Product product)
        {
            InitializeComponent();

            updateProduct = product;

            FillTextBoxes();
        }

        private void btnSubmitChanges_Click(object sender, EventArgs e)
        {
            double updatePrice;
            int updateInventory;
            bool updatedProduct = false;

            var data = productDb.Products
                .Select(c => c).ToList();

            for (int i = 0; i < data.Count && !updatedProduct; i++)
            {
                if(updateProduct.ProductDescription == data[i].ProductDescription)
                {
                    if (!String.IsNullOrEmpty(txtProductNameUpdate.Text) && 
                        !String.IsNullOrEmpty(txtProductDescriptionUpdate.Text) &&  
                        int.TryParse(txtInventoryUpdate.Text, out updateInventory) && 
                        double.TryParse(txtProductPriceUpdate.Text, out updatePrice) &&
                        updateInventory > 0 && updatePrice > 0)
                    {
                        updateProduct = data[i];

                        updateProduct.ProductName = txtProductNameUpdate.Text;
                        updateProduct.ProductDescription = txtProductDescriptionUpdate.Text;
                        updateProduct.UnitPrice = updatePrice;
                        updateProduct.Inventory = updateInventory;
                        updatedProduct = true;

                        productDb.SubmitChanges();
                        this.Close();
                    }
                }
            }
            if (!updatedProduct)
            {
                MessageBox.Show("Please enter valid values to update the selected product");
                
                FillTextBoxes();
            }
            
        }

        private void FillTextBoxes()
        {
            txtProductNameUpdate.Text = updateProduct.ProductName;

            txtProductDescriptionUpdate.Text = updateProduct.ProductDescription;

            txtInventoryUpdate.Text = Convert.ToString(updateProduct.Inventory);

            txtProductPriceUpdate.Text = Convert.ToString(updateProduct.UnitPrice);
        }
    }
}
