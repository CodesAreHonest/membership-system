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
    public partial class UserEditSociety : Form
    {
        private string session;
        private string clubname;
        public UserEditSociety(string session, string clubname)
        {
            InitializeComponent();
            this.session = session;
            this.clubname = clubname;
            showView();
        }

        private void showEdit()
        {
            editPanel.Visible = true;
            viewPanel.Visible = false;
        }

        private void showView()
        {
            editPanel.Visible = false;
            viewPanel.Visible = true;
        }
        private void editSocietyButton_Click(object sender, EventArgs e)
        {
            showEdit();
        }

        private void okSocietyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updateSocietyButton_Click(object sender, EventArgs e)
        {
            President p = new President();
            decimal societyFees = Convert.ToDecimal(societyFeesTextbox.Text);
            try
            {
                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = "update dbo.Club set club_name = '" + societyNameTextbox.Text + "', club_fees = " + societyFees +
                    ", club_description = '" + societyDescriptionTextbox.Text + "' where president_id = " + p.getPresidentID(session);

                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connect.close();

                MessageBox.Show("Your society had update successfully! ");
                showView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            loadClubData();
            showView();
        }

        private void UserEditSociety_Load(object sender, EventArgs e)
        {
            loadClubData();
        }

        private void loadClubData()
        {
            President p = new President();
            try
            {
                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = "select * from dbo.Club where president_id = " + p.getPresidentID(session);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Club club = new Club();
                    club.setClubName(reader.GetString(2));
                    club.setClubFees(reader.GetDecimal(3));
                    club.setClubDescription(reader.GetString(4));

                    // show value for edit
                    societyName.Text = club.getClubName();
                    societyFees.Text = club.getClubFees();
                    societyDescription.Text = club.getClubDescription();

                    // automate value on textfield
                    societyNameTextbox.Text = club.getClubName();
                    societyFeesTextbox.Text = club.getClubFees();
                    societyDescriptionTextbox.Text = club.getClubDescription();

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
