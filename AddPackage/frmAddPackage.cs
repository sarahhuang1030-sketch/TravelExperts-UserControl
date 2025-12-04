using TravelData.Models;

namespace AddPackage
{
    public partial class frmAddPackage : Form
    {
        public frmAddPackage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {
                var newPackage = new Package
                {
                    PkgName = txtPkgName.Text,
                    PkgStartDate = dtpStartDate.Value,
                    PkgEndDate = dtpEndDate.Value,
                    PkgBasePrice = decimal.Parse(txtPrice.Text),
                    PkgAgencyCommission = decimal.Parse(txtAgentComission.Text)
                };

                db.Packages.Add(newPackage);
                db.SaveChanges();
            }

            MessageBox.Show("Package added successfully.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
