using System.IO.Packaging;
using System.Globalization;
using TravelData.Models;

namespace EditPackage
{
    public partial class EditPackageForm : Form
    {
        private int PackageId;
        public EditPackageForm(int packageId)
        {
            InitializeComponent();
            PackageId = packageId;
            this.Load += EditPackageForm_Load;
        }

        private void EditPackageForm_Load(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {
                var pkg = db.Packages.Find(PackageId);
                if (pkg != null)
                {

                    txtPacakge.Text = pkg.PkgName;
                    dtpStartDate.Text = pkg.PkgStartDate?.ToString("yyyy-MM-dd") ?? "N/A";
                    dtpEndDate.Text = pkg.PkgEndDate?.ToString("yyyy-MM-dd") ?? "N/A";
                    txtPrice.Text = pkg.PkgBasePrice.ToString("C");
                    txtDescription.Text = pkg.PkgDesc ?? string.Empty;
                    txtAgentComission.Text = pkg.PkgAgencyCommission.HasValue
                        ? pkg.PkgAgencyCommission.Value.ToString("C")
                        : "N/A";
                }
                else
                {
                    MessageBox.Show("Package not found.");
                    this.Close();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {
                var pkg = db.Packages.Find(PackageId); // packageId should be stored in the form

                if (pkg != null)
                {
                    pkg.PkgName = txtPacakge.Text;
                    pkg.PkgStartDate = dtpStartDate.Value;
                    pkg.PkgEndDate = dtpEndDate.Value;
                    // pkg.PkgBasePrice = decimal.Parse(txtPrice.Text);
                    pkg.PkgBasePrice = decimal.Parse(txtPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);

                    pkg.PkgDesc = txtDescription.Text;
                    // pkg.PkgAgencyCommission = decimal.Parse(txtAgentComission.Text);
                    pkg.PkgAgencyCommission = decimal.Parse(txtAgentComission.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                    db.SaveChanges();
                }
            }

            MessageBox.Show("Package updated.");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
