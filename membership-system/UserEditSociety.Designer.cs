namespace membership_system
{
    partial class UserEditSociety
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
            this.editPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.societyDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.societyFeesTextbox = new System.Windows.Forms.TextBox();
            this.societyNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateSocietyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.societyDescription = new System.Windows.Forms.Label();
            this.societyFees = new System.Windows.Forms.Label();
            this.societyName = new System.Windows.Forms.Label();
            this.editSocietyButton = new System.Windows.Forms.Button();
            this.okSocietyButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.registerStrip = new System.Windows.Forms.ToolStrip();
            this.welcomeMessage = new System.Windows.Forms.ToolStripLabel();
            this.editPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.registerStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.groupBox2);
            this.editPanel.Location = new System.Drawing.Point(42, 43);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(576, 455);
            this.editPanel.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.societyDescriptionTextbox);
            this.groupBox2.Controls.Add(this.societyFeesTextbox);
            this.groupBox2.Controls.Add(this.societyNameTextbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.updateSocietyButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(24, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 417);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Society Details here";
            // 
            // societyDescriptionTextbox
            // 
            this.societyDescriptionTextbox.Location = new System.Drawing.Point(25, 157);
            this.societyDescriptionTextbox.Multiline = true;
            this.societyDescriptionTextbox.Name = "societyDescriptionTextbox";
            this.societyDescriptionTextbox.Size = new System.Drawing.Size(472, 176);
            this.societyDescriptionTextbox.TabIndex = 21;
            // 
            // societyFeesTextbox
            // 
            this.societyFeesTextbox.Location = new System.Drawing.Point(133, 90);
            this.societyFeesTextbox.Name = "societyFeesTextbox";
            this.societyFeesTextbox.Size = new System.Drawing.Size(348, 24);
            this.societyFeesTextbox.TabIndex = 20;
            // 
            // societyNameTextbox
            // 
            this.societyNameTextbox.Location = new System.Drawing.Point(133, 47);
            this.societyNameTextbox.Name = "societyNameTextbox";
            this.societyNameTextbox.Size = new System.Drawing.Size(348, 24);
            this.societyNameTextbox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Society name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Description: (Max 255 Words)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // updateSocietyButton
            // 
            this.updateSocietyButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updateSocietyButton.Location = new System.Drawing.Point(110, 355);
            this.updateSocietyButton.Name = "updateSocietyButton";
            this.updateSocietyButton.Size = new System.Drawing.Size(323, 49);
            this.updateSocietyButton.TabIndex = 1;
            this.updateSocietyButton.Text = "Update";
            this.updateSocietyButton.UseVisualStyleBackColor = false;
            this.updateSocietyButton.Click += new System.EventHandler(this.updateSocietyButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Society fees: ";
            // 
            // viewPanel
            // 
            this.viewPanel.Controls.Add(this.groupBox1);
            this.viewPanel.Location = new System.Drawing.Point(45, 40);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(576, 455);
            this.viewPanel.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.societyDescription);
            this.groupBox1.Controls.Add(this.societyFees);
            this.groupBox1.Controls.Add(this.societyName);
            this.groupBox1.Controls.Add(this.editSocietyButton);
            this.groupBox1.Controls.Add(this.okSocietyButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(24, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 417);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Society Information";
            // 
            // societyDescription
            // 
            this.societyDescription.AutoSize = true;
            this.societyDescription.Location = new System.Drawing.Point(24, 170);
            this.societyDescription.Name = "societyDescription";
            this.societyDescription.Size = new System.Drawing.Size(13, 18);
            this.societyDescription.TabIndex = 20;
            this.societyDescription.Text = "-";
            // 
            // societyFees
            // 
            this.societyFees.AutoSize = true;
            this.societyFees.Location = new System.Drawing.Point(150, 93);
            this.societyFees.Name = "societyFees";
            this.societyFees.Size = new System.Drawing.Size(13, 18);
            this.societyFees.TabIndex = 19;
            this.societyFees.Text = "-";
            // 
            // societyName
            // 
            this.societyName.AutoSize = true;
            this.societyName.Location = new System.Drawing.Point(150, 51);
            this.societyName.Name = "societyName";
            this.societyName.Size = new System.Drawing.Size(13, 18);
            this.societyName.TabIndex = 18;
            this.societyName.Text = "-";
            // 
            // editSocietyButton
            // 
            this.editSocietyButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editSocietyButton.Location = new System.Drawing.Point(47, 349);
            this.editSocietyButton.Name = "editSocietyButton";
            this.editSocietyButton.Size = new System.Drawing.Size(208, 49);
            this.editSocietyButton.TabIndex = 17;
            this.editSocietyButton.Text = "Edit";
            this.editSocietyButton.UseVisualStyleBackColor = false;
            this.editSocietyButton.Click += new System.EventHandler(this.editSocietyButton_Click);
            // 
            // okSocietyButton
            // 
            this.okSocietyButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.okSocietyButton.Location = new System.Drawing.Point(281, 349);
            this.okSocietyButton.Name = "okSocietyButton";
            this.okSocietyButton.Size = new System.Drawing.Size(208, 49);
            this.okSocietyButton.TabIndex = 1;
            this.okSocietyButton.Text = "OK";
            this.okSocietyButton.UseVisualStyleBackColor = false;
            this.okSocietyButton.Click += new System.EventHandler(this.okSocietyButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Description: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Society fees: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Society name: ";
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
            this.registerStrip.Size = new System.Drawing.Size(644, 40);
            this.registerStrip.TabIndex = 9;
            this.registerStrip.Text = "toolStrip1";
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.AutoSize = false;
            this.welcomeMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.welcomeMessage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.welcomeMessage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.welcomeMessage.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(250, 40);
            this.welcomeMessage.Text = "Membership System";
            // 
            // UserEditSociety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 514);
            this.Controls.Add(this.registerStrip);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.editPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UserEditSociety";
            this.Text = "UserEditSociety";
            this.Load += new System.EventHandler(this.UserEditSociety_Load);
            this.editPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.viewPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.registerStrip.ResumeLayout(false);
            this.registerStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateSocietyButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button okSocietyButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip registerStrip;
        private System.Windows.Forms.ToolStripLabel welcomeMessage;
        private System.Windows.Forms.Button editSocietyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox societyDescriptionTextbox;
        private System.Windows.Forms.TextBox societyFeesTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label societyFees;
        private System.Windows.Forms.Label societyName;
        private System.Windows.Forms.Label societyDescription;
        private System.Windows.Forms.TextBox societyNameTextbox;
    }
}