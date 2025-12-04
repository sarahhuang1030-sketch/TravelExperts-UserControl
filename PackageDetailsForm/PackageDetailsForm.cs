using System.IO.Packaging;
using System.Xml.Linq;
using TravelData.Models;

namespace PackageView
{
    public partial class PackageDetailsForm : Form
    {
        public PackageDetailsForm(int packageId)
        {
            InitializeComponent();

            using (var db = new TravelexpertsContext())
        {
                var pkg = db.Packages.Find(packageId);
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
