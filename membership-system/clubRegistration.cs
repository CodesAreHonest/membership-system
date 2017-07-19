using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace membership_system
{
    public partial class ClubRegistration : Form
    {
        Boolean insertClubData = false;

        public ClubRegistration()
        {
            InitializeComponent();
        }

        private void validateEmptyField()
        {
            if(string.IsNullOrWhiteSpace(societyNameTextbox.Text) || string.IsNullOrWhiteSpace(societyDescriptionTextbox.Text) || string.IsNullOrWhiteSpace(societyFeesTextbox.Text))
            {
                insertClubData = false; 
                MessageBox.Show("Please fill all the field in order to create society! ");
            }
            else
            {
                insertClubData = true;               
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            validateEmptyField();
            if (insertClubData)
            {
                
                decimal societyFees = Convert.ToDecimal(societyFeesTextbox.Text);
                try
                {
                    SqlConn connect = new SqlConn();
                    connect.open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connect.sqlConnection;
                    command.CommandText = "insert into dbo.Club values (NULL, '" + societyNameTextbox.Text + "'," + societyFees + ",'" + societyDescriptionTextbox.Text + "');";
                    
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connect.close();

                    MessageBox.Show("Your society had created successfully, please click [Refresh] to display your society in the list. ");
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }
                       
        }

        private void societyFeesTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
