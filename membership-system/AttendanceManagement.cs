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
    public partial class AttendanceManagement : Form
    {
        private string session;
        private string query; 

        public AttendanceManagement(string session)
        {
            this.session = session;
            
            InitializeComponent();
            loadMeetingCombobox();
            headerDisplay();
        }

        private void headerDisplay()
        {
            Club club = new Club();
            welcomeMessage.Text = club.getClubNameDisplay(session) + "'s Attendance Dashboard";
        }

        public void loadMeetingCombobox()
        {
            Club club = new Club();
            SqlConn sqlConn = new SqlConn();
            SqlDataAdapter sda = new SqlDataAdapter("select meeting_name from dbo.meeting where club_id = " + club.getClubIDFromPresident(session), sqlConn.sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            meetingCombobox.Items.Clear();
            meetingCombobox1.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                meetingCombobox.Items.Add(item[0].ToString());
                meetingCombobox1.Items.Add(item[0].ToString());
            }
        }

        private void displayAllField()
        {
            Club club = new Club();
            query = "select student_name, student_intakecode, student_handphone, student_gender from student s inner join register as r on s.student_id = r.student_id inner join club as c on r.club_id = c.club_id inner join meeting as m on c.club_id = m.club_id where m.club_id = " +
                club.getClubIDFromPresident(session) + "and m.meeting_name = '" + meetingCombobox.Text + "'";
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
                attendanceList.DataSource = datatable;//datagridtable get data from the data table
                connect.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

            if (attendanceList.Columns.Contains("CheckBox"))
            {
                attendanceList.Columns.Remove("CheckBox");
            }

            chk.HeaderText = "Attendance";
            chk.Name = "CheckBox";
            chk.FalseValue = false;
            attendanceList.Columns.Add(chk);

            foreach (DataGridViewColumn dc in attendanceList.Columns)
            {
                dc.ReadOnly = (dc.Index.Equals(4)) ? false : true;
            }

            foreach(DataGridViewRow row in attendanceList.Rows)
            {
                row.Cells[4].Value = false;
            }

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            for (int i = attendanceList.Rows.Count -1 ; i >= 0; i--)
            {
                bool attend = (bool)attendanceList.Rows[i].Cells[4].Value;

                if (attend)
                {
                    Member m = new Member();
                    Meeting mt = new Meeting(session);
                    mt.setName(meetingCombobox.Text);
                    President p = new President();

                    string name = attendanceList.Rows[i].Cells[0].Value.ToString();

                    SqlConn connect = new SqlConn();
                    connect.open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connect.sqlConnection;
                    command.CommandText = "insert into dbo.Attendance values (" + m.getMemberID(name) + ","
                        + mt.getMeetingID() + "," + p.getPresidentID(session) + ",'1')";

                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connect.close();                  
                }
            }

            MessageBox.Show("Your attendance had updated! ");
            navigation();


        }

        private void navigation()
        {
            attendanceList.DataSource = null;
            meetingCombobox1.Text = meetingCombobox.Text;
            searchAttendanceOnDisplay();
            attendanceTab.SelectedTab = viewAttendanceTab;
        }

        private void searchButton1_Click(object sender, EventArgs e)
        {
            searchAttendanceOnDisplay();
        }

        private void searchAttendanceOnDisplay()
        {
            Meeting m = new Meeting(session);
            m.setName(meetingCombobox1.Text);
            query = "select distinct student_name, student_intakecode, student_handphone, student_gender from student as s inner join attendance as a on s.student_id = a.student_id inner join meeting as m on a.meeting_id = m.meeting_id where a.meeting_id = " + 
                m.getMeetingID();

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
                attendanceList1.DataSource = datatable;//datagridtable get data from the data table
                connect.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            displayAllField();
        }
    }
}
