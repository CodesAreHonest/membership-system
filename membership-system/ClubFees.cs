using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace membership_system
{
    public partial class clubFees : Form
    {

        Club club = new Club();
        private string session;
        private string query;        

        public clubFees(string session)
        {
            InitializeComponent();
            this.session = session;
            headerDisplay();
        }

        private void headerDisplay()
        {
            welcomeMessage.Text = club.getClubNameDisplay(session) + "'s Club Fees Management";
        }
        
        private void displayFeeSummary()
        {
            query = "select student_name, member_fees, member_paid from student as s inner join register as r on s.student_id = r.student_id inner join club as c on r.club_id = c.club_id where r.club_id = " +
                club.getClubIDFromPresident(session);
            displayData(query);
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

        private void clubFees_Load(object sender, EventArgs e)
        {
            displayFeeSummary();
        }
    }
}
