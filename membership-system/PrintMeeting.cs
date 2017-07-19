using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Drawing2D;

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
            beautifyDescription();
        }

        private void beautifyDescription()
        {
            descriptionLabel.MaximumSize = new Size(250, 0);
        }

        public void loadClubCombobox()
        {
            Club club = new Club();
            SqlConn sqlConn = new SqlConn();
            SqlDataAdapter sda = new SqlDataAdapter("select meeting_name from dbo.meeting where club_id = " + club.getClubIDFromPresident(session), sqlConn.sqlConnection);
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
            if (!string.IsNullOrWhiteSpace(meetingNameComboBox.Text))
            {
                loadDataIntoDetails();
                searchAttendanceOnDisplay();
            }
            else
            {
                MessageBox.Show("Please select meeting name to search.");
            }                        
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

        private void searchAttendanceOnDisplay()
        {
            Club club = new Club();

            query = "select distinct student_name, student_intakecode, student_email, student_handphone, student_gender from student as s inner join register as r on s.student_id = r.student_id inner join club as c on r.club_id = c.club_id inner join meeting as m on c.club_id = m.club_id right join attendance as a on a.student_id = s.student_id where m.club_id = " +
                club.getClubIDFromPresident(session) + "and m.meeting_name = '" + meetingNameComboBox.Text + "'";

            displayAttendance(query);
        }

        private void displayAttendance(string query)
        {
            try
            {
                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = query;

                SqlDataAdapter storage = new SqlDataAdapter(command);//store the data get from database
                DataTable datatable = new DataTable();//put data into this table
                storage.Fill(datatable);
                meetingGridView.DataSource = datatable;//datagridtable get data from the data table
                connect.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }



        private void printButton_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.ShowDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.printDocument1_PrintPage;
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            Graphics g = this.CreateGraphics();
            Bitmap bmp = new Bitmap(this.panel1.Width, this.panel1.Height, g);
            this.panel1.DrawToBitmap(bmp, new Rectangle(0, 0, this.panel1.Width, this.panel1.Height));

            e.Graphics.TranslateTransform((float)this.panel1.Width / 2, (float)this.panel1.Height / 2);
            //rotate
            e.Graphics.RotateTransform(90);
            //move image back
            e.Graphics.TranslateTransform(-(float)this.panel1.Width / 3, -(float)this.panel1.Height / 2);
            e.Graphics.DrawImage((Image)bmp, x, y);
        }
    }
}
