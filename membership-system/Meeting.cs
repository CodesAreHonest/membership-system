using System;
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
        private string session;
        private TimeSpan duration;
        private string durationString;

        public Meeting(string session)
        {
            this.session = session;
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
            duration = (endTime - startTime);
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
            string startTime_String = String.Format("{0}-{1}-{2} {3}:{4}:{5}", startTime.Year, startTime.Month, startTime.Day, startTime.Hour, startTime.Minute, startTime.Second);
            return startTime_String;
        }

        public string getEndTime()
        {
            string endTime_String = String.Format("{0}-{1}-{2} {3}:{4}:{5}", endTime.Year, endTime.Month, endTime.Day, endTime.Hour, endTime.Minute, endTime.Second);
            return endTime_String;
        }

        public int getDuration()
        {
            return Convert.ToInt32(duration.TotalSeconds);
        }

        public string getDurationText()
        {
            calculateDuration();
            durationString = String.Format("{0} hours, {1} minutes, {2} seconds", duration.Hours, duration.Minutes, duration.Seconds);
            return durationString;

        }

        public int getMeetingID()
        {
            Club club = new Club();
            SqlConn connect = new SqlConn();
            connect.open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.sqlConnection;
            command.CommandText = "select meeting_id from dbo.Meeting where meeting_name = '" + 
                getMeetingName() + "' and club_id = " + club.getClubIDFromPresident(session);

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
