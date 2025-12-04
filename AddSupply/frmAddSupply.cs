using TravelData.Models;

namespace AddSupply
{
    public partial class frmAddSupply : Form
    {
        public frmAddSupply()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {
                var newSupply = new Supplier
                {
                    SupplierId = int.Parse(txtSupId.Text),
                    SupName = txtSupName.Text,
                };

                db.Suppliers.Add(newSupply);
                db.SaveChanges();
            }
            MessageBox.Show("Supply added successfully."); // ✅ Success message
            this.DialogResult = DialogResult.OK;            // ✅ Notify parent
            this.Close();                                   // ✅ Close popup
        }
    }
}
