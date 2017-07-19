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
        private int meetingID;

        public MeetingDashboard(string session)
        {
            InitializeComponent();
            this.session = session;
            headerDisplay();
        }

        private void headerDisplay()
        {
            Club club = new Club();
            welcomeMessage.Text = club.getClubNameDisplay(session) + "'s Meeting Dashboard";
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
            displayAllField();
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

                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = "insert into dbo.meeting values (" + club.getClubIDFromPresident(session) +
                    ",'" + m.getMeetingName() + "','" + m.getMeetingLocation() + "','" + m.getMeetingDescription() +
                    "','" + m.getStartTime() + "','" + m.getEndTime() + "'," + m.getDuration() + ")";
                    
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connect.close();

                // success message
                messageText.ForeColor = System.Drawing.Color.Green;
                messageText.Text = "Create meeting successful. ";

                displayAllField();
                clearField();
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

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            startTimePicker.MinDate = datePicker.Value.Date;
            endTimePicker.MinDate = datePicker.Value.Date;
        }

        private void updateButton_Click(object sender, EventArgs e)
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

                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = "update dbo.meeting set meeting_name = '" + m.getMeetingName()
                    + "', meeting_location = '" + m.getMeetingLocation()
                    + "', meeting_description = '" + m.getMeetingDescription()
                    + "', meeting_starttime = '" + m.getStartTime()
                    + "', meeting_endtime = '" + m.getEndTime()
                    + "', meeting_duration = " + m.getDuration() +
                    "where meeting_id = " + meetingID + " and club_id = " + club.getClubIDFromPresident(session);

                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connect.close();

                // success message
                messageText.ForeColor = System.Drawing.Color.Green;
                messageText.Text = "Update meeting details successful. ";

                displayAllField();
                clearField();
            }
            else
            {
                MessageBox.Show("Your UPDATE action is INVALID because some field is empty or wrong");

                // warning message
                messageText.ForeColor = System.Drawing.Color.Red;
                messageText.Text = "UPDATE action is INVALID \n because some field is empty or wrong ! ";
            }
        }

        private void meetingGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nameTextbox.Text = meetingGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            locationTextbox.Text = meetingGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            descriptionTextbox.Text = meetingGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            datePicker.Text = meetingGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            startTimePicker.Text = meetingGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            endTimePicker.Text = meetingGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

            Meeting m = new Meeting(session);
            m.setName(nameTextbox.Text);
            m.setDescription(descriptionTextbox.Text);
            m.setLocation(locationTextbox.Text);
            m.setStartTime(datePicker.Value, startTimePicker.Value);
            m.setEndTime(datePicker.Value, endTimePicker.Value);
            meetingID = m.getMeetingID();

        }

        private void deleteButton_Click(object sender, EventArgs e)
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

                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = "delete dbo.meeting where meeting_id = " + meetingID + " and club_id = " + club.getClubIDFromPresident(session);

                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connect.close();

                // success message
                messageText.ForeColor = System.Drawing.Color.Green;
                messageText.Text = "Delete meeting details successful. ";

                displayAllField();
                clearField();
            }
            else
            {
                MessageBox.Show("Your Delete action is INVALID because you did not specifiy a meeting details");

                // warning message
                messageText.ForeColor = System.Drawing.Color.Red;
                messageText.Text = "Your Delete action is INVALID because you did not specifiy a meeting details";
            }
        }
    }
}
