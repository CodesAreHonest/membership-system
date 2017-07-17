using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace membership_system
{
    public partial class PrintMeeting : Form
    {
        private string session;
        public PrintMeeting(string session)
        {
            InitializeComponent();
            this.session = session;
            loadClubCombobox();

        }

        public void loadClubCombobox()
        {
            Club club = new Club();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\gitRepo\membership-system\membership-system-db.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select meeting_name from dbo.meeting where club_id = " + club.getClubIDFromPresident(session), conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            meetingNameComboBox.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                MessageBox.Show(item[0].ToString());
                meetingNameComboBox.Items.Add(item[0].ToString());
            }
        }
    }
}
