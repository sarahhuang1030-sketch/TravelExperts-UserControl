using TravelData.Models;

namespace AddProduct
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {
                var newProduct = new Product
                {
                    ProdName = txtProdName.Text,

                };

                db.Products.Add(newProduct);
                db.SaveChanges();
            }
                MessageBox.Show("Product added successfully."); // ✅ Success message
                this.DialogResult = DialogResult.OK;            // ✅ Notify parent
                this.Close();                                   // ✅ Close popup
            
        }
    }
    
}
