﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace membership_system
{
    class Meeting
    {
        private int meetingID;
        private string name;
        private string location;
        private string description;
        private DateTime startTime;
        private DateTime endTime;
        private decimal meetingDuration;

        public Meeting()
        {

        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setLocation(string location)
        {
            this.location = location;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void setStartTime(DateTime startDate, DateTime startTime)
        {
            this.startTime = startDate.Date + startTime.TimeOfDay;
        }

        public void setEndTime(DateTime endDate, DateTime endTime)
        {
            this.endTime = endDate.Date + endTime.TimeOfDay;
        }

        public void calculateDuration()
        {
            DateTime duration = Convert.ToDateTime(endTime - startTime);
            this.meetingDuration = Convert.ToDecimal(duration);
        }

        public string getMeetingName()
        {
            return name;
        }

        public string getMeetingLocation()
        {
            return location;
        }

        public string getMeetingDescription()
        {
            return description;
        }

        public string getStartTime()
        {
            return startTime.ToString();
        }

        public string getEndTime()
        {
            return endTime.ToString();
        }

        public decimal getDuration()
        {
            return meetingDuration;
        }

        public int getMeetingID(string meetingName)
        {
            SqlConn connect = new SqlConn();
            connect.open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.sqlConnection;
            //command.CommandText = "select meeting_id from dbo.Meeting where meeting_name = '" + meetingName + "' and club_id = ";

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                meetingID = Convert.ToInt32(reader["meeting_id"].ToString());
            }

            reader.Close();
            connect.close();

            return meetingID;
        }
    

    }
}
