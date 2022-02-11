namespace BugTrackingSystem
{
    partial class developer_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(developer_panel));
            this.label1 = new System.Windows.Forms.Label();
            this.label_developer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_projectname = new System.Windows.Forms.Label();
            this.richTextBox_bugdesc = new System.Windows.Forms.RichTextBox();
            this.dataGridView_developer = new System.Windows.Forms.DataGridView();
            this.button_update = new System.Windows.Forms.Button();
            this.richTextBox_solution = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_logout = new System.Windows.Forms.Button();
            this.pictureBox_screen = new System.Windows.Forms.PictureBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_bug = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_code = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_no = new System.Windows.Forms.RadioButton();
            this.radioButton_yes = new System.Windows.Forms.RadioButton();
            this.textBox_filepath = new System.Windows.Forms.TextBox();
            this.button_log = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_developer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_screen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logged in as : ";
            // 
            // label_developer
            // 
            this.label_developer.AutoSize = true;
            this.label_developer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_developer.ForeColor = System.Drawing.Color.Red;
            this.label_developer.Location = new System.Drawing.Point(170, 80);
            this.label_developer.Name = "label_developer";
            this.label_developer.Size = new System.Drawing.Size(37, 18);
            this.label_developer.TabIndex = 1;
            this.label_developer.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bug description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Screen Shot";
            // 
            // label_projectname
            // 
            this.label_projectname.AutoSize = true;
            this.label_projectname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_projectname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_projectname.Location = new System.Drawing.Point(149, 116);
            this.label_projectname.Name = "label_projectname";
            this.label_projectname.Size = new System.Drawing.Size(108, 20);
            this.label_projectname.TabIndex = 7;
            this.label_projectname.Text = "Project name";
            // 
            // richTextBox_bugdesc
            // 
            this.richTextBox_bugdesc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox_bugdesc.Location = new System.Drawing.Point(185, 202);
            this.richTextBox_bugdesc.Name = "richTextBox_bugdesc";
            this.richTextBox_bugdesc.ReadOnly = true;
            this.richTextBox_bugdesc.Size = new System.Drawing.Size(214, 106);
            this.richTextBox_bugdesc.TabIndex = 8;
            this.richTextBox_bugdesc.Text = "";
            // 
            // dataGridView_developer
            // 
            this.dataGridView_developer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_developer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_developer.Location = new System.Drawing.Point(16, 550);
            this.dataGridView_developer.Name = "dataGridView_developer";
            this.dataGridView_developer.RowTemplate.Height = 24;
            this.dataGridView_developer.Size = new System.Drawing.Size(756, 186);
            this.dataGridView_developer.TabIndex = 11;
            this.dataGridView_developer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_developer_CellMouseClick);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_update.Location = new System.Drawing.Point(364, 506);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(108, 38);
            this.button_update.TabIndex = 13;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // richTextBox_solution
            // 
            this.richTextBox_solution.Location = new System.Drawing.Point(6, 21);
            this.richTextBox_solution.Name = "richTextBox_solution";
            this.richTextBox_solution.Size = new System.Drawing.Size(322, 214);
            this.richTextBox_solution.TabIndex = 14;
            this.richTextBox_solution.Text = "";
            this.richTextBox_solution.TextChanged += new System.EventHandler(this.richTextBox_solution_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.richTextBox_solution);
            this.groupBox1.Location = new System.Drawing.Point(428, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 241);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solution";
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_logout.Location = new System.Drawing.Point(224, 73);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 30);
            this.button_logout.TabIndex = 19;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // pictureBox_screen
            // 
            this.pictureBox_screen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_screen.Location = new System.Drawing.Point(185, 329);
            this.pictureBox_screen.Name = "pictureBox_screen";
            this.pictureBox_screen.Size = new System.Drawing.Size(214, 108);
            this.pictureBox_screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_screen.TabIndex = 9;
            this.pictureBox_screen.TabStop = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_id.Location = new System.Drawing.Point(140, 80);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(19, 18);
            this.label_id.TabIndex = 20;
            this.label_id.Text = "id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Bug";
            // 
            // label_bug
            // 
            this.label_bug.AutoSize = true;
            this.label_bug.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_bug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bug.Location = new System.Drawing.Point(149, 155);
            this.label_bug.Name = "label_bug";
            this.label_bug.Size = new System.Drawing.Size(53, 20);
            this.label_bug.TabIndex = 22;
            this.label_bug.Text = "label7";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.richTextBox_code);
            this.groupBox2.Location = new System.Drawing.Point(428, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 165);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Code";
            // 
            // richTextBox_code
            // 
            this.richTextBox_code.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox_code.Location = new System.Drawing.Point(6, 24);
            this.richTextBox_code.Name = "richTextBox_code";
            this.richTextBox_code.ReadOnly = true;
            this.richTextBox_code.Size = new System.Drawing.Size(308, 135);
            this.richTextBox_code.TabIndex = 14;
            this.richTextBox_code.Text = "";
            this.richTextBox_code.TextChanged += new System.EventHandler(this.richTextBox_code_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.radioButton_no);
            this.groupBox3.Controls.Add(this.radioButton_yes);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(153, 480);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 64);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Solution complete";
            // 
            // radioButton_no
            // 
            this.radioButton_no.AutoSize = true;
            this.radioButton_no.Location = new System.Drawing.Point(98, 27);
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
            this.radioButton_yes.Location = new System.Drawing.Point(7, 27);
            this.radioButton_yes.Name = "radioButton_yes";
            this.radioButton_yes.Size = new System.Drawing.Size(58, 24);
            this.radioButton_yes.TabIndex = 0;
            this.radioButton_yes.TabStop = true;
            this.radioButton_yes.Text = "Yes";
            this.radioButton_yes.UseVisualStyleBackColor = true;
            // 
            // textBox_filepath
            // 
            this.textBox_filepath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_filepath.Location = new System.Drawing.Point(185, 443);
            this.textBox_filepath.Name = "textBox_filepath";
            this.textBox_filepath.ReadOnly = true;
            this.textBox_filepath.Size = new System.Drawing.Size(214, 22);
            this.textBox_filepath.TabIndex = 27;
            // 
            // button_log
            // 
            this.button_log.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_log.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_log.Location = new System.Drawing.Point(319, 73);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(88, 30);
            this.button_log.TabIndex = 28;
            this.button_log.Text = "View Log";
            this.button_log.UseVisualStyleBackColor = false;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BugTrackingSystem.Properties.Resources.minimize;
            this.pictureBox2.Location = new System.Drawing.Point(708, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BugTrackingSystem.Properties.Resources.close_hi;
            this.pictureBox1.Location = new System.Drawing.Point(743, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // developer_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::BugTrackingSystem.Properties.Resources.logo_hirez;
            this.ClientSize = new System.Drawing.Size(784, 748);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.textBox_filepath);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label_bug);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.dataGridView_developer);
            this.Controls.Add(this.pictureBox_screen);
            this.Controls.Add(this.richTextBox_bugdesc);
            this.Controls.Add(this.label_projectname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_developer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "developer_panel";
            this.Text = "Developer Panel";
            this.Load += new System.EventHandler(this.developer_panel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.developer_panel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.developer_panel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.developer_panel_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_developer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_screen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_developer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_projectname;
        private System.Windows.Forms.RichTextBox richTextBox_bugdesc;
        private System.Windows.Forms.PictureBox pictureBox_screen;
        private System.Windows.Forms.DataGridView dataGridView_developer;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.RichTextBox richTextBox_solution;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_bug;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox_code;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_no;
        private System.Windows.Forms.RadioButton radioButton_yes;
        private System.Windows.Forms.TextBox textBox_filepath;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}