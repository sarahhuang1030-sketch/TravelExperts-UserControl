using TravelData.Models;

namespace AddAgency
{
    public partial class frmAddAgency : Form
    {
        public frmAddAgency()
        {
            InitializeComponent();
        }

        private void btnAddAgency_Click_1(object sender, EventArgs e)
        {
            using (TravelexpertsContext db = new TravelexpertsContext())
            {
                //  int agencyId = lstAgency.SelectedValue != null ? (int)lstAgency.SelectedValue : 0;
                var newAgency = new Agency
                {
                    // AgentId = agencyId,
                   // AgencyId = agencyId,
                    AgncyAddress = txtAddress.Text,
                    AgncyCity = txtCity.Text,
                    AgncyProv = txtProv.Text,
                    AgncyPostal = txtPostalCode.Text,
                    AgncyPhone = txtPhone.Text,
                    AgncyCountry = txtCountry.Text,
                    AgncyFax = txtFax.Text,
                    // AgencyId = agencyId

                };

                db.Agencies.Add(newAgency);
                db.SaveChanges();

            }

            MessageBox.Show("Agency added successfully.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

     
    }
}
