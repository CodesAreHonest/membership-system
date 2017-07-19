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
    public partial class MemberDashboard : Form
    {

        private bool insertStudentData;
        private string query;
        private int studentID;
        private string session;

        public MemberDashboard(string session)
        {
            InitializeComponent();            
            this.session = session;
            headerDisplay();
            studenthpTextbox.MaxLength = 12;
        }

        // To ensure all the field are not empty when add student 
        private void validateEmptyField()
        {
            if (string.IsNullOrWhiteSpace(studentNameTextbox.Text) || string.IsNullOrWhiteSpace(studentEmailTextbox.Text) ||
                string.IsNullOrWhiteSpace(studenthpTextbox.Text) || string.IsNullOrWhiteSpace(studentGenderCombobox.Text) ||
                string.IsNullOrWhiteSpace(intakeCodeTextbox.Text))
            {
                insertStudentData = false;                
            }
            else
            {
                insertStudentData = true;
            }
           
        }

        private void headerDisplay()
        {
            Club club = new Club();
            welcomeMessage.Text = club.getClubNameDisplay(session) + "'s Member Dashboard";
        }

        private void MemberDashboard_Load(object sender, EventArgs e)
        {
            displayAllField();
        }

        private void displayAllField()
        {
            Club club = new Club();
            query = "select student_name, student_handphone, student_email, student_gender, student_intakecode from student as s inner join register as r on s.student_id = r.student_id inner join club as c on r.club_id = c.club_id where c.club_id = " + club.getClubIDFromPresident(session);
            displayData(query);
        }

        // clear all the text field after insert data
        private void clearField()
        {
            studentNameTextbox.Text = "";
            studentEmailTextbox.Text = "";
            studenthpTextbox.Text = "";
            studentGenderCombobox.Text = "Male";
            intakeCodeTextbox.Text = "";
        }

        // add button helps insert student data into database. 
        private void addButton_Click(object sender, EventArgs e)
        {
            validateEmptyField();
            if (insertStudentData)
            {
                Member member = new Member(studentNameTextbox.Text, Convert.ToInt64(studenthpTextbox.Text), studentEmailTextbox.Text,
                    studentGenderCombobox.Text, intakeCodeTextbox.Text);


                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = "insert into dbo.Student values ('" + member.getName() + "'," + member.getHP() + ",'"
                    + member.getEmail() + "','" + member.getGender() + "','" + member.getIntakeCode() + "')";
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connect.close();


                //execute another query insert into register table
                addDataIntoRegister();

                displayAllField(); // display all the data
                clearField(); // clear text field 

                // return success message
                messageText.ForeColor = System.Drawing.Color.Green;
                messageText.Text = "Member information INSERT successfully ! ";

            }
            else
            {
                MessageBox.Show("Your action is INVALID because some field is empty or wrong and duplicate name");

                // warning message
                messageText.ForeColor = System.Drawing.Color.Red;
                messageText.Text = "INSERT action is INVALID \n because some field is empty or wrong and duplicate name ! ";
            }          
        }

        private void addDataIntoRegister()
        {
            Club club = new Club();
            Member member = new Member();

            // get student id for register table
            member.setName(studentNameTextbox.Text);
            studentID = member.getMemberID(member.getName());

            // get club id for register table 
            string clubName = club.getClubNameDisplay(session);
            int clubID = club.getClubIDFromPresident(session);

            SqlConn connect = new SqlConn();
            connect.open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.sqlConnection;
            command.CommandText = "insert into dbo.register values(" + studentID + "," + clubID + ",CURRENT_TIMESTAMP, " + club.getClubFeesFromDb(clubID) + ", '0')";
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            connect.close();
        }

        //dataGridView1 RowHeaderMouseClick Event  
        private void memberGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            studentNameTextbox.Text = memberGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            studenthpTextbox.Text = memberGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            studentEmailTextbox.Text = memberGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            studentGenderCombobox.Text = memberGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            intakeCodeTextbox.Text = memberGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

            // register primary key once the row is clicked. 
            Member member = new Member(studentNameTextbox.Text, Convert.ToInt64(studenthpTextbox.Text), studentEmailTextbox.Text, studentGenderCombobox.Text, intakeCodeTextbox.Text);
            studentID = member.getMemberID();

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
                memberGridView.DataSource = datatable;//datagridtable get data from the data table
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
            query = "select student_name, student_handphone, student_email, student_gender, student_intakecode from student as s inner join register as r on s.student_id = r.student_id inner join club as c on r.club_id = c.club_id where c.club_id = " +
                club.getClubIDFromPresident(session) + " and s.student_name like '%" + searchTextbox.Text + "%'";
            displayData(query);
            clearField();
        }

        // clear search result and display all data 
        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            searchTextbox.Text = "";
            clearField();
            displayAllField();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            validateEmptyField();
            if (insertStudentData)
            {

                Member member = new Member(studentNameTextbox.Text, Convert.ToInt64(studenthpTextbox.Text), studentEmailTextbox.Text,
                    studentGenderCombobox.Text, intakeCodeTextbox.Text);

                // get club id for register table 
                Club club = new Club();
                int clubID = club.getClubIDFromPresident(session);

                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                
                command.CommandText = "update s set s.student_name = '" + member.getName() +
                                            "', s.student_handphone = " + member.getHP() +
                                            ", s.student_email = '" + member.getEmail() +
                                            "', s.student_gender = '" + member.getGender() +
                                            "', s.student_intakecode = '" + member.getIntakeCode() +
                "' from student as s inner join register as r on s.student_id = r.student_id inner join club as c on r.club_id = c.club_id where r.student_id = " +
                studentID + " and r.club_id = " + clubID;

                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connect.close();

                displayAllField(); // display all the data
                clearField(); // clear text field 

                // return success message
                messageText.ForeColor = System.Drawing.Color.Green;
                messageText.Text = "Member information UPDATE successfully ! ";

            }
            else
            {
                // warning message
                messageText.ForeColor = System.Drawing.Color.Red;
                messageText.Text = "UPDATE action is INVALID \n because some field is empty or wrong ! ";
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            validateEmptyField();
            if (insertStudentData)
            {

                Member member = new Member(studentNameTextbox.Text, Convert.ToInt64(studenthpTextbox.Text), studentEmailTextbox.Text,
                    studentGenderCombobox.Text, intakeCodeTextbox.Text);

                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = "delete from dbo.Register where student_id = " + studentID;
                SqlDataReader reader = command.ExecuteReader();

                deleteMemberFromStudent();


                reader.Close();
                connect.close();

                displayAllField(); // display all the data
                clearField(); // clear text field 

                // return success message
                messageText.ForeColor = System.Drawing.Color.Green;
                messageText.Text = "Member information DELETE successfully ! ";

            }
            else
            {
                // warning message
                messageText.ForeColor = System.Drawing.Color.Red;
                messageText.Text = "DELETE action is INVALID \n because you haven't select a member! ";
            }
        }

        // delete Member from student table
        private void deleteMemberFromStudent()
        {
            SqlConn connect = new SqlConn();
            connect.open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.sqlConnection;
            command.CommandText = "delete from dbo.Student where student_id = " + studentID;
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            connect.close();
        }

        private void studenthpTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
