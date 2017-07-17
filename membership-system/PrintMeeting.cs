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
        private string query;

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
                meetingNameComboBox.Items.Add(item[0].ToString());
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            loadDataIntoDetails();
                        
        }

        private void loadDataIntoDetails()
        {
            Meeting m = new Meeting(session);
            Club club = new Club();
            m.setName(meetingNameComboBox.Text);
            try
            {
                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = "select * from dbo.Meeting where meeting_name = '" + m.getMeetingName() + "' and club_id = " + club.getClubIDFromPresident(session);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    m.setName(reader.GetString(2));
                    m.setLocation(reader.GetString(3));
                    m.setDescription(reader.GetString(4));
                    m.setStartDate(reader.GetDateTime(5));
                    m.setEndDate(reader.GetDateTime(6));


                    // automate value on textfield
                    nameLabel.Text = m.getMeetingName();
                    locationLabel.Text = m.getMeetingLocation();
                    startTimeLabel.Text = m.getStartDate().ToString();
                    endTimeLabel.Text = m.getEndDate().ToString();
                    descriptionLabel.Text = m.getMeetingDescription().ToString();
                    durationLabel.Text = m.getReportDurationText().ToString();

                    // close connection
                    connect.close();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex);
            }
        }

        
    }
}
