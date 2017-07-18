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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.registerStrip = new System.Windows.Forms.ToolStrip();
            this.welcomeMessage = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.meetingCombobox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.attendanceList = new System.Windows.Forms.DataGridView();
            this.attendanceTab = new System.Windows.Forms.TabControl();
            this.addAttendanceTab = new System.Windows.Forms.TabPage();
            this.submitButton = new System.Windows.Forms.Button();
            this.viewAttendanceTab = new System.Windows.Forms.TabPage();
            this.attendanceList1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.meetingCombobox1 = new System.Windows.Forms.ComboBox();
            this.searchButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.registerStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceList)).BeginInit();
            this.attendanceTab.SuspendLayout();
            this.addAttendanceTab.SuspendLayout();
            this.viewAttendanceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceList1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.registerStrip.Size = new System.Drawing.Size(1214, 43);
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
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(192, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 92);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search member add into Meeting here: ";
            // 
            // meetingCombobox
            // 
            this.meetingCombobox.FormattingEnabled = true;
            this.meetingCombobox.Location = new System.Drawing.Point(175, 50);
            this.meetingCombobox.Name = "meetingCombobox";
            this.meetingCombobox.Size = new System.Drawing.Size(315, 27);
            this.meetingCombobox.TabIndex = 24;
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
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
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
            this.attendanceList.Location = new System.Drawing.Point(176, 133);
            this.attendanceList.Name = "attendanceList";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attendanceList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.attendanceList.RowTemplate.Height = 24;
            this.attendanceList.Size = new System.Drawing.Size(760, 485);
            this.attendanceList.TabIndex = 26;
            // 
            // attendanceTab
            // 
            this.attendanceTab.Controls.Add(this.addAttendanceTab);
            this.attendanceTab.Controls.Add(this.viewAttendanceTab);
            this.attendanceTab.Location = new System.Drawing.Point(27, 61);
            this.attendanceTab.Name = "attendanceTab";
            this.attendanceTab.SelectedIndex = 0;
            this.attendanceTab.Size = new System.Drawing.Size(1132, 737);
            this.attendanceTab.TabIndex = 27;
            // 
            // addAttendanceTab
            // 
            this.addAttendanceTab.Controls.Add(this.submitButton);
            this.addAttendanceTab.Controls.Add(this.groupBox1);
            this.addAttendanceTab.Controls.Add(this.attendanceList);
            this.addAttendanceTab.Location = new System.Drawing.Point(4, 25);
            this.addAttendanceTab.Name = "addAttendanceTab";
            this.addAttendanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.addAttendanceTab.Size = new System.Drawing.Size(1124, 708);
            this.addAttendanceTab.TabIndex = 0;
            this.addAttendanceTab.Text = "Add Attendance";
            this.addAttendanceTab.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.submitButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(386, 644);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(296, 45);
            this.submitButton.TabIndex = 25;
            this.submitButton.Text = "Submit Attendance";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // viewAttendanceTab
            // 
            this.viewAttendanceTab.Controls.Add(this.attendanceList1);
            this.viewAttendanceTab.Controls.Add(this.groupBox2);
            this.viewAttendanceTab.Location = new System.Drawing.Point(4, 25);
            this.viewAttendanceTab.Name = "viewAttendanceTab";
            this.viewAttendanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewAttendanceTab.Size = new System.Drawing.Size(1124, 708);
            this.viewAttendanceTab.TabIndex = 1;
            this.viewAttendanceTab.Text = "View Attendance";
            this.viewAttendanceTab.UseVisualStyleBackColor = true;
            // 
            // attendanceList1
            // 
            this.attendanceList1.AllowUserToAddRows = false;
            this.attendanceList1.AllowUserToDeleteRows = false;
            this.attendanceList1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.attendanceList1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.attendanceList1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceList1.Location = new System.Drawing.Point(180, 131);
            this.attendanceList1.Name = "attendanceList1";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attendanceList1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.attendanceList1.RowTemplate.Height = 24;
            this.attendanceList1.Size = new System.Drawing.Size(760, 553);
            this.attendanceList1.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.meetingCombobox1);
            this.groupBox2.Controls.Add(this.searchButton1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(196, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 92);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Attendance List Here: ";
            // 
            // meetingCombobox1
            // 
            this.meetingCombobox1.FormattingEnabled = true;
            this.meetingCombobox1.Location = new System.Drawing.Point(175, 50);
            this.meetingCombobox1.Name = "meetingCombobox1";
            this.meetingCombobox1.Size = new System.Drawing.Size(315, 27);
            this.meetingCombobox1.TabIndex = 24;
            // 
            // searchButton1
            // 
            this.searchButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchButton1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton1.Location = new System.Drawing.Point(527, 46);
            this.searchButton1.Name = "searchButton1";
            this.searchButton1.Size = new System.Drawing.Size(153, 35);
            this.searchButton1.TabIndex = 22;
            this.searchButton1.Text = "Search";
            this.searchButton1.UseVisualStyleBackColor = false;
            this.searchButton1.Click += new System.EventHandler(this.searchButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Meeting Name: ";
            // 
            // AttendanceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 810);
            this.Controls.Add(this.attendanceTab);
            this.Controls.Add(this.registerStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AttendanceManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceManagement";
            this.registerStrip.ResumeLayout(false);
            this.registerStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceList)).EndInit();
            this.attendanceTab.ResumeLayout(false);
            this.addAttendanceTab.ResumeLayout(false);
            this.viewAttendanceTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceList1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip registerStrip;
        private System.Windows.Forms.ToolStripLabel welcomeMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView attendanceList;
        private System.Windows.Forms.ComboBox meetingCombobox;
        private System.Windows.Forms.TabControl attendanceTab;
        private System.Windows.Forms.TabPage addAttendanceTab;
        private System.Windows.Forms.TabPage viewAttendanceTab;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox meetingCombobox1;
        private System.Windows.Forms.Button searchButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView attendanceList1;
    }
}