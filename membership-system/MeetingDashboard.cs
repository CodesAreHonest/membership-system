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

        public MeetingDashboard(string session)
        {
            InitializeComponent();
            this.session = session;
        }

        private void MeetingDashboard_Load(object sender, EventArgs e)
        {
            displayAllField();
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
            startDatePicker.Text = DateTime.Now.ToString();
            startTimePicker.Text = DateTime.Now.ToString();
            endDatePicker.Text = DateTime.Now.ToString();
            endTimePicker.Text = DateTime.Now.ToString();
            durationLabel.Text = "0 hour 0 minute 0 second";
            descriptionTextbox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearField();
            searchTextbox.Text = "";
        }
    }
}
