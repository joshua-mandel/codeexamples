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
    public partial class AreYouSureForm : Form
    {
        AutoZoneDBDataContext productDb = new AutoZoneDBDataContext();

        Product deleteProduct = new Product();
        public AreYouSureForm(Product product)
        {
            InitializeComponent();

            deleteProduct = product;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool deletedProduct = false;

            var data = productDb.Products
               .Select(c => c).ToList();

            for (int i = 0; i < data.Count && !deletedProduct; i++)
            { 
                if(data[i].ProductDescription == deleteProduct.ProductDescription)
                {
                    deleteProduct = data[i];
                    productDb.Products.DeleteOnSubmit(deleteProduct);
                    productDb.SubmitChanges();

                    deletedProduct = true;

                    MessageBox.Show($"The {deleteProduct.ProductName} Product has been deleted");
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
