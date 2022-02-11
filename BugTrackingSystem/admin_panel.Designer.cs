namespace BugTrackingSystem
{
    partial class admin_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_panel));
            this.tab_admin = new System.Windows.Forms.TabControl();
            this.tab_admin_users = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_verified_yes = new System.Windows.Forms.RadioButton();
            this.radioButton_verified_no = new System.Windows.Forms.RadioButton();
            this.button_clear = new System.Windows.Forms.Button();
            this.comboBox_position = new System.Windows.Forms.ComboBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.text_password = new System.Windows.Forms.TextBox();
            this.text_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_admin_bugs = new System.Windows.Forms.TabPage();
            this.label_bug = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_bug_add = new System.Windows.Forms.Button();
            this.text_prname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_no = new System.Windows.Forms.RadioButton();
            this.radioButton_yes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.button_b_delete = new System.Windows.Forms.Button();
            this.button_b_update = new System.Windows.Forms.Button();
            this.dataGridView_bugs = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label_admin = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.button_log = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_git = new System.Windows.Forms.Button();
            this.tab_admin.SuspendLayout();
            this.tab_admin_users.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.tab_admin_bugs.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_admin
            // 
            this.tab_admin.Controls.Add(this.tab_admin_users);
            this.tab_admin.Controls.Add(this.tab_admin_bugs);
            this.tab_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_admin.Location = new System.Drawing.Point(13, 81);
            this.tab_admin.Margin = new System.Windows.Forms.Padding(4);
            this.tab_admin.Name = "tab_admin";
            this.tab_admin.SelectedIndex = 0;
            this.tab_admin.Size = new System.Drawing.Size(670, 469);
            this.tab_admin.TabIndex = 0;
            // 
            // tab_admin_users
            // 
            this.tab_admin_users.Controls.Add(this.groupBox1);
            this.tab_admin_users.Controls.Add(this.button_clear);
            this.tab_admin_users.Controls.Add(this.comboBox_position);
            this.tab_admin_users.Controls.Add(this.button_delete);
            this.tab_admin_users.Controls.Add(this.button_update);
            this.tab_admin_users.Controls.Add(this.button_add);
            this.tab_admin_users.Controls.Add(this.dataGridView_users);
            this.tab_admin_users.Controls.Add(this.text_password);
            this.tab_admin_users.Controls.Add(this.text_username);
            this.tab_admin_users.Controls.Add(this.label3);
            this.tab_admin_users.Controls.Add(this.label2);
            this.tab_admin_users.Controls.Add(this.label1);
            this.tab_admin_users.Location = new System.Drawing.Point(4, 29);
            this.tab_admin_users.Margin = new System.Windows.Forms.Padding(4);
            this.tab_admin_users.Name = "tab_admin_users";
            this.tab_admin_users.Padding = new System.Windows.Forms.Padding(4);
            this.tab_admin_users.Size = new System.Drawing.Size(662, 436);
            this.tab_admin_users.TabIndex = 0;
            this.tab_admin_users.Text = "Users";
            this.tab_admin_users.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_verified_yes);
            this.groupBox1.Controls.Add(this.radioButton_verified_no);
            this.groupBox1.Location = new System.Drawing.Point(373, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 96);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verified user:";
            // 
            // radioButton_verified_yes
            // 
            this.radioButton_verified_yes.AutoSize = true;
            this.radioButton_verified_yes.Location = new System.Drawing.Point(29, 39);
            this.radioButton_verified_yes.Name = "radioButton_verified_yes";
            this.radioButton_verified_yes.Size = new System.Drawing.Size(58, 24);
            this.radioButton_verified_yes.TabIndex = 18;
            this.radioButton_verified_yes.TabStop = true;
            this.radioButton_verified_yes.Text = "Yes";
            this.radioButton_verified_yes.UseVisualStyleBackColor = true;
            // 
            // radioButton_verified_no
            // 
            this.radioButton_verified_no.AutoSize = true;
            this.radioButton_verified_no.Location = new System.Drawing.Point(106, 39);
            this.radioButton_verified_no.Name = "radioButton_verified_no";
            this.radioButton_verified_no.Size = new System.Drawing.Size(51, 24);
            this.radioButton_verified_no.TabIndex = 19;
            this.radioButton_verified_no.TabStop = true;
            this.radioButton_verified_no.Text = "No";
            this.radioButton_verified_no.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_clear.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_clear.Location = new System.Drawing.Point(521, 212);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Padding = new System.Windows.Forms.Padding(1);
            this.button_clear.Size = new System.Drawing.Size(100, 38);
            this.button_clear.TabIndex = 16;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // comboBox_position
            // 
            this.comboBox_position.FormattingEnabled = true;
            this.comboBox_position.Items.AddRange(new object[] {
            "Admin",
            "Tester",
            "Developer"});
            this.comboBox_position.Location = new System.Drawing.Point(121, 84);
            this.comboBox_position.Name = "comboBox_position";
            this.comboBox_position.Size = new System.Drawing.Size(132, 28);
            this.comboBox_position.TabIndex = 15;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_delete.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_delete.Location = new System.Drawing.Point(362, 212);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Padding = new System.Windows.Forms.Padding(1);
            this.button_delete.Size = new System.Drawing.Size(100, 38);
            this.button_delete.TabIndex = 13;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_update.Location = new System.Drawing.Point(198, 212);
            this.button_update.Margin = new System.Windows.Forms.Padding(4);
            this.button_update.Name = "button_update";
            this.button_update.Padding = new System.Windows.Forms.Padding(1);
            this.button_update.Size = new System.Drawing.Size(100, 38);
            this.button_update.TabIndex = 12;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_add.Location = new System.Drawing.Point(35, 212);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Padding = new System.Windows.Forms.Padding(1);
            this.button_add.Size = new System.Drawing.Size(100, 38);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Location = new System.Drawing.Point(9, 278);
            this.dataGridView_users.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.Size = new System.Drawing.Size(645, 150);
            this.dataGridView_users.TabIndex = 10;
            this.dataGridView_users.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_users_CellMouseClick);
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(489, 16);
            this.text_password.Margin = new System.Windows.Forms.Padding(4);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(132, 26);
            this.text_password.TabIndex = 6;
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(121, 16);
            this.text_username.Margin = new System.Windows.Forms.Padding(4);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(132, 26);
            this.text_username.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // tab_admin_bugs
            // 
            this.tab_admin_bugs.Controls.Add(this.label_bug);
            this.tab_admin_bugs.Controls.Add(this.label5);
            this.tab_admin_bugs.Controls.Add(this.button_bug_add);
            this.tab_admin_bugs.Controls.Add(this.text_prname);
            this.tab_admin_bugs.Controls.Add(this.groupBox2);
            this.tab_admin_bugs.Controls.Add(this.label4);
            this.tab_admin_bugs.Controls.Add(this.button_b_delete);
            this.tab_admin_bugs.Controls.Add(this.button_b_update);
            this.tab_admin_bugs.Controls.Add(this.dataGridView_bugs);
            this.tab_admin_bugs.Location = new System.Drawing.Point(4, 29);
            this.tab_admin_bugs.Margin = new System.Windows.Forms.Padding(4);
            this.tab_admin_bugs.Name = "tab_admin_bugs";
            this.tab_admin_bugs.Padding = new System.Windows.Forms.Padding(4);
            this.tab_admin_bugs.Size = new System.Drawing.Size(662, 436);
            this.tab_admin_bugs.TabIndex = 1;
            this.tab_admin_bugs.Text = "Bugs";
            this.tab_admin_bugs.UseVisualStyleBackColor = true;
            // 
            // label_bug
            // 
            this.label_bug.AutoSize = true;
            this.label_bug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bug.Location = new System.Drawing.Point(95, 51);
            this.label_bug.Name = "label_bug";
            this.label_bug.Size = new System.Drawing.Size(49, 20);
            this.label_bug.TabIndex = 19;
            this.label_bug.Text = "        ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Bug";
            // 
            // button_bug_add
            // 
            this.button_bug_add.Location = new System.Drawing.Point(47, 176);
            this.button_bug_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_bug_add.Name = "button_bug_add";
            this.button_bug_add.Padding = new System.Windows.Forms.Padding(1);
            this.button_bug_add.Size = new System.Drawing.Size(100, 38);
            this.button_bug_add.TabIndex = 17;
            this.button_bug_add.Text = "Add";
            this.button_bug_add.UseVisualStyleBackColor = true;
            this.button_bug_add.Click += new System.EventHandler(this.button_bug_add_Click);
            // 
            // text_prname
            // 
            this.text_prname.Location = new System.Drawing.Point(171, 15);
            this.text_prname.Name = "text_prname";
            this.text_prname.Size = new System.Drawing.Size(127, 26);
            this.text_prname.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_no);
            this.groupBox2.Controls.Add(this.radioButton_yes);
            this.groupBox2.Location = new System.Drawing.Point(48, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 84);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verified Status";
            // 
            // radioButton_no
            // 
            this.radioButton_no.AutoSize = true;
            this.radioButton_no.Location = new System.Drawing.Point(13, 52);
            this.radioButton_no.Name = "radioButton_no";
            this.radioButton_no.Size = new System.Drawing.Size(51, 24);
            this.radioButton_no.TabIndex = 1;
            this.radioButton_no.TabStop = true;
            this.radioButton_no.Text = "No";
            this.radioButton_no.UseVisualStyleBackColor = true;
            // 
            // radioButton_yes
            // 
            this.radioButton_yes.AutoSize = true;
            this.radioButton_yes.Location = new System.Drawing.Point(13, 22);
            this.radioButton_yes.Name = "radioButton_yes";
            this.radioButton_yes.Size = new System.Drawing.Size(58, 24);
            this.radioButton_yes.TabIndex = 0;
            this.radioButton_yes.TabStop = true;
            this.radioButton_yes.Text = "Yes";
            this.radioButton_yes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Project Name";
            // 
            // button_b_delete
            // 
            this.button_b_delete.Location = new System.Drawing.Point(296, 176);
            this.button_b_delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_b_delete.Name = "button_b_delete";
            this.button_b_delete.Padding = new System.Windows.Forms.Padding(1);
            this.button_b_delete.Size = new System.Drawing.Size(100, 38);
            this.button_b_delete.TabIndex = 13;
            this.button_b_delete.Text = "Delete";
            this.button_b_delete.UseVisualStyleBackColor = true;
            this.button_b_delete.Click += new System.EventHandler(this.button_b_delete_Click);
            // 
            // button_b_update
            // 
            this.button_b_update.Location = new System.Drawing.Point(171, 176);
            this.button_b_update.Margin = new System.Windows.Forms.Padding(4);
            this.button_b_update.Name = "button_b_update";
            this.button_b_update.Padding = new System.Windows.Forms.Padding(1);
            this.button_b_update.Size = new System.Drawing.Size(100, 38);
            this.button_b_update.TabIndex = 12;
            this.button_b_update.Text = "Update";
            this.button_b_update.UseVisualStyleBackColor = true;
            this.button_b_update.Click += new System.EventHandler(this.button_b_update_Click);
            // 
            // dataGridView_bugs
            // 
            this.dataGridView_bugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bugs.Location = new System.Drawing.Point(37, 233);
            this.dataGridView_bugs.Name = "dataGridView_bugs";
            this.dataGridView_bugs.RowTemplate.Height = 24;
            this.dataGridView_bugs.Size = new System.Drawing.Size(594, 185);
            this.dataGridView_bugs.TabIndex = 3;
            this.dataGridView_bugs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_bugs_CellMouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(17, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Logged in As : ";
            // 
            // label_admin
            // 
            this.label_admin.AutoSize = true;
            this.label_admin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admin.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_admin.Location = new System.Drawing.Point(159, 47);
            this.label_admin.Name = "label_admin";
            this.label_admin.Size = new System.Drawing.Size(37, 18);
            this.label_admin.TabIndex = 17;
            this.label_admin.Text = "user";
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.LightSalmon;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_logout.Location = new System.Drawing.Point(240, 42);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 30);
            this.button_logout.TabIndex = 18;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_id.Location = new System.Drawing.Point(125, 47);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(19, 18);
            this.label_id.TabIndex = 19;
            this.label_id.Text = "id";
            // 
            // button_log
            // 
            this.button_log.BackColor = System.Drawing.Color.LightSalmon;
            this.button_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_log.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_log.Location = new System.Drawing.Point(339, 42);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(88, 30);
            this.button_log.TabIndex = 29;
            this.button_log.Text = "View Log";
            this.button_log.UseVisualStyleBackColor = false;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BugTrackingSystem.Properties.Resources.minimize;
            this.pictureBox2.Location = new System.Drawing.Point(628, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BugTrackingSystem.Properties.Resources.close_hi;
            this.pictureBox1.Location = new System.Drawing.Point(663, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_git
            // 
            this.button_git.BackColor = System.Drawing.Color.LightSalmon;
            this.button_git.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_git.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_git.Location = new System.Drawing.Point(446, 42);
            this.button_git.Name = "button_git";
            this.button_git.Size = new System.Drawing.Size(75, 30);
            this.button_git.TabIndex = 32;
            this.button_git.Text = "Git Lab";
            this.button_git.UseVisualStyleBackColor = false;
            this.button_git.Click += new System.EventHandler(this.button_git_Click);
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BugTrackingSystem.Properties.Resources.logo_hirez;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(704, 563);
            this.Controls.Add(this.button_git);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.label_admin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tab_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admin_panel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.admin_panel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.admin_panel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.admin_panel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.admin_panel_MouseUp);
            this.tab_admin.ResumeLayout(false);
            this.tab_admin_users.ResumeLayout(false);
            this.tab_admin_users.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            this.tab_admin_bugs.ResumeLayout(false);
            this.tab_admin_bugs.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_admin;
        private System.Windows.Forms.TabPage tab_admin_users;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_admin_bugs;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_position;
        private System.Windows.Forms.Button button_b_delete;
        private System.Windows.Forms.Button button_b_update;
        private System.Windows.Forms.DataGridView dataGridView_bugs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_admin;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.RadioButton radioButton_verified_no;
        private System.Windows.Forms.RadioButton radioButton_verified_yes;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_no;
        private System.Windows.Forms.RadioButton radioButton_yes;
        private System.Windows.Forms.TextBox text_prname;
        private System.Windows.Forms.Button button_bug_add;
        private System.Windows.Forms.Label label_bug;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_git;
    }
}