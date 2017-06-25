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


        public MemberDashboard()
        {
            InitializeComponent();
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

        private void MemberDashboard_Load(object sender, EventArgs e)
        {
            displayAllField();

        }

        private void displayAllField()
        {
            query = "select student_name, student_handphone, student_email, student_gender, student_intakecode from dbo.Student";
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
                Member member = new Member(studentNameTextbox.Text, Convert.ToInt32(studenthpTextbox.Text), studentEmailTextbox.Text,
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

                displayAllField(); // display all the data
                clearField(); // clear text field 

                // return success message
                messageText.ForeColor = System.Drawing.Color.Green;
                messageText.Text = "Member information INSERT successfully ! ";

            }
            else
            {
                MessageBox.Show("Your action is INVALID because some field is empty or wrong");

                // warning message
                messageText.ForeColor = System.Drawing.Color.Red;
                messageText.Text = "INSERT action is INVALID \n because some field is empty or wrong ! ";
            }          
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
            Member member = new Member();
            member.setName(studentNameTextbox.Text);
            studentID = member.getMemberID(member.getName());
            messageText.Text = studentID.ToString();
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
            query = "select student_name, student_handphone, student_email, student_gender, student_intakecode from dbo.Student where student_name like '%" +
                searchTextbox.Text + "%'";
            displayData(query);
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


                Member member = new Member(studentNameTextbox.Text, Convert.ToInt32(studenthpTextbox.Text), studentEmailTextbox.Text,
                    studentGenderCombobox.Text, intakeCodeTextbox.Text);

                


                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = "update dbo.Student set student_name = '" + member.getName() + 
                                            "', student_handphone = " + member.getHP() + 
                                            ", student_email = '" + member.getEmail() + 
                                            "', student_gender = '" + member.getGender() + 
                                            "', student_intakecode = '" + member.getIntakeCode() + 
                                            "' where student_id = " + studentID;                   
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


                Member member = new Member(studentNameTextbox.Text, Convert.ToInt32(studenthpTextbox.Text), studentEmailTextbox.Text,
                    studentGenderCombobox.Text, intakeCodeTextbox.Text);

                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = "delete from dbo.Student where student_id = " + studentID;
                SqlDataReader reader = command.ExecuteReader();
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
    }
}
