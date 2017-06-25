using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace membership_system
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
            passwordTextbox.PasswordChar = '*'; // ensure the password textbox not show normal words 
            setDefault(signInButton);
        }

        // proceed to dashboard
        private void createDashboard(string name)
        {
            Dashboard dashboard = new Dashboard(name, "");
            this.Hide();
            dashboard.ShowDialog();
        }

        // proceed to register
        private void createRegister()
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
        }

        private void setDefault(Button button)
        {
            this.AcceptButton = button;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = "select * from dbo.President where PRESIDENT_NAME = '" + usernameTextbox.Text + "' and PRESIDENT_PASSWORD = '" + passwordTextbox.Text + "'";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    connect.close();
                    createDashboard(usernameTextbox.Text); // proceed to dashboard if login criteria is correct
                }
                else
                {
                    MessageBox.Show("Incorrect username and password combination.");
                    reader.Close();
                    connect.close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            createRegister();
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
