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
    public partial class EditMeeting : Form
    {
        public EditMeeting()
        {
            InitializeComponent();
            showView();
        }

        private void showEdit()
        {
            editPanel.Visible = true;
            viewPanel.Visible = false;
        }

        private void showView()
        {
            editPanel.Visible = false;
            viewPanel.Visible = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            showEdit();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            showView();
        }
    }
}
