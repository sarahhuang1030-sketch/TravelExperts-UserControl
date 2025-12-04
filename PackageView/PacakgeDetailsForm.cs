using TravelData.Models;

namespace PackageView
{
    public partial class PacakgeDetailsForm : Form
    {
        private int PackageId;

        public PacakgeDetailsForm(int packageId)
        {
            InitializeComponent();
            PackageId = packageId;
            this.Load += PackageDetailsForm_Load;
        }

        private void PackageDetailsForm_Load(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {
                var pkg = db.Packages.Find(PackageId);
                if (pkg != null)
                {
                    lblPackageID.Text = pkg.PackageId.ToString();
                    lblName.Text = pkg.PkgName;
                    lblStartDate.Text = pkg.PkgStartDate?.ToString("yyyy-MM-dd") ?? "N/A";
                    lblEndDate.Text = pkg.PkgEndDate?.ToString("yyyy-MM-dd") ?? "N/A";
                    lblPrice.Text = pkg.PkgBasePrice.ToString("C");
                    lblDescription.Text = pkg.PkgDesc;
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

