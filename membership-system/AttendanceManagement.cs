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
    public partial class AttendanceManagement : Form
    {
        private string session; 

        public AttendanceManagement(string session)
        {
            this.session = session;
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
