using System.Globalization;
using System.IO.Packaging;
using System.Linq;
using TravelData.Models;

namespace EditAgent
{
    public partial class frmEditAgent : Form
    {
        private int agentId;
        public frmEditAgent(int AgentID)
        {
            InitializeComponent();
            agentId = AgentID;
            this.Load += frmEditAgent_Load;
        }


        private void frmEditAgent_Load(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {

                var agent = db.Agents.Find(agentId);
                if (agent != null)
                {
                    var agencies = db.Agencies
                                     .Select(a => new { a.AgencyId, a.AgncyCity })
                                     .ToList();

                    lstAgency.DataSource = agencies;
                    lstAgency.DisplayMember = "AgncyCity";
                    lstAgency.ValueMember = "AgencyId";

                    txtFirstName.Text = agent.AgtFirstName;
                    txtLastName.Text = agent.AgtLastName;
                    txtPhone.Text = agent.AgtBusPhone;
                    txtEmail.Text = agent.AgtEmail;
                    txtPosition.Text = agent.AgtPosition;

                    // ✅ Add this line to define validAgencyIds
                    var validAgencyIds = agencies.Select(a => a.AgencyId).ToList();



                    // Defensive check
                    if (agent.AgencyId.HasValue && validAgencyIds.Contains(agent.AgencyId.Value))
                    {
                        lstAgency.SelectedValue = agent.AgencyId.Value;
                    }
                    else
                    {
                        MessageBox.Show($"Agent is assigned to unknown AgencyId ({agent.AgencyId}).");
                        lstAgency.SelectedIndex = -1;
                    }

                    
                }

            }
        }

        private void btnEditAgent_Click(object sender, EventArgs e)
        {
            using (var db = new TravelexpertsContext())
            {
                var agent = db.Agents.Find(agentId); // packageId should be stored in the form

                if (agent != null)
                {
                    agent.AgtFirstName = txtFirstName.Text;
                    agent.AgtLastName = txtLastName.Text;
                    agent.AgtBusPhone = txtPhone.Text;
                    agent.AgtPosition = txtPosition.Text;
                    agent.AgtEmail = txtEmail.Text;
                    // 👇 Update agency based on selected item in the ListBox
                    if (lstAgency.SelectedValue != null)
                    {
                        agent.AgencyId = (int)lstAgency.SelectedValue;
                    }
                    db.SaveChanges();
                }
            }

            MessageBox.Show("Agent updated.");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
