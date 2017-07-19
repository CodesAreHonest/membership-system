namespace membership_system
{
    partial class ClubRegistration
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
            this.createButton = new System.Windows.Forms.Button();
            this.societyDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.societyFeesTextbox = new System.Windows.Forms.TextBox();
            this.societyNameTextbox = new System.Windows.Forms.TextBox();
            this.retypePwLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
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
            this.registerStrip.Size = new System.Drawing.Size(622, 43);
            this.registerStrip.TabIndex = 2;
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
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.societyDescriptionTextbox);
            this.groupBox1.Controls.Add(this.societyFeesTextbox);
            this.groupBox1.Controls.Add(this.societyNameTextbox);
            this.groupBox1.Controls.Add(this.retypePwLabel);
            this.groupBox1.Controls.Add(this.pwLabel);
            this.groupBox1.Controls.Add(this.fullnameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(36, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 451);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fill in society details here";
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.createButton.Location = new System.Drawing.Point(101, 382);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(347, 49);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // societyDescriptionTextbox
            // 
            this.societyDescriptionTextbox.Location = new System.Drawing.Point(27, 179);
            this.societyDescriptionTextbox.Multiline = true;
            this.societyDescriptionTextbox.Name = "societyDescriptionTextbox";
            this.societyDescriptionTextbox.Size = new System.Drawing.Size(485, 181);
            this.societyDescriptionTextbox.TabIndex = 8;
            // 
            // societyFeesTextbox
            // 
            this.societyFeesTextbox.Location = new System.Drawing.Point(215, 91);
            this.societyFeesTextbox.Name = "societyFeesTextbox";
            this.societyFeesTextbox.Size = new System.Drawing.Size(297, 24);
            this.societyFeesTextbox.TabIndex = 7;
            this.societyFeesTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.societyFeesTextbox_KeyPress);
            // 
            // societyNameTextbox
            // 
            this.societyNameTextbox.Location = new System.Drawing.Point(215, 50);
            this.societyNameTextbox.Name = "societyNameTextbox";
            this.societyNameTextbox.Size = new System.Drawing.Size(297, 24);
            this.societyNameTextbox.TabIndex = 6;
            // 
            // retypePwLabel
            // 
            this.retypePwLabel.AutoSize = true;
            this.retypePwLabel.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypePwLabel.Location = new System.Drawing.Point(24, 141);
            this.retypePwLabel.Name = "retypePwLabel";
            this.retypePwLabel.Size = new System.Drawing.Size(250, 17);
            this.retypePwLabel.TabIndex = 2;
            this.retypePwLabel.Text = "Society Description: (Max 255 words)";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwLabel.Location = new System.Drawing.Point(24, 94);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(96, 17);
            this.pwLabel.TabIndex = 1;
            this.pwLabel.Text = "Society fees: ";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.Location = new System.Drawing.Point(24, 50);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(105, 17);
            this.fullnameLabel.TabIndex = 0;
            this.fullnameLabel.Text = "Society name: ";
            // 
            // ClubRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.registerStrip);
            this.Name = "ClubRegistration";
            this.Text = "Create Society";
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
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox societyDescriptionTextbox;
        private System.Windows.Forms.TextBox societyFeesTextbox;
        private System.Windows.Forms.TextBox societyNameTextbox;
        private System.Windows.Forms.Label retypePwLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Label fullnameLabel;
    }
}