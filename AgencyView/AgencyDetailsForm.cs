using TravelData.Models;

namespace AgencyView
{
    public partial class Form1 : Form
    {
        private int AgencyId;
        public Form1(int agencyId)
        {
            InitializeComponent();
            AgencyId = agencyId;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {
                var pkg = db.Agencies.Find(AgencyId);
                if (pkg != null)
                {
                    // lblAgentID.Text = pkg.AgentId.ToString();
                    lblAddress.Text = pkg.AgncyAddress;
                    lblCountry.Text = pkg.AgncyCountry;
                    lblCity.Text = pkg.AgncyCity;
                    lblProv.Text = pkg.AgncyFax;
                    lblPhone.Text = pkg.AgncyPhone;
                    lblPostalCode.Text = pkg.AgncyPostal;
                }
                else
                {
                    MessageBox.Show("Agent not found.");
                    this.Close();
                }
            }
        }
    }
}
