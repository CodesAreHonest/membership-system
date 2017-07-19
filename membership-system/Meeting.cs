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
        private List<int> expiredMeetingID = new List<int>();

        private string name;
        private string location;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private DateTime startTime;
        private DateTime endTime;

        private string session;
        private TimeSpan duration;
        private TimeSpan reportDuration;
        private string durationString;
        private string durationText;

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

        public void setStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }

        public void setEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }

        public DateTime getStartDate()
        {
            return startDate;
        }

        public DateTime getEndDate()
        {
            return endDate;
        }

        public void calculateDuration()
        {
            duration = (endTime - startTime);
        }

        // for generate report summary use only
        public void calculateReportDuration()
        {
            reportDuration = (endDate - startDate);
        }

        public string getReportDurationText()
        {
            calculateReportDuration();
            durationText = String.Format("{0} hours, {1} minutes, {2} seconds", reportDuration.Hours, reportDuration.Minutes, reportDuration.Seconds);
            return durationText;
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
            command.CommandText = "select meeting_id from dbo.Meeting where meeting_name = '"
                + getMeetingName()
                + "' and club_id = " + club.getClubIDFromPresident(session);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                meetingID = Convert.ToInt32(reader["meeting_id"].ToString());
            }

            reader.Close();
            connect.close();

            return meetingID;
        }

        public int getSecureMeetingID()
        {
            Club club = new Club();
            SqlConn connect = new SqlConn();
            connect.open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.sqlConnection;
            command.CommandText = "select meeting_id from dbo.Meeting where meeting_name = '" 
                + getMeetingName() 
                + "' and meeting_location = '" + getMeetingLocation() 
                + "' and meeting_description = '" + getMeetingDescription() 
                + "' and meeting_starttime = '" + getStartTime() 
                + "' and meeting_endtime = '" + getEndTime()
                + "' and club_id = " + club.getClubIDFromPresident(session);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                meetingID = Convert.ToInt32(reader["meeting_id"].ToString());
            }

            reader.Close();
            connect.close();

            return meetingID;
        }

        public List<int> getExpiredMeetingID()
        {
            Club club = new Club();
            SqlConn connect = new SqlConn();
            connect.open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.sqlConnection;
            command.CommandText = "select distinct meeting_id from dbo.meeting where meeting_endtime < CURRENT_TIMESTAMP and club_id = " + 
                club.getClubIDFromPresident(session);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                expiredMeetingID.Add(Convert.ToInt32(reader["meeting_id"].ToString()));
            }

            reader.Close();
            connect.close();

            return expiredMeetingID;
        }
     

    }
}
