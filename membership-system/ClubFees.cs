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

        private void searchButton_Click(object sender, EventArgs e)
        {
            query = "select student_name, member_fees, member_paid from student as s inner join register as r on s.student_id = r.student_id inner join club as c on r.club_id = c.club_id where r.club_id = " +
                club.getClubIDFromPresident(session) + " and s.student_name like '%" + searchTextbox.Text + "%'";
            displayData(query);
            //clearField();
        }

        private void memberGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            studentTextbox.Text = memberGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            feesRequiredTextbox.Text = memberGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            feesPaidTextbox.Text = "0.00";
            feesLeftTextbox.Text = memberGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

            Boolean paidStatus = Convert.ToBoolean(memberGridView.Rows[e.RowIndex].Cells[2].Value.ToString());

            if (!paidStatus)
            {
                feesStatusLabel.ForeColor = System.Drawing.Color.Red;
                feesStatusLabel.Text = "NOT PAID";
            }
            else
            {
                feesStatusLabel.ForeColor = System.Drawing.Color.Green;
                feesStatusLabel.Text = "PAID";
            }
        }

        private void clearField()
        {
            studentTextbox.Text = "";
            feesRequiredTextbox.Text = "";
            feesPaidTextbox.Text = "";
            feesLeftTextbox.Text = "";
        }
    }
}
