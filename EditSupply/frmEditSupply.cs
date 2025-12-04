using TravelData.Models;

namespace EditSupply
{
    public partial class frmEditSupply : Form
    {

        private int supplyId; // Store the ID
        public frmEditSupply(dynamic SupplierId)
        {
            InitializeComponent();
            supplyId = SupplierId;
            this.Load += frmEditSupply_Load;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {
                var pkg = db.Suppliers.Find(supplyId);

                if (pkg != null)
                {
                    // pkg.ProductId = txtProductId.Text.ToString();
                    pkg.SupName = txtSupName.Text;
                    db.SaveChanges();

                }
            }

            MessageBox.Show("Supplier updated.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmEditSupply_Load(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {
                var pkg = db.Suppliers.Find(supplyId);
                if (pkg != null)
                {
                    txtSupplyId.ReadOnly = true;
                    txtSupName.Text = pkg.SupName;
                    txtSupplyId.Text = pkg.SupplierId.ToString();
                }
                else
                {
                    MessageBox.Show("Supplier not found.");
                    this.Close();
                }
            }
        }
    }
}
