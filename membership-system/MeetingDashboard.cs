using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace membership_system
{
    public partial class MeetingDashboard : Form
    {

        private string query;
        private string session;
        private Boolean insertMeetingData;

        public MeetingDashboard(string session)
        {
            InitializeComponent();
            this.session = session;
        }

        private void MeetingDashboard_Load(object sender, EventArgs e)
        {
            displayAllField();
            disablePastDates();
        }

        private void displayAllField()
        {
            Club club = new Club();
            query = "select meeting_name, meeting_location, meeting_description, meeting_starttime, meeting_endtime, meeting_duration from meeting where club_id = " + club.getClubIDFromPresident(session);
            displayData(query);
        }

        // display data in datagridview base on query
        private void displayData(string query)
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            Club club = new Club();
            query = "select meeting_name, meeting_location, meeting_description, meeting_starttime, meeting_endtime, meeting_duration from meeting where club_id = " + club.getClubIDFromPresident(session) +
                " and meeting_name like '%" + searchTextbox.Text + "%'";
            displayData(query);
            clearField();
        }

        private void clearField()
        {
            nameTextbox.Text = "";
            locationTextbox.Text = "";
            datePicker.Text = DateTime.Now.ToString();
            startTimePicker.Text = DateTime.Now.ToString();
            endTimePicker.Text = DateTime.Now.ToString();
            durationLabel.Text = "0 day 0 hour 0 minute 0 second";
            descriptionTextbox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearField();
            searchTextbox.Text = "";
        }

        private void validateEmptyField()
        {
            if (string.IsNullOrWhiteSpace(nameTextbox.Text) || string.IsNullOrWhiteSpace(locationTextbox.Text) || 
                string.IsNullOrWhiteSpace(descriptionTextbox.Text))
            {
                insertMeetingData = false;
            }
            else
            {
                insertMeetingData = true;
            }
        }

        private void disablePastDates()
        {
            datePicker.MinDate = DateTime.Now;
            startTimePicker.MinDate = DateTime.Now;
            endTimePicker.MinDate = DateTime.Now;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            validateEmptyField();
            if (insertMeetingData)
            {
                Meeting m = new Meeting(session);
                m.setName(nameTextbox.Text);
                m.setLocation(locationTextbox.Text);
                m.setStartTime(datePicker.Value, startTimePicker.Value);
                m.setEndTime(datePicker.Value, endTimePicker.Value);
                m.setDescription(descriptionTextbox.Text);
                m.calculateDuration();

                Club club = new Club();

                messageText.Text = m.getStartTime().ToString() + " " + m.getEndTime().ToString() + " " + m.getDuration().ToString();

                /*SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = "insert into dbo.meeting values (" + club.getClubIDFromPresident(session) +
                    ",'" + m.getMeetingName() + "','" + m.getMeetingDescription() +
                    "','" + m.getStartTime().ToString() + "','" + m.getEndTime().ToString() + "','" + m.getDuration() + "')";
                    
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connect.close();*/
            }
            else
            {
                MessageBox.Show("Your action is INVALID because some field is empty or wrong");

                // warning message
                messageText.ForeColor = System.Drawing.Color.Red;
                messageText.Text = "INSERT action is INVALID \n because some field is empty or wrong ! ";
            }
        }

        private void populateDuration()
        {
            Meeting m = new Meeting(session);
            m.setStartTime(datePicker.Value, startTimePicker.Value);
            m.setEndTime(datePicker.Value, endTimePicker.Value);
            durationLabel.Text = m.getDurationText();
        }


        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {
            populateDuration();
        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endTimePicker.MinDate = startTimePicker.Value;

        }
    }
}
