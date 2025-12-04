using System.Globalization;
using System.IO.Packaging;
using TravelData.Models;

namespace EditProducts
{
    public partial class frmEditProducts : Form
    {
        private int productId; // Store the ID
        public frmEditProducts(dynamic ProductId)
        {
            InitializeComponent();

            productId = ProductId;
            this.Load += frmEditProducts_Load;

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {
                var pkg = db.Products.Find(productId); // packageId should be stored in the form

                if (pkg != null)
                {
                   // pkg.ProductId = txtProductId.Text.ToString();
                    pkg.ProdName = txtProdName.Text;
                    db.SaveChanges();

                }
            }

            MessageBox.Show("Package updated.");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void frmEditProducts_Load(object sender, EventArgs e)
        {
           
            using (var db = new TravelexpertsContext())
            {
                var pkg = db.Products.Find(productId);
                if (pkg != null)
                {
                    txtProductId.ReadOnly = true;
                    txtProdName.Text = pkg.ProdName;
                    txtProductId.Text = pkg.ProductId.ToString();
                }
                else
                {
                    MessageBox.Show("Package not found.");
                    this.Close();
                }
            }
        }
    
    }
}
