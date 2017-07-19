namespace membership_system
{
    partial class UserEditAccount
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
            this.editPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderCombobox = new System.Windows.Forms.ComboBox();
            this.updateEmailTextbox = new System.Windows.Forms.TextBox();
            this.pwTextbox = new System.Windows.Forms.TextBox();
            this.updateNameTextbox = new System.Windows.Forms.TextBox();
            this.pwLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.email = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.registerStrip.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.viewPanel.SuspendLayout();
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
            this.registerStrip.Size = new System.Drawing.Size(596, 40);
            this.registerStrip.TabIndex = 3;
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
            // editPanel
            // 
            this.editPanel.Controls.Add(this.groupBox1);
            this.editPanel.Location = new System.Drawing.Point(0, 46);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(576, 420);
            this.editPanel.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.genderLabel);
            this.groupBox1.Controls.Add(this.genderCombobox);
            this.groupBox1.Controls.Add(this.updateEmailTextbox);
            this.groupBox1.Controls.Add(this.pwTextbox);
            this.groupBox1.Controls.Add(this.updateNameTextbox);
            this.groupBox1.Controls.Add(this.pwLabel);
            this.groupBox1.Controls.Add(this.fullnameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 376);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fill in your details here";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updateButton.Location = new System.Drawing.Point(111, 298);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(347, 49);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(24, 234);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 17);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Email: ";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(24, 169);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(64, 17);
            this.genderLabel.TabIndex = 15;
            this.genderLabel.Text = "Gender: ";
            // 
            // genderCombobox
            // 
            this.genderCombobox.FormattingEnabled = true;
            this.genderCombobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCombobox.Location = new System.Drawing.Point(215, 169);
            this.genderCombobox.Name = "genderCombobox";
            this.genderCombobox.Size = new System.Drawing.Size(297, 24);
            this.genderCombobox.TabIndex = 12;
            // 
            // updateEmailTextbox
            // 
            this.updateEmailTextbox.Location = new System.Drawing.Point(215, 231);
            this.updateEmailTextbox.Name = "updateEmailTextbox";
            this.updateEmailTextbox.Size = new System.Drawing.Size(297, 24);
            this.updateEmailTextbox.TabIndex = 9;
            // 
            // pwTextbox
            // 
            this.pwTextbox.Location = new System.Drawing.Point(215, 101);
            this.pwTextbox.Name = "pwTextbox";
            this.pwTextbox.Size = new System.Drawing.Size(297, 24);
            this.pwTextbox.TabIndex = 7;
            // 
            // updateNameTextbox
            // 
            this.updateNameTextbox.Location = new System.Drawing.Point(215, 50);
            this.updateNameTextbox.Name = "updateNameTextbox";
            this.updateNameTextbox.Size = new System.Drawing.Size(297, 24);
            this.updateNameTextbox.TabIndex = 6;
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwLabel.Location = new System.Drawing.Point(24, 108);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(82, 17);
            this.pwLabel.TabIndex = 1;
            this.pwLabel.Text = "Password: ";
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
            // viewPanel
            // 
            this.viewPanel.Controls.Add(this.groupBox2);
            this.viewPanel.Location = new System.Drawing.Point(3, 46);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(576, 420);
            this.viewPanel.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.gender);
            this.groupBox2.Controls.Add(this.pw);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Controls.Add(this.editButton);
            this.groupBox2.Controls.Add(this.okButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(24, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 376);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account information";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(111, 233);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(13, 18);
            this.email.TabIndex = 21;
            this.email.Text = "-";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(113, 174);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(13, 18);
            this.gender.TabIndex = 20;
            this.gender.Text = "-";
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Location = new System.Drawing.Point(113, 114);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(13, 18);
            this.pw.TabIndex = 19;
            this.pw.Text = "-";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(111, 50);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(13, 18);
            this.name.TabIndex = 18;
            this.name.Text = "-";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editButton.Location = new System.Drawing.Point(56, 308);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(208, 49);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.okButton.Location = new System.Drawing.Point(290, 308);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(208, 49);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Email: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gender: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Full name: ";
            // 
            // UserEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 466);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.registerStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UserEditAccount";
            this.Text = "UserEditAccount";
            this.Load += new System.EventHandler(this.UserEditAccount_Load);
            this.registerStrip.ResumeLayout(false);
            this.registerStrip.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.viewPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip registerStrip;
        private System.Windows.Forms.ToolStripLabel welcomeMessage;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderCombobox;
        private System.Windows.Forms.TextBox updateEmailTextbox;
        private System.Windows.Forms.TextBox pwTextbox;
        private System.Windows.Forms.TextBox updateNameTextbox;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.Label name;
    }
}