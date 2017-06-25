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
                MessageBox.Show("Please fill all the field for student data! ");

                // warning message
                messageText.ForeColor = System.Drawing.Color.Red;
                messageText.Text = "Please fill all the field for student data! ";
                
            }
            else
            {
                insertStudentData = true;
            }
        }

        private void MemberDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_membership_system_dbDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this._membership_system_dbDataSet.Student);

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
                messageText.Text = "Member information insert successfully ! ";

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
                command.CommandText = "insert into dbo.Student values ('" + member.getName() + "'," + member.getHP() + ",'"
                    + member.getEmail() + "','" + member.getGender() + "','" + member.getIntakeCode() + "')";
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connect.close();

                displayAllField(); // display all the data
                clearField(); // clear text field 

                             

            }

        }
    }
}
