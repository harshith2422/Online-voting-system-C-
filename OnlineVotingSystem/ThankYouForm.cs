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
    public partial class ThankYouForm : Form
    {
        

        private void ThankYouForm_Load1(object sender, EventArgs e)
        {

        }
        
            public string UserName { get; set; }
            public string UserEmail { get; set; }
            public string UserAddress { get; set; }
            public string PartyVoted { get; set; }

            public ThankYouForm()
            {
                InitializeComponent();
            }

            private void ThankYouForm_Load(object sender, EventArgs e)
            {
                l1.Text = "Name: " + UserName;
                l2.Text = "Email: " + UserEmail;
                l3.Text = "Address: " + UserAddress;
                l4.Text = "Voted For: " + PartyVoted;
                

        }

        private void l4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
