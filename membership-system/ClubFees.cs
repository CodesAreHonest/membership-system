using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace membership_system
{
    public partial class ClubFees : Form
    {
        private string session;
        Club club = new Club();

        public ClubFees(string session)
        {
            InitializeComponent();
            this.session = session;
            headerDisplay();
        }

        private void headerDisplay()
        {
            welcomeMessage.Text = club.getClubNameDisplay(session) + "'s Club Fees Management";
        }

    }
}
