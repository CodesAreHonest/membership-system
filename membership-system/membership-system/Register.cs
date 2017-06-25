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
    public partial class Register : Form
    {

        private int clubID;
        private bool insertPresidentData = false;
        public Register()
        {
            InitializeComponent();
            loadClubCombobox();
            this.CenterToScreen();
            pwTextbox.PasswordChar = '*';
            retypepwTextbox.PasswordChar = '*';
            
        }

        public void loadClubCombobox()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\gitRepo\membership-system\membership-system\membership-system-db.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select club_name from dbo.Club where president_id is null", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            posCombobox.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                posCombobox.Items.Add(item[0].ToString());
            }
        }

        private void createClubButton_Click(object sender, EventArgs e)
        {
            ClubRegistration cr = new ClubRegistration();
            cr.ShowDialog();
        }

        private void registerStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();
            login.ShowDialog();
        }

        private int getClubID(string clubName)
        {
            SqlConn connect = new SqlConn();
            connect.open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.sqlConnection;
            command.CommandText = "select club_id from dbo.Club where club_name = '" + clubName + "'";

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                clubID = Convert.ToInt32(reader["club_id"].ToString());
            }

            reader.Close();
            connect.close();

            return clubID;         
        }

        private void validateEmptyField()
        {
            if (string.IsNullOrWhiteSpace(nameTextbox.Text) || string.IsNullOrWhiteSpace(emailTextbox.Text) || 
                string.IsNullOrWhiteSpace(genderCombobox.Text) || string.IsNullOrWhiteSpace(pwTextbox.Text) || 
                string.IsNullOrWhiteSpace(retypepwTextbox.Text))
            {
                insertPresidentData = false;
                MessageBox.Show("Please fill all the field in order to create account! ");
            }
            else
            {
                insertPresidentData = true;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            validateEmptyField();

            if (insertPresidentData)
            {
                President pred = new President();
                pred.setPresidentName(nameTextbox.Text);
                pred.setPresidentEmail(emailTextbox.Text);
                pred.setPresidentGender(genderCombobox.Text);
                pred.setPresidentPassword(pwTextbox.Text, retypepwTextbox.Text);

                if (pred.getPasswordBoolean() == false)
                {
                    MessageBox.Show("Your password does not match, please retype again.");
                }
                else
                {
                    SqlConn connect = new SqlConn();
                    connect.open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connect.sqlConnection;
                    command.CommandText = "insert into dbo.President values ('" + getClubID(posCombobox.Text) +
                        "','" + pred.getPresidentName() + "','" + pred.getPresidentEmail() + "','"
                        + pred.getPresidentGender() + "','" + pred.getPresidentPassword() + "');";

                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connect.close();

                    MessageBox.Show("Your account had been created successfully! ");

                    Dashboard dashboard = new Dashboard(pred.getPresidentName(), posCombobox.Text);
                    this.Hide();
                    dashboard.ShowDialog();
                }
            }                 
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            loadClubCombobox();
        }

        private void pwTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
