using TravelData.Models;

namespace AgentView
{
    public partial class AgentDetailsForm : Form
    {
        private int AgentId;
        public AgentDetailsForm(int agentId)
        {
            InitializeComponent();
            AgentId = agentId;
            this.Load += AgentDetailsForm_Load;
        }

        private void AgentDetailsForm_Load(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {
                var pkg = db.Agents.Find(AgentId);
                if (pkg != null)
                {
                    lblAgentID.Text = pkg.AgentId.ToString();
                    lblFirstName.Text = pkg.AgtFirstName;
                    lblMdInitial.Text = pkg.AgtMiddleInitial;
                    lblLastName.Text = pkg.AgtLastName;
                    lblPosition.Text = pkg.AgtPosition;
                    lblEmail.Text = pkg.AgtEmail;
                    lblPhone.Text = pkg.AgtBusPhone;
                    //    lblAgency.Text = pkg.AgencyId.ToString();
                    var agency = db.Agencies.FirstOrDefault(a => a.AgencyId == pkg.AgencyId);
                    lblAgency.Text = agency != null ? agency.AgncyCity : $"Unknown (AgencyId: {pkg.AgencyId})";

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
