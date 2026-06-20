using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineVotingSystem
{
    public partial class VoteForm : Form
    {
        public VoteForm()
        {
            InitializeComponent();
        }

        private void VoteForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            if (cmbParties.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a party.");
                return;
            }

            ThankYouForm thankYouForm = new ThankYouForm();

            thankYouForm.UserName = UserData.RegisteredUsername;
            thankYouForm.UserEmail = UserData.RegisteredEmail;
            thankYouForm.UserAddress = UserData.RegisteredAddress;
            thankYouForm.PartyVoted = cmbParties.SelectedItem.ToString();

            //ThankYouForm thankYouForm = new ThankYouForm();


            thankYouForm.Show();
            this.Hide();
            //thankYou.Show();
            //this.Hide();
        }
    }
}
