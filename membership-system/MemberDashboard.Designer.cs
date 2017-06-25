namespace membership_system
{
    partial class MemberDashboard
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
            this.components = new System.ComponentModel.Container();
            this.registerStrip = new System.Windows.Forms.ToolStrip();
            this.welcomeMessage = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.intakeCodeTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studenthpTextbox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.studentGenderCombobox = new System.Windows.Forms.ComboBox();
            this.studentEmailTextbox = new System.Windows.Forms.TextBox();
            this.studentNameTextbox = new System.Windows.Forms.TextBox();
            this.pocLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.memberGridView = new System.Windows.Forms.DataGridView();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studenthandphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentintakecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._membership_system_dbDataSet = new membership_system._membership_system_dbDataSet();
            this.studentTableAdapter = new membership_system._membership_system_dbDataSetTableAdapters.StudentTableAdapter();
            this.messageGroupbox = new System.Windows.Forms.GroupBox();
            this.messageText = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.registerStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._membership_system_dbDataSet)).BeginInit();
            this.messageGroupbox.SuspendLayout();
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
            this.registerStrip.Size = new System.Drawing.Size(1593, 43);
            this.registerStrip.TabIndex = 3;
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
            this.welcomeMessage.Text = "Member Dashboard";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.intakeCodeTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.studenthpTextbox);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.genderLabel);
            this.groupBox1.Controls.Add(this.studentGenderCombobox);
            this.groupBox1.Controls.Add(this.studentEmailTextbox);
            this.groupBox1.Controls.Add(this.studentNameTextbox);
            this.groupBox1.Controls.Add(this.pocLabel);
            this.groupBox1.Controls.Add(this.fullnameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(27, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 388);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.deleteButton.Location = new System.Drawing.Point(372, 322);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(153, 35);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(195, 322);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(153, 35);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // intakeCodeTextbox
            // 
            this.intakeCodeTextbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intakeCodeTextbox.Location = new System.Drawing.Point(215, 257);
            this.intakeCodeTextbox.Name = "intakeCodeTextbox";
            this.intakeCodeTextbox.Size = new System.Drawing.Size(297, 27);
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
            this.studenthpTextbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studenthpTextbox.Location = new System.Drawing.Point(215, 99);
            this.studenthpTextbox.Name = "studenthpTextbox";
            this.studenthpTextbox.Size = new System.Drawing.Size(297, 27);
            this.studenthpTextbox.TabIndex = 17;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addButton.Location = new System.Drawing.Point(17, 322);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(153, 35);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.studentGenderCombobox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentGenderCombobox.FormattingEnabled = true;
            this.studentGenderCombobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.studentGenderCombobox.Location = new System.Drawing.Point(215, 201);
            this.studentGenderCombobox.Name = "studentGenderCombobox";
            this.studentGenderCombobox.Size = new System.Drawing.Size(297, 27);
            this.studentGenderCombobox.TabIndex = 12;
            this.studentGenderCombobox.Text = "Male";
            // 
            // studentEmailTextbox
            // 
            this.studentEmailTextbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEmailTextbox.Location = new System.Drawing.Point(215, 147);
            this.studentEmailTextbox.Name = "studentEmailTextbox";
            this.studentEmailTextbox.Size = new System.Drawing.Size(297, 27);
            this.studentEmailTextbox.TabIndex = 9;
            // 
            // studentNameTextbox
            // 
            this.studentNameTextbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameTextbox.Location = new System.Drawing.Point(215, 47);
            this.studentNameTextbox.Name = "studentNameTextbox";
            this.studentNameTextbox.Size = new System.Drawing.Size(297, 27);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.clearSearchButton);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.searchTextbox);
            this.groupBox2.Controls.Add(this.searchNameLabel);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(667, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 92);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Student Here: ";
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.clearSearchButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSearchButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.clearSearchButton.Location = new System.Drawing.Point(652, 46);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(153, 35);
            this.clearSearchButton.TabIndex = 23;
            this.clearSearchButton.Text = "Clear";
            this.clearSearchButton.UseVisualStyleBackColor = false;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
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
            this.searchTextbox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.Location = new System.Drawing.Point(166, 49);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(297, 28);
            this.searchTextbox.TabIndex = 22;
            // 
            // searchNameLabel
            // 
            this.searchNameLabel.AutoSize = true;
            this.searchNameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNameLabel.Location = new System.Drawing.Point(30, 53);
            this.searchNameLabel.Name = "searchNameLabel";
            this.searchNameLabel.Size = new System.Drawing.Size(109, 17);
            this.searchNameLabel.TabIndex = 22;
            this.searchNameLabel.Text = "Student Name: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.memberGridView);
            this.panel1.Location = new System.Drawing.Point(625, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 523);
            this.panel1.TabIndex = 7;
            // 
            // memberGridView
            // 
            this.memberGridView.AllowUserToAddRows = false;
            this.memberGridView.AllowUserToDeleteRows = false;
            this.memberGridView.AllowUserToOrderColumns = true;
            this.memberGridView.AutoGenerateColumns = false;
            this.memberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentnameDataGridViewTextBoxColumn,
            this.studenthandphoneDataGridViewTextBoxColumn,
            this.studentemailDataGridViewTextBoxColumn,
            this.studentgenderDataGridViewTextBoxColumn,
            this.studentintakecodeDataGridViewTextBoxColumn});
            this.memberGridView.DataSource = this.studentBindingSource;
            this.memberGridView.Location = new System.Drawing.Point(3, 3);
            this.memberGridView.Name = "memberGridView";
            this.memberGridView.ReadOnly = true;
            this.memberGridView.RowTemplate.Height = 24;
            this.memberGridView.Size = new System.Drawing.Size(902, 517);
            this.memberGridView.TabIndex = 0;
            this.memberGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.memberGridView_RowHeaderMouseClick);
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "student_name";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "Student Name ";
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            this.studentnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studenthandphoneDataGridViewTextBoxColumn
            // 
            this.studenthandphoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studenthandphoneDataGridViewTextBoxColumn.DataPropertyName = "student_handphone";
            this.studenthandphoneDataGridViewTextBoxColumn.HeaderText = "Handphone ";
            this.studenthandphoneDataGridViewTextBoxColumn.Name = "studenthandphoneDataGridViewTextBoxColumn";
            this.studenthandphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentemailDataGridViewTextBoxColumn
            // 
            this.studentemailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentemailDataGridViewTextBoxColumn.DataPropertyName = "student_email";
            this.studentemailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.studentemailDataGridViewTextBoxColumn.Name = "studentemailDataGridViewTextBoxColumn";
            this.studentemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentgenderDataGridViewTextBoxColumn
            // 
            this.studentgenderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentgenderDataGridViewTextBoxColumn.DataPropertyName = "student_gender";
            this.studentgenderDataGridViewTextBoxColumn.HeaderText = "Student Gender";
            this.studentgenderDataGridViewTextBoxColumn.Name = "studentgenderDataGridViewTextBoxColumn";
            this.studentgenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentintakecodeDataGridViewTextBoxColumn
            // 
            this.studentintakecodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentintakecodeDataGridViewTextBoxColumn.DataPropertyName = "student_intakecode";
            this.studentintakecodeDataGridViewTextBoxColumn.HeaderText = "Student Intake Code";
            this.studentintakecodeDataGridViewTextBoxColumn.Name = "studentintakecodeDataGridViewTextBoxColumn";
            this.studentintakecodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this._membership_system_dbDataSet;
            // 
            // _membership_system_dbDataSet
            // 
            this._membership_system_dbDataSet.DataSetName = "_membership_system_dbDataSet";
            this._membership_system_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // messageGroupbox
            // 
            this.messageGroupbox.Controls.Add(this.messageText);
            this.messageGroupbox.Controls.Add(this.statusText);
            this.messageGroupbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageGroupbox.Location = new System.Drawing.Point(27, 601);
            this.messageGroupbox.Name = "messageGroupbox";
            this.messageGroupbox.Size = new System.Drawing.Size(558, 100);
            this.messageGroupbox.TabIndex = 8;
            this.messageGroupbox.TabStop = false;
            this.messageGroupbox.Text = "Message";
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageText.Location = new System.Drawing.Point(88, 47);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(13, 18);
            this.messageText.TabIndex = 23;
            this.messageText.Text = "-";
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.Location = new System.Drawing.Point(24, 47);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(58, 17);
            this.statusText.TabIndex = 22;
            this.statusText.Text = "Status: ";
            // 
            // MemberDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1593, 749);
            this.Controls.Add(this.messageGroupbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.registerStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MemberDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membership System";
            this.Load += new System.EventHandler(this.MemberDashboard_Load);
            this.registerStrip.ResumeLayout(false);
            this.registerStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._membership_system_dbDataSet)).EndInit();
            this.messageGroupbox.ResumeLayout(false);
            this.messageGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip registerStrip;
        private System.Windows.Forms.ToolStripLabel welcomeMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox intakeCodeTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studenthpTextbox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox studentGenderCombobox;
        private System.Windows.Forms.TextBox studentEmailTextbox;
        private System.Windows.Forms.TextBox studentNameTextbox;
        private System.Windows.Forms.Label pocLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Label searchNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView memberGridView;
        private _membership_system_dbDataSet _membership_system_dbDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private _membership_system_dbDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studenthandphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentintakecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.GroupBox messageGroupbox;
        private System.Windows.Forms.Label messageText;
        private System.Windows.Forms.Label statusText;
    }
}