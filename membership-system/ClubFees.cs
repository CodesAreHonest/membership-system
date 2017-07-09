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
        private Boolean insertStudentData;
        private decimal leftFees;

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
            query = "select student_name, member_fees, member_paid, register_date from student as s inner join register as r on s.student_id = r.student_id inner join club as c on r.club_id = c.club_id where r.club_id = " +
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
            query = "select student_name, member_fees, member_paid, register_date from student as s inner join register as r on s.student_id = r.student_id inner join club as c on r.club_id = c.club_id where r.club_id = " +
                club.getClubIDFromPresident(session) + " and s.student_name like '%" + searchTextbox.Text + "%'";
            displayData(query);
            clearField();
        }

        private void memberGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            studNameLabel.Text = memberGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
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

        private void validateEmptyField()
        {
            if(string.IsNullOrEmpty(studNameLabel.Text) || string.IsNullOrWhiteSpace(feesLeftTextbox.Text) || string.IsNullOrWhiteSpace(feesRequiredTextbox.Text) || string.IsNullOrWhiteSpace(feesPaidTextbox.Text))
            {
                insertStudentData = false;
            }
            else
            {
                insertStudentData = true;
            }
        }

        private void clearField()
        {
            studNameLabel.Text = "";
            feesRequiredTextbox.Text = "";
            feesPaidTextbox.Text = "";
            feesLeftTextbox.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            validateEmptyField();
            if (insertStudentData)
            {
                // calculate the fees even though without pressing the button 
                calculateFees();

                // determine the paid status if the fees left is zero 
                Fee f = new Fee();
                f.setFeesLeft(leftFees);
                int paidStatus = f.calculatePaidStatus();

                // get club id for register table 
                Club club = new Club();
                int clubID = club.getClubIDFromPresident(session);

                // get student id for register table
                Member member = new Member();
                member.setName(studNameLabel.Text);
                int studentID = member.getMemberID(member.getName());

                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;

                command.CommandText = "update r set r.member_fees = " + leftFees + ", member_paid = " + paidStatus + " from student as s inner join register as r on s.student_id = r.student_id inner join club as c on r.club_id = c.club_id where r.student_id = " +
                    studentID + " and r.club_id = " + clubID;
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connect.close();

                displayFeeSummary(); // display all the fees summary
                clearField(); // clear text field */

                MessageBox.Show("The club fee had UPDATED successfully! ");

            }
            else
            {
                MessageBox.Show("UPDATE action is INVALID \nbecause some field is empty or wrong !");
            }

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            calculateFees();
        }

        private void calculateFees()
        {
            decimal requiredFees = Convert.ToDecimal(feesRequiredTextbox.Text);
            decimal paidFees = Convert.ToDecimal(feesPaidTextbox.Text);

            Fee fees = new Fee();
            fees.setFeesRequiredToPay(requiredFees);
            fees.setFeesPaid(paidFees);

            leftFees = fees.calculateRemainingFees();
            fees.setFeesLeft(leftFees);

            feesLeftTextbox.Text = leftFees.ToString();
        }
    }
}
