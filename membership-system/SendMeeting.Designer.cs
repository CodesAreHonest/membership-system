namespace membership_system
{
    partial class SendMeeting
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
            this.registerStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.meetingGroupbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailComboBox = new System.Windows.Forms.ComboBox();
            this.createButton = new System.Windows.Forms.Button();
            this.registerStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerStrip
            // 
            this.registerStrip.BackColor = System.Drawing.Color.SkyBlue;
            this.registerStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.registerStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.registerStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStripLabel});
            this.registerStrip.Location = new System.Drawing.Point(0, 0);
            this.registerStrip.Name = "registerStrip";
            this.registerStrip.Padding = new System.Windows.Forms.Padding(20, 0, 1, 0);
            this.registerStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.registerStrip.Size = new System.Drawing.Size(908, 43);
            this.registerStrip.TabIndex = 7;
            this.registerStrip.Text = "toolStrip1";
            // 
            // registerStripLabel
            // 
            this.registerStripLabel.AutoSize = false;
            this.registerStripLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.registerStripLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.registerStripLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registerStripLabel.Name = "registerStripLabel";
            this.registerStripLabel.Size = new System.Drawing.Size(202, 40);
            this.registerStripLabel.Text = "Membership System";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.Location = new System.Drawing.Point(30, 79);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(107, 17);
            this.fullnameLabel.TabIndex = 8;
            this.fullnameLabel.Text = "Meeting name: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 364);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invitation Message";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(806, 312);
            this.textBox1.TabIndex = 0;
            // 
            // meetingGroupbox
            // 
            this.meetingGroupbox.FormattingEnabled = true;
            this.meetingGroupbox.Location = new System.Drawing.Point(144, 79);
            this.meetingGroupbox.Name = "meetingGroupbox";
            this.meetingGroupbox.Size = new System.Drawing.Size(264, 24);
            this.meetingGroupbox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email: ";
            // 
            // emailComboBox
            // 
            this.emailComboBox.FormattingEnabled = true;
            this.emailComboBox.Location = new System.Drawing.Point(501, 79);
            this.emailComboBox.Name = "emailComboBox";
            this.emailComboBox.Size = new System.Drawing.Size(264, 24);
            this.emailComboBox.TabIndex = 13;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.createButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(262, 509);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(347, 49);
            this.createButton.TabIndex = 14;
            this.createButton.Text = "Send";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // SendMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 570);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.emailComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.meetingGroupbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.registerStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SendMeeting";
            this.Text = "SendMeeting";
            this.registerStrip.ResumeLayout(false);
            this.registerStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip registerStrip;
        private System.Windows.Forms.ToolStripLabel registerStripLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox meetingGroupbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox emailComboBox;
        private System.Windows.Forms.Button createButton;
    }
}