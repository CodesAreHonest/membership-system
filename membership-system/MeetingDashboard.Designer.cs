namespace membership_system
{
    partial class MeetingDashboard
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
            this.registerStrip = new System.Windows.Forms.ToolStrip();
            this.welcomeMessage = new System.Windows.Forms.ToolStripLabel();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.locationTextbox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.durationLabel = new System.Windows.Forms.Label();
            this.messageGroupbox = new System.Windows.Forms.GroupBox();
            this.messageText = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.meetingGridView = new System.Windows.Forms.DataGridView();
            this.registerStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.messageGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meetingGridView)).BeginInit();
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
            this.registerStrip.Size = new System.Drawing.Size(1927, 43);
            this.registerStrip.TabIndex = 4;
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
            this.welcomeMessage.Text = "Meeting Dashboard";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.clearButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.clearButton.Location = new System.Drawing.Point(652, 46);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(153, 35);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(483, 46);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(153, 35);
            this.searchButton.TabIndex = 22;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.Location = new System.Drawing.Point(166, 50);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(297, 27);
            this.searchTextbox.TabIndex = 22;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.searchTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(973, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 92);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Meeting Here: ";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.deleteButton.Location = new System.Drawing.Point(493, 507);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(180, 46);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(285, 507);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(180, 46);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Duration: ";
            // 
            // locationTextbox
            // 
            this.locationTextbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextbox.Location = new System.Drawing.Point(302, 100);
            this.locationTextbox.Name = "locationTextbox";
            this.locationTextbox.Size = new System.Drawing.Size(297, 27);
            this.locationTextbox.TabIndex = 17;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addButton.Location = new System.Drawing.Point(74, 507);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(180, 46);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Start Time: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "End Time: ";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.Location = new System.Drawing.Point(302, 48);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(297, 27);
            this.nameTextbox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(111, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Meeting Location: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Meeting name: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.startTimePicker);
            this.groupBox2.Controls.Add(this.endTimePicker);
            this.groupBox2.Controls.Add(this.descriptionTextbox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.datePicker);
            this.groupBox2.Controls.Add(this.durationLabel);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.locationTextbox);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nameTextbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(53, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 575);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meeting Details ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(139, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Meeting Date: ";
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "";
            this.startTimePicker.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(379, 198);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(175, 27);
            this.startTimePicker.TabIndex = 28;
            this.startTimePicker.Value = new System.DateTime(2017, 7, 14, 23, 15, 45, 0);
            this.startTimePicker.ValueChanged += new System.EventHandler(this.startTimePicker_ValueChanged);
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.endTimePicker.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(379, 247);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(175, 27);
            this.endTimePicker.TabIndex = 27;
            this.endTimePicker.Value = new System.DateTime(2017, 7, 14, 23, 15, 45, 0);
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextbox.Location = new System.Drawing.Point(245, 357);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(387, 115);
            this.descriptionTextbox.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Meeting Description: ";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "yyyy-mm-dd";
            this.datePicker.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(302, 151);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(364, 27);
            this.datePicker.TabIndex = 23;
            this.datePicker.Value = new System.DateTime(2017, 7, 14, 23, 15, 45, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel.Location = new System.Drawing.Point(299, 309);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(255, 19);
            this.durationLabel.TabIndex = 22;
            this.durationLabel.Text = "0 day 0 hour 0 minute 0 second";
            // 
            // messageGroupbox
            // 
            this.messageGroupbox.Controls.Add(this.messageText);
            this.messageGroupbox.Controls.Add(this.statusText);
            this.messageGroupbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageGroupbox.Location = new System.Drawing.Point(53, 809);
            this.messageGroupbox.Name = "messageGroupbox";
            this.messageGroupbox.Size = new System.Drawing.Size(753, 100);
            this.messageGroupbox.TabIndex = 26;
            this.messageGroupbox.TabStop = false;
            this.messageGroupbox.Text = "Message";
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageText.Location = new System.Drawing.Point(88, 47);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(15, 19);
            this.messageText.TabIndex = 23;
            this.messageText.Text = "-";
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.Location = new System.Drawing.Point(24, 47);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(64, 19);
            this.statusText.TabIndex = 22;
            this.statusText.Text = "Status: ";
            // 
            // meetingGridView
            // 
            this.meetingGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.meetingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meetingGridView.Location = new System.Drawing.Point(877, 206);
            this.meetingGridView.Name = "meetingGridView";
            this.meetingGridView.RowTemplate.Height = 24;
            this.meetingGridView.Size = new System.Drawing.Size(1008, 667);
            this.meetingGridView.TabIndex = 10;
            this.meetingGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.meetingGridView_RowHeaderMouseClick);
            // 
            // MeetingDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1927, 944);
            this.Controls.Add(this.meetingGridView);
            this.Controls.Add(this.messageGroupbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.registerStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MeetingDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membership System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MeetingDashboard_Load);
            this.registerStrip.ResumeLayout(false);
            this.registerStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.messageGroupbox.ResumeLayout(false);
            this.messageGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meetingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip registerStrip;
        private System.Windows.Forms.ToolStripLabel welcomeMessage;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox locationTextbox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.GroupBox messageGroupbox;
        private System.Windows.Forms.Label messageText;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.DataGridView meetingGridView;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label label7;
    }
}