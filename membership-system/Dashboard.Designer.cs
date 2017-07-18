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
            this.memberPanel = new System.Windows.Forms.Panel();
            this.mDashboardButton = new System.Windows.Forms.Button();
            this.memberStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.meetingPanel = new System.Windows.Forms.Panel();
            this.meetingStrips = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cr8meetingReport = new System.Windows.Forms.Button();
            this.inviteMeetingButton = new System.Windows.Forms.Button();
            this.attendancePanel = new System.Windows.Forms.Panel();
            this.attendanceStrips = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.attendanceButton = new System.Windows.Forms.Button();
            this.registerStrip.SuspendLayout();
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
            this.registerStrip.Size = new System.Drawing.Size(1074, 43);
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
            // memberPanel
            // 
            this.memberPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memberPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memberPanel.Controls.Add(this.mDashboardButton);
            this.memberPanel.Controls.Add(this.memberStrip);
            this.memberPanel.Controls.Add(this.button4);
            this.memberPanel.Location = new System.Drawing.Point(213, 101);
            this.memberPanel.Name = "memberPanel";
            this.memberPanel.Size = new System.Drawing.Size(653, 108);
            this.memberPanel.TabIndex = 8;
            // 
            // mDashboardButton
            // 
            this.mDashboardButton.BackColor = System.Drawing.Color.SkyBlue;
            this.mDashboardButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mDashboardButton.Location = new System.Drawing.Point(70, 43);
            this.mDashboardButton.Name = "mDashboardButton";
            this.mDashboardButton.Size = new System.Drawing.Size(214, 40);
            this.mDashboardButton.TabIndex = 10;
            this.mDashboardButton.Text = "Member Registration";
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
            this.button4.Location = new System.Drawing.Point(357, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Club Fees";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // meetingPanel
            // 
            this.meetingPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.meetingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.meetingPanel.Controls.Add(this.meetingStrips);
            this.meetingPanel.Controls.Add(this.cr8meetingReport);
            this.meetingPanel.Controls.Add(this.inviteMeetingButton);
            this.meetingPanel.Location = new System.Drawing.Point(214, 256);
            this.meetingPanel.Name = "meetingPanel";
            this.meetingPanel.Size = new System.Drawing.Size(653, 113);
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
            this.cr8meetingReport.Location = new System.Drawing.Point(358, 45);
            this.cr8meetingReport.Name = "cr8meetingReport";
            this.cr8meetingReport.Size = new System.Drawing.Size(214, 40);
            this.cr8meetingReport.TabIndex = 8;
            this.cr8meetingReport.Text = "Generate Meeting Report";
            this.cr8meetingReport.UseVisualStyleBackColor = false;
            this.cr8meetingReport.Click += new System.EventHandler(this.cr8meetingReport_Click);
            // 
            // inviteMeetingButton
            // 
            this.inviteMeetingButton.BackColor = System.Drawing.Color.SkyBlue;
            this.inviteMeetingButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inviteMeetingButton.Location = new System.Drawing.Point(71, 45);
            this.inviteMeetingButton.Name = "inviteMeetingButton";
            this.inviteMeetingButton.Size = new System.Drawing.Size(214, 40);
            this.inviteMeetingButton.TabIndex = 5;
            this.inviteMeetingButton.Text = "Meeting Management";
            this.inviteMeetingButton.UseVisualStyleBackColor = false;
            this.inviteMeetingButton.Click += new System.EventHandler(this.inviteMeetingButton_Click);
            // 
            // attendancePanel
            // 
            this.attendancePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.attendancePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attendancePanel.Controls.Add(this.attendanceButton);
            this.attendancePanel.Controls.Add(this.attendanceStrips);
            this.attendancePanel.Location = new System.Drawing.Point(213, 413);
            this.attendancePanel.Name = "attendancePanel";
            this.attendancePanel.Size = new System.Drawing.Size(651, 121);
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
            this.attendanceStrips.Size = new System.Drawing.Size(649, 25);
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
            // attendanceButton
            // 
            this.attendanceButton.BackColor = System.Drawing.Color.SkyBlue;
            this.attendanceButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceButton.Location = new System.Drawing.Point(216, 55);
            this.attendanceButton.Name = "attendanceButton";
            this.attendanceButton.Size = new System.Drawing.Size(214, 40);
            this.attendanceButton.TabIndex = 10;
            this.attendanceButton.Text = "Attendance Management";
            this.attendanceButton.UseVisualStyleBackColor = false;
            this.attendanceButton.Click += new System.EventHandler(this.attendanceButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 597);
            this.Controls.Add(this.attendancePanel);
            this.Controls.Add(this.meetingPanel);
            this.Controls.Add(this.memberPanel);
            this.Controls.Add(this.registerStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.registerStrip.ResumeLayout(false);
            this.registerStrip.PerformLayout();
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
        private System.Windows.Forms.Panel memberPanel;
        private System.Windows.Forms.ToolStrip memberStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel meetingPanel;
        private System.Windows.Forms.ToolStrip meetingStrips;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Button cr8meetingReport;
        private System.Windows.Forms.Button inviteMeetingButton;
        private System.Windows.Forms.Panel attendancePanel;
        private System.Windows.Forms.ToolStrip attendanceStrips;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Button mDashboardButton;
        private System.Windows.Forms.Button attendanceButton;
    }
}