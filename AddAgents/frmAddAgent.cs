using TravelData.Models;
namespace AddAgents
{
    public partial class frmAddAgent : Form
    {
        public frmAddAgent()
        {
            InitializeComponent();
        }

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            using (TravelexpertsContext db = new TravelexpertsContext())
            {
                int agencyId = lstAgency.SelectedValue != null ? (int)lstAgency.SelectedValue : 0;
                var newAgent = new Agent
                {
                    // AgentId = agencyId,
                    // AgencyId = agencyId,
                    AgtFirstName = txtFirstName.Text,
                    AgtLastName = txtLastName.Text,
                    AgtBusPhone = txtPhone.Text,
                    AgtEmail = txtEmail.Text,
                    AgtPosition = txtPosition.Text,
                    AgtMiddleInitial = "", // or null if allowed

                    AgencyId = agencyId

                };

                db.Agents.Add(newAgent);
                db.SaveChanges();

            }


            MessageBox.Show("Agent added successfully.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmAddAgent_Load(object sender, EventArgs e)
        {
          
            var agencies = new[]
            {
        new { AgencyId = 1, AgncyCity = "Calgary" },
        new { AgencyId = 2, AgncyCity = "Okotoks" }
    };

            lstAgency.DataSource = agencies;
            lstAgency.DisplayMember = "AgncyCity";
            lstAgency.ValueMember = "AgencyId";
        

    }
}
}
