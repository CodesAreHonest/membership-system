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
    public partial class UserEditAccount : Form
    {
        private string session;
        private Boolean insertData; 

        public UserEditAccount(string session)
        {
            InitializeComponent();
            this.session = session;
            pwTextbox.PasswordChar = '*';
            openView();
            genderCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void openEdit()
        {
            editPanel.Visible = true;
            viewPanel.Visible = false;
        }

        private void openView()
        {
            editPanel.Visible = false;
            viewPanel.Visible = true;
        }

        private void validateEmptyField()
        {
            if(string.IsNullOrWhiteSpace(updateNameTextbox.Text) || string.IsNullOrWhiteSpace(pwTextbox.Text) || string.IsNullOrWhiteSpace(updateEmailTextbox.Text) || string.IsNullOrWhiteSpace(genderCombobox.Text))
            {
                insertData = false;
            }
            else
            {
                insertData = true;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            validateEmptyField();
            if (insertData)
            {
                President p = new President();
                try
                {
                    SqlConn connect = new SqlConn();
                    connect.open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connect.sqlConnection;
                    command.CommandText = "update dbo.President set president_name = '" + updateNameTextbox.Text + "', president_email = '" + updateEmailTextbox.Text +
                        "', president_gender = '" + genderCombobox.Text + "',  president_password = '" + pwTextbox.Text + "' where president_id = " + p.getPresidentID(session);

                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connect.close();

                    // register updated name for session on data retrieval 
                    p.setPresidentName(updateNameTextbox.Text);
                    this.session = p.getPresidentName();

                    MessageBox.Show("Your account details had update successfully! ");
                    openView();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }

                openView();
                loadPresidentData();
            }
            else
            {
                MessageBox.Show("Update action is INVALID \n because some field is empty or wrong. ");
            }
           
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            openEdit();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void UserEditAccount_Load(object sender, EventArgs e)
        {
            loadPresidentData();
        }

        private void loadPresidentData()
        {
            President p = new President();
            try
            {
                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = "select * from dbo.President where president_id = " + p.getPresidentID(session);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    President pred = new President();
                    pred.setPresidentName(reader.GetString(2));
                    pred.setPresidentEmail(reader.GetString(3));
                    pred.setPresidentGender(reader.GetString(4));
                    pred.setPresidentPassword(reader.GetString(5), reader.GetString(5));

                    // show value for edit
                    name.Text = pred.getPresidentName();
                    email.Text = pred.getPresidentEmail();
                    gender.Text = pred.getPresidentGender();
                    pw.Text = pred.getPresidentPassword();

                    // automate value on textfield
                    updateNameTextbox.Text = pred.getPresidentName();
                    pwTextbox.Text = pred.getPresidentPassword();
                    genderCombobox.Text = pred.getPresidentGender();
                    updateEmailTextbox.Text = pred.getPresidentEmail();


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
