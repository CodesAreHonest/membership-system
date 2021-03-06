﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace membership_system
{
    public partial class Dashboard : Form
    {
        private string session; // register session with president name
        private string clubname; // register session with club only happens after register

        public Dashboard(string session, string clubname)
        {
            InitializeComponent();
            this.session = session;
            this.clubname = clubname;
            this.CenterToScreen();
            updateClubDatabase(session, clubname);
            changeWelcomeMessage(session);
        }

        private void changeWelcomeMessage(string session)
        {
            welcomeMessage.Text = "Dear " + session + " , Welcome to Membership System";
        }

        private void createLogin()
        {
            Login login = new membership_system.Login();
            this.Hide();
            login.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void editAccountSelection_Click(object sender, EventArgs e)
        {
            UserEditAccount uea = new UserEditAccount(session);
            uea.ShowDialog();
        }

        private void editSocietySelection_Click(object sender, EventArgs e)
        {
            UserEditSociety ues = new UserEditSociety(session, clubname);
            ues.ShowDialog(); 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clubFees cf = new clubFees(session);
            cf.ShowDialog();
        }

        private void inviteMeetingButton_Click(object sender, EventArgs e)
        {
            MeetingDashboard md = new MeetingDashboard(session);
            md.ShowDialog();
        }

        private void cr8meetingReport_Click(object sender, EventArgs e)
        {
            PrintMeeting mr = new PrintMeeting(session);
            mr.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            createLogin();
        }

        private void updateClubDatabase(string session, string clubname)
        {
            if(clubname == ""){
                return;
            }
            else
            {
                President p = new President();
                SqlConn connect = new SqlConn();
                connect.open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect.sqlConnection;
                command.CommandText = "update dbo.club set president_id = " + p.getPresidentID(session) +
                    " where club_name = '" + clubname + "'";

                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connect.close();
            }

        }

        private void mDashboardButton_Click(object sender, EventArgs e)
        {
            MemberDashboard mb = new MemberDashboard(session);
            mb.ShowDialog();
        }

        private void attendanceButton_Click(object sender, EventArgs e)
        {
            AttendanceManagement am = new AttendanceManagement(session);
            am.ShowDialog();
        }
    }
}
