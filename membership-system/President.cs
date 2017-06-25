using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace membership_system
{
    class President
    {
        private int pred_id;
        private string pred_name;
        private string pred_email;
        private string pred_gender;
        private string pred_password;
        private bool correct = false;

        public President()
        {

        }

        public void setPresidentName(string pred_name)
        {
            this.pred_name = pred_name.ToString();
        }

        public void setPresidentEmail(string pred_email)
        {
            this.pred_email = pred_email.ToString();
        }

        public void setPresidentGender(string pred_gender)
        {
            this.pred_gender = pred_gender.ToString();
        }

        public void setPresidentPassword(string pw, string retypepw)
        {
            if(pw == retypepw)
            {
                this.pred_password = pw;
                setPasswordBoolean(true);
            }
        }

        public void setPasswordBoolean(bool correct)
        {
            this.correct = correct;
        }

        public string getPresidentName()
        {
            return pred_name;
        }

        public string getPresidentEmail()
        {
            return pred_email;
        }

        public string getPresidentGender()
        {
            return pred_gender;
        }

        public string getPresidentPassword()
        {
            return pred_password;
        }

        public bool getPasswordBoolean()
        {
            return correct;
        }

        public int getPresidentID(string presidentName)
        {
            SqlConn connect = new SqlConn();
            connect.open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.sqlConnection;
            command.CommandText = "select president_id from dbo.President where president_name = '" + presidentName + "'";

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                pred_id = Convert.ToInt32(reader["president_id"].ToString());
            }

            reader.Close();
            connect.close();

            return pred_id;
        }
    }

}
