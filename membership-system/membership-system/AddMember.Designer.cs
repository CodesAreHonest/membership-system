namespace membership_system
{
    partial class AddMember
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.intakeCodeTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studenthpTextbox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.studentGenderCombobox = new System.Windows.Forms.ComboBox();
            this.studentEmailTextbox = new System.Windows.Forms.TextBox();
            this.studentNameTextbox = new System.Windows.Forms.TextBox();
            this.pocLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
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
            this.registerStrip.Size = new System.Drawing.Size(661, 43);
            this.registerStrip.TabIndex = 3;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.intakeCodeTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.studenthpTextbox);
            this.groupBox1.Controls.Add(this.registerButton);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.genderLabel);
            this.groupBox1.Controls.Add(this.studentGenderCombobox);
            this.groupBox1.Controls.Add(this.studentEmailTextbox);
            this.groupBox1.Controls.Add(this.studentNameTextbox);
            this.groupBox1.Controls.Add(this.pocLabel);
            this.groupBox1.Controls.Add(this.fullnameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(28, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 438);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fill in student details here";
            // 
            // intakeCodeTextbox
            // 
            this.intakeCodeTextbox.Location = new System.Drawing.Point(215, 257);
            this.intakeCodeTextbox.Name = "intakeCodeTextbox";
            this.intakeCodeTextbox.Size = new System.Drawing.Size(297, 24);
            this.intakeCodeTextbox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Intake Code: ";
            // 
            // studenthpTextbox
            // 
            this.studenthpTextbox.Location = new System.Drawing.Point(215, 99);
            this.studenthpTextbox.Name = "studenthpTextbox";
            this.studenthpTextbox.Size = new System.Drawing.Size(297, 24);
            this.studenthpTextbox.TabIndex = 17;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.registerButton.Location = new System.Drawing.Point(97, 344);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(347, 49);
            this.registerButton.TabIndex = 1;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(24, 153);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 17);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Email: ";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(24, 206);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(64, 17);
            this.genderLabel.TabIndex = 15;
            this.genderLabel.Text = "Gender: ";
            // 
            // studentGenderCombobox
            // 
            this.studentGenderCombobox.FormattingEnabled = true;
            this.studentGenderCombobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.studentGenderCombobox.Location = new System.Drawing.Point(215, 203);
            this.studentGenderCombobox.Name = "studentGenderCombobox";
            this.studentGenderCombobox.Size = new System.Drawing.Size(297, 24);
            this.studentGenderCombobox.TabIndex = 12;
            this.studentGenderCombobox.Text = "Male";
            // 
            // studentEmailTextbox
            // 
            this.studentEmailTextbox.Location = new System.Drawing.Point(215, 150);
            this.studentEmailTextbox.Name = "studentEmailTextbox";
            this.studentEmailTextbox.Size = new System.Drawing.Size(297, 24);
            this.studentEmailTextbox.TabIndex = 9;
            // 
            // studentNameTextbox
            // 
            this.studentNameTextbox.Location = new System.Drawing.Point(215, 50);
            this.studentNameTextbox.Name = "studentNameTextbox";
            this.studentNameTextbox.Size = new System.Drawing.Size(297, 24);
            this.studentNameTextbox.TabIndex = 6;
            // 
            // pocLabel
            // 
            this.pocLabel.AutoSize = true;
            this.pocLabel.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pocLabel.ForeColor = System.Drawing.Color.Black;
            this.pocLabel.Location = new System.Drawing.Point(24, 102);
            this.pocLabel.Name = "pocLabel";
            this.pocLabel.Size = new System.Drawing.Size(90, 17);
            this.pocLabel.TabIndex = 5;
            this.pocLabel.Text = "Handphone: ";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.Location = new System.Drawing.Point(24, 50);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(80, 17);
            this.fullnameLabel.TabIndex = 0;
            this.fullnameLabel.Text = "Full name: ";
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.registerStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddMember";
            this.Text = "Add Member";
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox studenthpTextbox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox studentGenderCombobox;
        private System.Windows.Forms.TextBox studentEmailTextbox;
        private System.Windows.Forms.TextBox studentNameTextbox;
        private System.Windows.Forms.Label pocLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.TextBox intakeCodeTextbox;
        private System.Windows.Forms.Label label1;
    }
}