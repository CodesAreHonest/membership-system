﻿using System;
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
        public UserEditAccount(string session)
        {
            InitializeComponent();
            this.session = session;
            pwTextbox.PasswordChar = '*';
            openView();
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

        private void updateButton_Click(object sender, EventArgs e)
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

                MessageBox.Show("Your account details had update successfully! ");
                openView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            loadPresidentData();
            openView();
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
                command.CommandText = "select * from dbo.President where president_name = '" + session + "'";
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
