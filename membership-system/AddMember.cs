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
    public partial class AddMember : Form
    {
        private bool insertStudentData;
        public AddMember()
        {
            InitializeComponent();
        }

        private void validateEmptyField()
        {
            if (string.IsNullOrWhiteSpace(studentNameTextbox.Text) || string.IsNullOrWhiteSpace(studentEmailTextbox.Text) ||
                string.IsNullOrWhiteSpace(studenthpTextbox.Text) || string.IsNullOrWhiteSpace(studentGenderCombobox.Text) ||
                string.IsNullOrWhiteSpace(intakeCodeTextbox.Text))
            {
                insertStudentData = false;
                MessageBox.Show("Please fill all the field for student data! ");
            }
            else
            {
                insertStudentData = true;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
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

                MessageBox.Show("Member information insert successfully ! ");              
                this.Hide();

            }
            this.Hide();
        }
    }
}
