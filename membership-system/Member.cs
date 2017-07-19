using System;
using System.Data.SqlClient;

namespace membership_system
{
    class Member
    {
        private int memberID; 
        private string name;
        private long handphone;
        private string email;
        private string gender;
        private string intakecode;

        public Member(string name, long handphone, string email, string gender, string intakecode)
        {
            this.name = name;
            this.handphone = handphone;
            this.email = email;
            this.gender = gender;
            this.intakecode = intakecode;
        }

        public Member()
        {

        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public long getHP()
        {
            return handphone;
        }

        public string getEmail()
        {
            return email;
        }

        public string getGender()
        {
            return gender;
        }

        public string getIntakeCode()
        {
            return intakecode;
        }

        public int getMemberID(string memberName)
        {
            SqlConn connect = new SqlConn();
            connect.open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.sqlConnection;
            command.CommandText = "select student_id from dbo.Student where student_name = '" + memberName + "'";

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                memberID = Convert.ToInt32(reader["student_id"].ToString());
            }

            reader.Close();
            connect.close();

            return memberID;
        }

        public int getMemberID()
        {
            SqlConn connect = new SqlConn();
            connect.open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.sqlConnection;
            command.CommandText = "select student_id from dbo.Student where student_name = '" + getName() 
                + "' and student_handphone = " + getHP() 
                + " and student_email = '" + getEmail() 
                + "' and student_gender = '" + getGender() 
                + "' and student_intakecode = '" + getIntakeCode() + "'";

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                memberID = Convert.ToInt32(reader["student_id"].ToString());
            }

            reader.Close();
            connect.close();

            return memberID;
        }
    }

}

