namespace membership_system
{
    partial class Login
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
            this.loginStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.signInGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.signUpGroupbox = new System.Windows.Forms.GroupBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginStrip.SuspendLayout();
            this.signInGroupBox.SuspendLayout();
            this.signUpGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginStrip
            // 
            this.loginStrip.BackColor = System.Drawing.Color.SkyBlue;
            this.loginStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.loginStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.loginStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.loginStrip.Location = new System.Drawing.Point(0, 0);
            this.loginStrip.Name = "loginStrip";
            this.loginStrip.Padding = new System.Windows.Forms.Padding(150, 0, 1, 0);
            this.loginStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.loginStrip.Size = new System.Drawing.Size(538, 43);
            this.loginStrip.TabIndex = 0;
            this.loginStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(202, 40);
            this.toolStripLabel1.Text = "Membership System";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(32, 70);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(84, 17);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username: ";
            // 
            // signInGroupBox
            // 
            this.signInGroupBox.BackColor = System.Drawing.Color.Gainsboro;
            this.signInGroupBox.Controls.Add(this.passwordLabel);
            this.signInGroupBox.Controls.Add(this.signInButton);
            this.signInGroupBox.Controls.Add(this.passwordTextbox);
            this.signInGroupBox.Controls.Add(this.usernameTextbox);
            this.signInGroupBox.Controls.Add(this.usernameLabel);
            this.signInGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInGroupBox.Location = new System.Drawing.Point(62, 78);
            this.signInGroupBox.Name = "signInGroupBox";
            this.signInGroupBox.Size = new System.Drawing.Size(412, 211);
            this.signInGroupBox.TabIndex = 3;
            this.signInGroupBox.TabStop = false;
            this.signInGroupBox.Text = "Sign In with your membership account";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(32, 111);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(82, 17);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password: ";
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.signInButton.Location = new System.Drawing.Point(22, 153);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(365, 38);
            this.signInButton.TabIndex = 6;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(124, 108);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(224, 25);
            this.passwordTextbox.TabIndex = 5;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(124, 67);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(224, 25);
            this.usernameTextbox.TabIndex = 4;
            // 
            // signUpGroupbox
            // 
            this.signUpGroupbox.BackColor = System.Drawing.Color.Gainsboro;
            this.signUpGroupbox.Controls.Add(this.registerButton);
            this.signUpGroupbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.signUpGroupbox.Location = new System.Drawing.Point(62, 312);
            this.signUpGroupbox.Name = "signUpGroupbox";
            this.signUpGroupbox.Size = new System.Drawing.Size(412, 93);
            this.signUpGroupbox.TabIndex = 4;
            this.signUpGroupbox.TabStop = false;
            this.signUpGroupbox.Text = "Register your account here ";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.registerButton.Location = new System.Drawing.Point(22, 35);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(365, 38);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(538, 442);
            this.Controls.Add(this.signUpGroupbox);
            this.Controls.Add(this.signInGroupBox);
            this.Controls.Add(this.loginStrip);
            this.Name = "Login";
            this.Text = "Login";
            this.loginStrip.ResumeLayout(false);
            this.loginStrip.PerformLayout();
            this.signInGroupBox.ResumeLayout(false);
            this.signInGroupBox.PerformLayout();
            this.signUpGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip loginStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.GroupBox signInGroupBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.GroupBox signUpGroupbox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label passwordLabel;
    }
}