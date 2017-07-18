namespace membership_system
{
    partial class AttendanceManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.registerStrip = new System.Windows.Forms.ToolStrip();
            this.welcomeMessage = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.attendanceList = new System.Windows.Forms.DataGridView();
            this.meetingCombobox = new System.Windows.Forms.ComboBox();
            this.attendanceTab = new System.Windows.Forms.TabControl();
            this.addAttendanceTab = new System.Windows.Forms.TabPage();
            this.viewAttendanceTab = new System.Windows.Forms.TabPage();
            this.registerStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceList)).BeginInit();
            this.attendanceTab.SuspendLayout();
            this.addAttendanceTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerStrip
            // 
            this.registerStrip.BackColor = System.Drawing.Color.SkyBlue;
            this.registerStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.registerStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.registerStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeMessage});
            this.registerStrip.Location = new System.Drawing.Point(0, 0);
            this.registerStrip.Name = "registerStrip";
            this.registerStrip.Padding = new System.Windows.Forms.Padding(20, 0, 1, 0);
            this.registerStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.registerStrip.Size = new System.Drawing.Size(1326, 43);
            this.registerStrip.TabIndex = 5;
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
            this.welcomeMessage.Text = "Attendance Dashboard";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.meetingCombobox);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(192, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 92);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Attendance of Meeting Here: ";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.clearButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.clearButton.Location = new System.Drawing.Point(710, 46);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(153, 35);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(527, 46);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(153, 35);
            this.searchButton.TabIndex = 22;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Meeting Name: ";
            // 
            // attendanceList
            // 
            this.attendanceList.AllowUserToAddRows = false;
            this.attendanceList.AllowUserToDeleteRows = false;
            this.attendanceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.attendanceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.attendanceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceList.Location = new System.Drawing.Point(76, 137);
            this.attendanceList.Name = "attendanceList";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attendanceList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.attendanceList.RowTemplate.Height = 24;
            this.attendanceList.Size = new System.Drawing.Size(1124, 485);
            this.attendanceList.TabIndex = 26;
            // 
            // meetingCombobox
            // 
            this.meetingCombobox.FormattingEnabled = true;
            this.meetingCombobox.Location = new System.Drawing.Point(175, 50);
            this.meetingCombobox.Name = "meetingCombobox";
            this.meetingCombobox.Size = new System.Drawing.Size(315, 27);
            this.meetingCombobox.TabIndex = 24;
            // 
            // attendanceTab
            // 
            this.attendanceTab.Controls.Add(this.addAttendanceTab);
            this.attendanceTab.Controls.Add(this.viewAttendanceTab);
            this.attendanceTab.Location = new System.Drawing.Point(27, 61);
            this.attendanceTab.Name = "attendanceTab";
            this.attendanceTab.SelectedIndex = 0;
            this.attendanceTab.Size = new System.Drawing.Size(1287, 674);
            this.attendanceTab.TabIndex = 27;
            // 
            // addAttendanceTab
            // 
            this.addAttendanceTab.Controls.Add(this.groupBox1);
            this.addAttendanceTab.Controls.Add(this.attendanceList);
            this.addAttendanceTab.Location = new System.Drawing.Point(4, 25);
            this.addAttendanceTab.Name = "addAttendanceTab";
            this.addAttendanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.addAttendanceTab.Size = new System.Drawing.Size(1279, 645);
            this.addAttendanceTab.TabIndex = 0;
            this.addAttendanceTab.Text = "Add Attendance";
            this.addAttendanceTab.UseVisualStyleBackColor = true;
            // 
            // viewAttendanceTab
            // 
            this.viewAttendanceTab.Location = new System.Drawing.Point(4, 25);
            this.viewAttendanceTab.Name = "viewAttendanceTab";
            this.viewAttendanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewAttendanceTab.Size = new System.Drawing.Size(1279, 645);
            this.viewAttendanceTab.TabIndex = 1;
            this.viewAttendanceTab.Text = "View Attendance";
            this.viewAttendanceTab.UseVisualStyleBackColor = true;
            // 
            // AttendanceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 754);
            this.Controls.Add(this.attendanceTab);
            this.Controls.Add(this.registerStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AttendanceManagement";
            this.Text = "AttendanceManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.registerStrip.ResumeLayout(false);
            this.registerStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceList)).EndInit();
            this.attendanceTab.ResumeLayout(false);
            this.addAttendanceTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip registerStrip;
        private System.Windows.Forms.ToolStripLabel welcomeMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView attendanceList;
        private System.Windows.Forms.ComboBox meetingCombobox;
        private System.Windows.Forms.TabControl attendanceTab;
        private System.Windows.Forms.TabPage addAttendanceTab;
        private System.Windows.Forms.TabPage viewAttendanceTab;
    }
}