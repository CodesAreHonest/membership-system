namespace membership_system
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.registerStrip = new System.Windows.Forms.ToolStrip();
            this.welcomeMessage = new System.Windows.Forms.ToolStripLabel();
            this.dashboardAction = new System.Windows.Forms.ToolStripDropDownButton();
            this.editSocietySelection = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMeeting = new System.Windows.Forms.Button();
            this.manageAttendance = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.memberPanel = new System.Windows.Forms.Panel();
            this.mDashboardButton = new System.Windows.Forms.Button();
            this.memberStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.viewMemberButton = new System.Windows.Forms.Button();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.meetingPanel = new System.Windows.Forms.Panel();
            this.meetingStrips = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cr8meetingReport = new System.Windows.Forms.Button();
            this.editMeetingButton = new System.Windows.Forms.Button();
            this.createMeetingButton = new System.Windows.Forms.Button();
            this.inviteMeetingButton = new System.Windows.Forms.Button();
            this.attendancePanel = new System.Windows.Forms.Panel();
            this.attendanceStrips = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.printAttendance = new System.Windows.Forms.Button();
            this.deleteAttendance = new System.Windows.Forms.Button();
            this.recordAttendance = new System.Windows.Forms.Button();
            this.editAttendance = new System.Windows.Forms.Button();
            this.manageMember = new System.Windows.Forms.Button();
            this.registerStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.memberPanel.SuspendLayout();
            this.memberStrip.SuspendLayout();
            this.meetingPanel.SuspendLayout();
            this.meetingStrips.SuspendLayout();
            this.attendancePanel.SuspendLayout();
            this.attendanceStrips.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerStrip
            // 
            this.registerStrip.BackColor = System.Drawing.Color.SkyBlue;
            this.registerStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.registerStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.registerStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeMessage,
            this.dashboardAction});
            this.registerStrip.Location = new System.Drawing.Point(0, 0);
            this.registerStrip.Name = "registerStrip";
            this.registerStrip.Padding = new System.Windows.Forms.Padding(20, 0, 1, 0);
            this.registerStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.registerStrip.Size = new System.Drawing.Size(1236, 43);
            this.registerStrip.TabIndex = 2;
            this.registerStrip.Text = "toolStrip1";
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.AutoSize = false;
            this.welcomeMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.welcomeMessage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.welcomeMessage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(500, 40);
            this.welcomeMessage.Text = "Dear User, Welcome to Membership System";
            // 
            // dashboardAction
            // 
            this.dashboardAction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dashboardAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSocietySelection,
            this.editAccountSelection,
            this.signOutToolStripMenuItem});
            this.dashboardAction.Image = ((System.Drawing.Image)(resources.GetObject("dashboardAction.Image")));
            this.dashboardAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dashboardAction.Margin = new System.Windows.Forms.Padding(150, 1, 0, 2);
            this.dashboardAction.Name = "dashboardAction";
            this.dashboardAction.Size = new System.Drawing.Size(70, 40);
            this.dashboardAction.Text = "Setting";
            // 
            // editSocietySelection
            // 
            this.editSocietySelection.Name = "editSocietySelection";
            this.editSocietySelection.Size = new System.Drawing.Size(168, 26);
            this.editSocietySelection.Text = "Edit Society";
            this.editSocietySelection.Click += new System.EventHandler(this.editSocietySelection_Click);
            // 
            // editAccountSelection
            // 
            this.editAccountSelection.Name = "editAccountSelection";
            this.editAccountSelection.Size = new System.Drawing.Size(168, 26);
            this.editAccountSelection.Text = "Edit Account";
            this.editAccountSelection.Click += new System.EventHandler(this.editAccountSelection_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // manageMeeting
            // 
            this.manageMeeting.BackColor = System.Drawing.Color.SkyBlue;
            this.manageMeeting.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageMeeting.Location = new System.Drawing.Point(779, 67);
            this.manageMeeting.Name = "manageMeeting";
            this.manageMeeting.Size = new System.Drawing.Size(209, 40);
            this.manageMeeting.TabIndex = 5;
            this.manageMeeting.Text = "Manage Meeting";
            this.manageMeeting.UseVisualStyleBackColor = false;
            this.manageMeeting.Click += new System.EventHandler(this.manageMeeting_Click);
            // 
            // manageAttendance
            // 
            this.manageAttendance.BackColor = System.Drawing.Color.SkyBlue;
            this.manageAttendance.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageAttendance.Location = new System.Drawing.Point(998, 67);
            this.manageAttendance.Name = "manageAttendance";
            this.manageAttendance.Size = new System.Drawing.Size(209, 40);
            this.manageAttendance.TabIndex = 6;
            this.manageAttendance.Text = "Manage Attendance";
            this.manageAttendance.UseVisualStyleBackColor = false;
            this.manageAttendance.Click += new System.EventHandler(this.manageAttendance_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(13, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 528);
            this.panel1.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(518, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(154, 22);
            this.toolStripLabel1.Text = "Upcoming Meeting";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.3089F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.6911F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // memberPanel
            // 
            this.memberPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memberPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memberPanel.Controls.Add(this.mDashboardButton);
            this.memberPanel.Controls.Add(this.memberStrip);
            this.memberPanel.Controls.Add(this.button4);
            this.memberPanel.Controls.Add(this.viewMemberButton);
            this.memberPanel.Controls.Add(this.addMemberButton);
            this.memberPanel.Location = new System.Drawing.Point(555, 139);
            this.memberPanel.Name = "memberPanel";
            this.memberPanel.Size = new System.Drawing.Size(653, 211);
            this.memberPanel.TabIndex = 8;
            // 
            // mDashboardButton
            // 
            this.mDashboardButton.BackColor = System.Drawing.Color.SkyBlue;
            this.mDashboardButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mDashboardButton.Location = new System.Drawing.Point(388, 55);
            this.mDashboardButton.Name = "mDashboardButton";
            this.mDashboardButton.Size = new System.Drawing.Size(214, 40);
            this.mDashboardButton.TabIndex = 10;
            this.mDashboardButton.Text = "Manage Member";
            this.mDashboardButton.UseVisualStyleBackColor = false;
            this.mDashboardButton.Click += new System.EventHandler(this.mDashboardButton_Click);
            // 
            // memberStrip
            // 
            this.memberStrip.BackColor = System.Drawing.Color.LightSkyBlue;
            this.memberStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.memberStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.memberStrip.Location = new System.Drawing.Point(0, 0);
            this.memberStrip.Name = "memberStrip";
            this.memberStrip.Size = new System.Drawing.Size(651, 25);
            this.memberStrip.TabIndex = 9;
            this.memberStrip.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.DarkBlue;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(136, 22);
            this.toolStripLabel2.Text = "Manage Member";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(388, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Club Fees";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // viewMemberButton
            // 
            this.viewMemberButton.BackColor = System.Drawing.Color.SkyBlue;
            this.viewMemberButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMemberButton.Location = new System.Drawing.Point(46, 125);
            this.viewMemberButton.Name = "viewMemberButton";
            this.viewMemberButton.Size = new System.Drawing.Size(214, 40);
            this.viewMemberButton.TabIndex = 7;
            this.viewMemberButton.Text = "View Member";
            this.viewMemberButton.UseVisualStyleBackColor = false;
            this.viewMemberButton.Click += new System.EventHandler(this.viewMemberButton_Click);
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.SkyBlue;
            this.addMemberButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.Location = new System.Drawing.Point(46, 55);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(214, 40);
            this.addMemberButton.TabIndex = 6;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // meetingPanel
            // 
            this.meetingPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.meetingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.meetingPanel.Controls.Add(this.meetingStrips);
            this.meetingPanel.Controls.Add(this.cr8meetingReport);
            this.meetingPanel.Controls.Add(this.editMeetingButton);
            this.meetingPanel.Controls.Add(this.createMeetingButton);
            this.meetingPanel.Controls.Add(this.inviteMeetingButton);
            this.meetingPanel.Location = new System.Drawing.Point(554, 227);
            this.meetingPanel.Name = "meetingPanel";
            this.meetingPanel.Size = new System.Drawing.Size(653, 217);
            this.meetingPanel.TabIndex = 10;
            // 
            // meetingStrips
            // 
            this.meetingStrips.BackColor = System.Drawing.Color.LightSkyBlue;
            this.meetingStrips.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.meetingStrips.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3});
            this.meetingStrips.Location = new System.Drawing.Point(0, 0);
            this.meetingStrips.Name = "meetingStrips";
            this.meetingStrips.Size = new System.Drawing.Size(651, 25);
            this.meetingStrips.TabIndex = 9;
            this.meetingStrips.Text = "toolStrip3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel3.ForeColor = System.Drawing.Color.DarkBlue;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(135, 22);
            this.toolStripLabel3.Text = "Manage Meeting";
            // 
            // cr8meetingReport
            // 
            this.cr8meetingReport.BackColor = System.Drawing.Color.SkyBlue;
            this.cr8meetingReport.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cr8meetingReport.Location = new System.Drawing.Point(388, 125);
            this.cr8meetingReport.Name = "cr8meetingReport";
            this.cr8meetingReport.Size = new System.Drawing.Size(214, 40);
            this.cr8meetingReport.TabIndex = 8;
            this.cr8meetingReport.Text = "Generate Meeting Report";
            this.cr8meetingReport.UseVisualStyleBackColor = false;
            this.cr8meetingReport.Click += new System.EventHandler(this.cr8meetingReport_Click);
            // 
            // editMeetingButton
            // 
            this.editMeetingButton.BackColor = System.Drawing.Color.SkyBlue;
            this.editMeetingButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMeetingButton.Location = new System.Drawing.Point(46, 125);
            this.editMeetingButton.Name = "editMeetingButton";
            this.editMeetingButton.Size = new System.Drawing.Size(214, 40);
            this.editMeetingButton.TabIndex = 7;
            this.editMeetingButton.Text = "Edit Meeting";
            this.editMeetingButton.UseVisualStyleBackColor = false;
            this.editMeetingButton.Click += new System.EventHandler(this.editMeetingButton_Click);
            // 
            // createMeetingButton
            // 
            this.createMeetingButton.BackColor = System.Drawing.Color.SkyBlue;
            this.createMeetingButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMeetingButton.Location = new System.Drawing.Point(46, 55);
            this.createMeetingButton.Name = "createMeetingButton";
            this.createMeetingButton.Size = new System.Drawing.Size(214, 40);
            this.createMeetingButton.TabIndex = 6;
            this.createMeetingButton.Text = "Create Meeting";
            this.createMeetingButton.UseVisualStyleBackColor = false;
            this.createMeetingButton.Click += new System.EventHandler(this.createMeetingButton_Click);
            // 
            // inviteMeetingButton
            // 
            this.inviteMeetingButton.BackColor = System.Drawing.Color.SkyBlue;
            this.inviteMeetingButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inviteMeetingButton.Location = new System.Drawing.Point(388, 55);
            this.inviteMeetingButton.Name = "inviteMeetingButton";
            this.inviteMeetingButton.Size = new System.Drawing.Size(214, 40);
            this.inviteMeetingButton.TabIndex = 5;
            this.inviteMeetingButton.Text = "Send Meeting Invite";
            this.inviteMeetingButton.UseVisualStyleBackColor = false;
            this.inviteMeetingButton.Click += new System.EventHandler(this.inviteMeetingButton_Click);
            // 
            // attendancePanel
            // 
            this.attendancePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.attendancePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attendancePanel.Controls.Add(this.attendanceStrips);
            this.attendancePanel.Controls.Add(this.printAttendance);
            this.attendancePanel.Controls.Add(this.deleteAttendance);
            this.attendancePanel.Controls.Add(this.recordAttendance);
            this.attendancePanel.Controls.Add(this.editAttendance);
            this.attendancePanel.Location = new System.Drawing.Point(554, 335);
            this.attendancePanel.Name = "attendancePanel";
            this.attendancePanel.Size = new System.Drawing.Size(653, 211);
            this.attendancePanel.TabIndex = 11;
            // 
            // attendanceStrips
            // 
            this.attendanceStrips.BackColor = System.Drawing.Color.LightSkyBlue;
            this.attendanceStrips.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.attendanceStrips.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4});
            this.attendanceStrips.Location = new System.Drawing.Point(0, 0);
            this.attendanceStrips.Name = "attendanceStrips";
            this.attendanceStrips.Size = new System.Drawing.Size(651, 25);
            this.attendanceStrips.TabIndex = 9;
            this.attendanceStrips.Text = "toolStrip4";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel4.ForeColor = System.Drawing.Color.DarkBlue;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(162, 22);
            this.toolStripLabel4.Text = "Manage Attendance";
            // 
            // printAttendance
            // 
            this.printAttendance.BackColor = System.Drawing.Color.SkyBlue;
            this.printAttendance.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printAttendance.Location = new System.Drawing.Point(388, 125);
            this.printAttendance.Name = "printAttendance";
            this.printAttendance.Size = new System.Drawing.Size(214, 40);
            this.printAttendance.TabIndex = 8;
            this.printAttendance.Text = "Print Attendance";
            this.printAttendance.UseVisualStyleBackColor = false;
            this.printAttendance.Click += new System.EventHandler(this.printAttendance_Click);
            // 
            // deleteAttendance
            // 
            this.deleteAttendance.BackColor = System.Drawing.Color.SkyBlue;
            this.deleteAttendance.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAttendance.Location = new System.Drawing.Point(46, 125);
            this.deleteAttendance.Name = "deleteAttendance";
            this.deleteAttendance.Size = new System.Drawing.Size(214, 40);
            this.deleteAttendance.TabIndex = 7;
            this.deleteAttendance.Text = "Delete Attendance";
            this.deleteAttendance.UseVisualStyleBackColor = false;
            this.deleteAttendance.Click += new System.EventHandler(this.deleteAttendance_Click);
            // 
            // recordAttendance
            // 
            this.recordAttendance.BackColor = System.Drawing.Color.SkyBlue;
            this.recordAttendance.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordAttendance.Location = new System.Drawing.Point(46, 55);
            this.recordAttendance.Name = "recordAttendance";
            this.recordAttendance.Size = new System.Drawing.Size(214, 40);
            this.recordAttendance.TabIndex = 6;
            this.recordAttendance.Text = "Record Attendance";
            this.recordAttendance.UseVisualStyleBackColor = false;
            this.recordAttendance.Click += new System.EventHandler(this.recordAttendance_Click);
            // 
            // editAttendance
            // 
            this.editAttendance.BackColor = System.Drawing.Color.SkyBlue;
            this.editAttendance.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAttendance.Location = new System.Drawing.Point(388, 55);
            this.editAttendance.Name = "editAttendance";
            this.editAttendance.Size = new System.Drawing.Size(214, 40);
            this.editAttendance.TabIndex = 5;
            this.editAttendance.Text = "Edit Attendance";
            this.editAttendance.UseVisualStyleBackColor = false;
            this.editAttendance.Click += new System.EventHandler(this.editAttendance_Click);
            // 
            // manageMember
            // 
            this.manageMember.BackColor = System.Drawing.Color.SkyBlue;
            this.manageMember.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageMember.Location = new System.Drawing.Point(554, 67);
            this.manageMember.Name = "manageMember";
            this.manageMember.Size = new System.Drawing.Size(209, 40);
            this.manageMember.TabIndex = 12;
            this.manageMember.Text = "Manage Member";
            this.manageMember.UseVisualStyleBackColor = false;
            this.manageMember.Click += new System.EventHandler(this.manageMember_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 597);
            this.Controls.Add(this.manageMember);
            this.Controls.Add(this.attendancePanel);
            this.Controls.Add(this.meetingPanel);
            this.Controls.Add(this.memberPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.manageAttendance);
            this.Controls.Add(this.manageMeeting);
            this.Controls.Add(this.registerStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.registerStrip.ResumeLayout(false);
            this.registerStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.memberPanel.ResumeLayout(false);
            this.memberPanel.PerformLayout();
            this.memberStrip.ResumeLayout(false);
            this.memberStrip.PerformLayout();
            this.meetingPanel.ResumeLayout(false);
            this.meetingPanel.PerformLayout();
            this.meetingStrips.ResumeLayout(false);
            this.meetingStrips.PerformLayout();
            this.attendancePanel.ResumeLayout(false);
            this.attendancePanel.PerformLayout();
            this.attendanceStrips.ResumeLayout(false);
            this.attendanceStrips.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip registerStrip;
        private System.Windows.Forms.ToolStripLabel welcomeMessage;
        private System.Windows.Forms.ToolStripDropDownButton dashboardAction;
        private System.Windows.Forms.ToolStripMenuItem editSocietySelection;
        private System.Windows.Forms.ToolStripMenuItem editAccountSelection;
        private System.Windows.Forms.Button manageMeeting;
        private System.Windows.Forms.Button manageAttendance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel memberPanel;
        private System.Windows.Forms.ToolStrip memberStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button viewMemberButton;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Panel meetingPanel;
        private System.Windows.Forms.ToolStrip meetingStrips;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Button cr8meetingReport;
        private System.Windows.Forms.Button editMeetingButton;
        private System.Windows.Forms.Button createMeetingButton;
        private System.Windows.Forms.Button inviteMeetingButton;
        private System.Windows.Forms.Panel attendancePanel;
        private System.Windows.Forms.ToolStrip attendanceStrips;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.Button printAttendance;
        private System.Windows.Forms.Button deleteAttendance;
        private System.Windows.Forms.Button recordAttendance;
        private System.Windows.Forms.Button editAttendance;
        private System.Windows.Forms.Button manageMember;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button mDashboardButton;
    }
}