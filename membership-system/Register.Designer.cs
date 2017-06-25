namespace membership_system
{
    partial class Register
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
            this.registerButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createClubButton = new System.Windows.Forms.Button();
            this.genderCombobox = new System.Windows.Forms.ComboBox();
            this.posCombobox = new System.Windows.Forms.ComboBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.retypepwTextbox = new System.Windows.Forms.TextBox();
            this.pwTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.pocLabel = new System.Windows.Forms.Label();
            this.retypePwLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.registerStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.registerStripLabel});
            this.registerStrip.Location = new System.Drawing.Point(0, 0);
            this.registerStrip.Name = "registerStrip";
            this.registerStrip.Padding = new System.Windows.Forms.Padding(20, 0, 1, 0);
            this.registerStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.registerStrip.Size = new System.Drawing.Size(1078, 43);
            this.registerStrip.TabIndex = 1;
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
            this.registerStripLabel.Click += new System.EventHandler(this.registerStripLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registerButton);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.genderLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.genderCombobox);
            this.groupBox1.Controls.Add(this.posCombobox);
            this.groupBox1.Controls.Add(this.emailTextbox);
            this.groupBox1.Controls.Add(this.retypepwTextbox);
            this.groupBox1.Controls.Add(this.pwTextbox);
            this.groupBox1.Controls.Add(this.nameTextbox);
            this.groupBox1.Controls.Add(this.pocLabel);
            this.groupBox1.Controls.Add(this.retypePwLabel);
            this.groupBox1.Controls.Add(this.pwLabel);
            this.groupBox1.Controls.Add(this.fullnameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(38, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 385);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fill in your details here";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.registerButton.Location = new System.Drawing.Point(331, 304);
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
            this.genderLabel.Location = new System.Drawing.Point(24, 188);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(64, 17);
            this.genderLabel.TabIndex = 15;
            this.genderLabel.Text = "Gender: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(586, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(306, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Can\'t find your society? Create one here ! ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.createClubButton);
            this.groupBox2.Location = new System.Drawing.Point(557, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 119);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create your club here: ";
            // 
            // createClubButton
            // 
            this.createClubButton.BackColor = System.Drawing.Color.LightBlue;
            this.createClubButton.Location = new System.Drawing.Point(21, 49);
            this.createClubButton.Name = "createClubButton";
            this.createClubButton.Size = new System.Drawing.Size(347, 49);
            this.createClubButton.TabIndex = 0;
            this.createClubButton.Text = "Create";
            this.createClubButton.UseVisualStyleBackColor = false;
            this.createClubButton.Click += new System.EventHandler(this.createClubButton_Click);
            // 
            // genderCombobox
            // 
            this.genderCombobox.FormattingEnabled = true;
            this.genderCombobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCombobox.Location = new System.Drawing.Point(215, 185);
            this.genderCombobox.Name = "genderCombobox";
            this.genderCombobox.Size = new System.Drawing.Size(297, 24);
            this.genderCombobox.TabIndex = 12;
            // 
            // posCombobox
            // 
            this.posCombobox.FormattingEnabled = true;
            this.posCombobox.Location = new System.Drawing.Point(710, 50);
            this.posCombobox.Name = "posCombobox";
            this.posCombobox.Size = new System.Drawing.Size(243, 24);
            this.posCombobox.TabIndex = 11;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(215, 231);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(297, 24);
            this.emailTextbox.TabIndex = 9;
            // 
            // retypepwTextbox
            // 
            this.retypepwTextbox.Location = new System.Drawing.Point(215, 138);
            this.retypepwTextbox.Name = "retypepwTextbox";
            this.retypepwTextbox.Size = new System.Drawing.Size(297, 24);
            this.retypepwTextbox.TabIndex = 8;
            // 
            // pwTextbox
            // 
            this.pwTextbox.Location = new System.Drawing.Point(215, 91);
            this.pwTextbox.Name = "pwTextbox";
            this.pwTextbox.Size = new System.Drawing.Size(297, 24);
            this.pwTextbox.TabIndex = 7;
            this.pwTextbox.TextChanged += new System.EventHandler(this.pwTextbox_TextChanged);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(215, 50);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(297, 24);
            this.nameTextbox.TabIndex = 6;
            // 
            // pocLabel
            // 
            this.pocLabel.AutoSize = true;
            this.pocLabel.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pocLabel.ForeColor = System.Drawing.Color.Black;
            this.pocLabel.Location = new System.Drawing.Point(542, 53);
            this.pocLabel.Name = "pocLabel";
            this.pocLabel.Size = new System.Drawing.Size(146, 17);
            this.pocLabel.TabIndex = 5;
            this.pocLabel.Text = "President of Society: ";
            // 
            // retypePwLabel
            // 
            this.retypePwLabel.AutoSize = true;
            this.retypePwLabel.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypePwLabel.Location = new System.Drawing.Point(24, 141);
            this.retypePwLabel.Name = "retypePwLabel";
            this.retypePwLabel.Size = new System.Drawing.Size(162, 17);
            this.retypePwLabel.TabIndex = 2;
            this.retypePwLabel.Text = "Retype your password: ";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwLabel.Location = new System.Drawing.Point(24, 94);
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
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.backButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(956, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(122, 31);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.refreshButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(808, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(122, 31);
            this.refreshButton.TabIndex = 18;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 486);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.registerStrip);
            this.Name = "Register";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Register_Load);
            this.registerStrip.ResumeLayout(false);
            this.registerStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip registerStrip;
        private System.Windows.Forms.ToolStripLabel registerStripLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox posCombobox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox retypepwTextbox;
        private System.Windows.Forms.TextBox pwTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label pocLabel;
        private System.Windows.Forms.Label retypePwLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.ComboBox genderCombobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Button createClubButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button refreshButton;
    }
}