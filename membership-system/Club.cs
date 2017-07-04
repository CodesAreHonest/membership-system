using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace membership_system
{
    class Club
    {
        private int clubID;
        private string clubName;
        private decimal clubFees;
        private string clubDesription;
        private string clubName_display;

        public Club()
        {

        }

        public void setClubName(string clubName)
        {
            this.clubName = clubName;
        }

        public void setClubFees(decimal clubFees)
        {
            this.clubFees = clubFees;
        }

        public void setClubDescription(string clubDesription)
        {
            this.clubDesription = clubDesription;
        }

        public string getClubName()
        {
            return clubName;
        }

        public string getClubFees()
        {
            return Convert.ToString(clubFees);
        }

        public string getClubDescription()
        {
            return clubDesription;
        }

        public int getClubID(string clubName)
        {
            SqlConn connect = new SqlConn();
            connect.open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.sqlConnection;
            command.CommandText = "select club_id from dbo.Club where club_name = " + clubName;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                clubID = Convert.ToInt32(reader["club_id"].ToString());
            }

            reader.Close();
            connect.close();

            return clubID;
        }

        public int getClubIDFromPresident(string presidentName)
        {
            President pres = new President();
            int presidentID = pres.getPresidentID(presidentName);
            SqlConn connect = new SqlConn();
            connect.open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.sqlConnection;
            command.CommandText = "select club_id from dbo.Club where president_id = " + presidentID;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                clubID = Convert.ToInt32(reader["club_id"].ToString());
            }

            reader.Close();
            connect.close();

            return clubID;
        }

        public string getClubNameDisplay(string presidentName) 
        {
            President pres = new President();
            int presidentID = pres.getPresidentID(presidentName);
            SqlConn connect = new SqlConn();
            connect.open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.sqlConnection;
            command.CommandText = "select club_name from dbo.Club where president_id = " + presidentID;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                clubName_display = reader["club_name"].ToString();
            }

            reader.Close();
            connect.close();

            return clubName_display;
        }
    }
}
