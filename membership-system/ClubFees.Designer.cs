namespace membership_system
{
    partial class clubFees
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
            this.memberGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.feesGroupbox = new System.Windows.Forms.GroupBox();
            this.studNameLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.feesStatusLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.feesLeftTextbox = new System.Windows.Forms.TextBox();
            this.feesPaidTextbox = new System.Windows.Forms.TextBox();
            this.feesRequiredTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registerStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberGridView)).BeginInit();
            this.feesGroupbox.SuspendLayout();
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
            this.registerStrip.Size = new System.Drawing.Size(1308, 43);
            this.registerStrip.TabIndex = 6;
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
            this.welcomeMessage.Text = "Club Fees";
            // 
            // memberGridView
            // 
            this.memberGridView.AllowUserToAddRows = false;
            this.memberGridView.AllowUserToDeleteRows = false;
            this.memberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberGridView.Location = new System.Drawing.Point(661, 138);
            this.memberGridView.Name = "memberGridView";
            this.memberGridView.ReadOnly = true;
            this.memberGridView.RowTemplate.Height = 24;
            this.memberGridView.Size = new System.Drawing.Size(591, 434);
            this.memberGridView.TabIndex = 10;
            this.memberGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.memberGridView_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(675, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search Member:";
            // 
            // searchTextbox
            // 
            this.searchTextbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.Location = new System.Drawing.Point(835, 78);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(257, 27);
            this.searchTextbox.TabIndex = 12;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.searchButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(1125, 72);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(127, 38);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search ";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // feesGroupbox
            // 
            this.feesGroupbox.Controls.Add(this.studNameLabel);
            this.feesGroupbox.Controls.Add(this.calculateButton);
            this.feesGroupbox.Controls.Add(this.feesStatusLabel);
            this.feesGroupbox.Controls.Add(this.updateButton);
            this.feesGroupbox.Controls.Add(this.feesLeftTextbox);
            this.feesGroupbox.Controls.Add(this.feesPaidTextbox);
            this.feesGroupbox.Controls.Add(this.feesRequiredTextbox);
            this.feesGroupbox.Controls.Add(this.label8);
            this.feesGroupbox.Controls.Add(this.label7);
            this.feesGroupbox.Controls.Add(this.label6);
            this.feesGroupbox.Controls.Add(this.label5);
            this.feesGroupbox.Controls.Add(this.label4);
            this.feesGroupbox.Controls.Add(this.label3);
            this.feesGroupbox.Controls.Add(this.label2);
            this.feesGroupbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesGroupbox.Location = new System.Drawing.Point(29, 100);
            this.feesGroupbox.Name = "feesGroupbox";
            this.feesGroupbox.Size = new System.Drawing.Size(582, 433);
            this.feesGroupbox.TabIndex = 16;
            this.feesGroupbox.TabStop = false;
            this.feesGroupbox.Text = "Manage member fees here: ";
            // 
            // studNameLabel
            // 
            this.studNameLabel.AutoSize = true;
            this.studNameLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studNameLabel.Location = new System.Drawing.Point(141, 47);
            this.studNameLabel.Name = "studNameLabel";
            this.studNameLabel.Size = new System.Drawing.Size(15, 19);
            this.studNameLabel.TabIndex = 30;
            this.studNameLabel.Text = "-";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Yellow;
            this.calculateButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(458, 205);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(99, 36);
            this.calculateButton.TabIndex = 17;
            this.calculateButton.Text = "Calculate!";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // feesStatusLabel
            // 
            this.feesStatusLabel.AutoSize = true;
            this.feesStatusLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.feesStatusLabel.Location = new System.Drawing.Point(140, 298);
            this.feesStatusLabel.Name = "feesStatusLabel";
            this.feesStatusLabel.Size = new System.Drawing.Size(100, 22);
            this.feesStatusLabel.TabIndex = 29;
            this.feesStatusLabel.Text = "NOT PAID";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.updateButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(70, 370);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(446, 38);
            this.updateButton.TabIndex = 28;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // feesLeftTextbox
            // 
            this.feesLeftTextbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesLeftTextbox.Location = new System.Drawing.Point(208, 207);
            this.feesLeftTextbox.Name = "feesLeftTextbox";
            this.feesLeftTextbox.Size = new System.Drawing.Size(208, 27);
            this.feesLeftTextbox.TabIndex = 27;
            // 
            // feesPaidTextbox
            // 
            this.feesPaidTextbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesPaidTextbox.Location = new System.Drawing.Point(208, 157);
            this.feesPaidTextbox.Name = "feesPaidTextbox";
            this.feesPaidTextbox.Size = new System.Drawing.Size(208, 27);
            this.feesPaidTextbox.TabIndex = 26;
            this.feesPaidTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.feesPaidTextbox_KeyPress);
            // 
            // feesRequiredTextbox
            // 
            this.feesRequiredTextbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesRequiredTextbox.Location = new System.Drawing.Point(208, 112);
            this.feesRequiredTextbox.Name = "feesRequiredTextbox";
            this.feesRequiredTextbox.Size = new System.Drawing.Size(208, 27);
            this.feesRequiredTextbox.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Fees status: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(117, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fees left: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(383, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "---------------------------------------------------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "---------------------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "- Fees paid: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fees owe: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Student name: ";
            // 
            // clubFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 609);
            this.Controls.Add(this.feesGroupbox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memberGridView);
            this.Controls.Add(this.registerStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "clubFees";
            this.Text = "Membership System";
            this.Load += new System.EventHandler(this.clubFees_Load);
            this.registerStrip.ResumeLayout(false);
            this.registerStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberGridView)).EndInit();
            this.feesGroupbox.ResumeLayout(false);
            this.feesGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip registerStrip;
        private System.Windows.Forms.ToolStripLabel welcomeMessage;
        private System.Windows.Forms.DataGridView memberGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox feesGroupbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox feesLeftTextbox;
        private System.Windows.Forms.TextBox feesPaidTextbox;
        private System.Windows.Forms.TextBox feesRequiredTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label feesStatusLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label studNameLabel;
    }
}