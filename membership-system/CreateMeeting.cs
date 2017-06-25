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
    public partial class CreateMeeting : Form
    {
        public CreateMeeting()
        {
            InitializeComponent();
            showCreate();
        }

        private void showEdit()
        {
            viewPanel.Visible = true;
            createPanel.Visible = false;
        }

        private void showCreate()
        {
            createPanel.Visible = true;
            viewPanel.Visible = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            showEdit();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            showCreate();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CreateMeeting_Load(object sender, EventArgs e)
        {

        }
    }
}
