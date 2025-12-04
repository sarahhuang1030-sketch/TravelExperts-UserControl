using Microsoft.Extensions.Logging;
using TravelData.Models;
namespace EditAgency
{
    public partial class frmEditAgency : Form
    {
        private int agencyId;
        public frmEditAgency(int AgencyID)
        {
            InitializeComponent();
          
            agencyId = AgencyID;
            this.Load += frmEditAgency_Load;
        }

        private void frmEditAgency_Load(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {

                var agency = db.Agencies.Find(agencyId);
                if (agency != null)
                {

                    txtAddress.Text = agency.AgncyAddress;
                    txtCity.Text = agency.AgncyCity;
                    txtProv.Text = agency.AgncyProv;
                    txtPostalCode.Text = agency.AgncyPostal;
                    txtPhone.Text = agency.AgncyPhone;
                    txtFax.Text = agency.AgncyFax;
                    txtCountry.Text = agency.AgncyCountry;

                }
                else
                {
                    MessageBox.Show("Package not found.");
                    this.Close();
                }
            }
        }

        private void btnEditAgency_Click(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {
                var agency = db.Agencies.Find(agencyId); // packageId should be stored in the form

                if (agency != null)
                {
                    agency.AgncyAddress = txtAddress.Text;
                    agency.AgncyCity = txtCity.Text;
                    agency.AgncyPhone = txtPhone.Text;
                    agency.AgncyProv = txtProv.Text;
                    agency.AgncyPostal = txtPostalCode.Text;
                    agency.AgncyFax = txtFax.Text;
                    agency.AgncyCountry = txtCountry.Text;
                    db.SaveChanges();
                }
            }

            MessageBox.Show("Agent updated.");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
