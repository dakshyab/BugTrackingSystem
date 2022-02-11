using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BugTrackingSystem
{
    public partial class admin_panel : Form
    {
        /// <summary>
        /// declaring bool and poing variables needed in order to drag the form for moving the program's position
        /// </summary>
        private bool mouseDown;
        private Point lastLocation;
        /// <summary>
        ///creating a function for loading records from the database to the datagridview_user
        /// </summary>
        private void datagrid()
        {
            try
            {
                database_connect dc = new database_connect();
                string sql_select = "SELECT * FROM tbl_users";
                MySqlCommand cmd0 = new MySqlCommand(sql_select, dc.Db_Connect());
                DataTable dt = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd0);
                dt.Clear();
                msda.Fill(dt);
                dataGridView_users.DataSource = dt;
                dc.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        ///creating a function for loading records from the database to the datagridview_bugs
        /// </summary>
        private void datagrid_b()
        {
            try
            {
                database_connect dc = new database_connect();
                string sql_select = "SELECT bug_id, bug, project_name, verified_status FROM tbl_bugs";
                MySqlCommand cmd0 = new MySqlCommand(sql_select, dc.Db_Connect());
                DataTable dt1 = new DataTable();
                MySqlDataAdapter msda1 = new MySqlDataAdapter(cmd0);
                dt1.Clear();
                msda1.Fill(dt1);
                dataGridView_bugs.DataSource = dt1;
                dc.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public admin_panel()
        {
            InitializeComponent();
            radioButton_verified_no.Checked = true;
            radioButton_no.Checked = true;
            /// <summary>
            ///loading userid and username values from login form to their respective labels
            /// </summary>
            label_id.Text = Form_login.idx;
            label_admin.Text = Form_login.usernamex;
        }

        private void admin_panel_Load(object sender, EventArgs e)
        {
            try
            {
                /// <summary>
                ///executing query and extracting records from database when the admin panel button is loaded in order to display records
                ///</summary>
                button_git.Enabled = false;
                database_connect dc = new database_connect();
                string sql_login = "SELECT * FROM tbl_users";
                MySqlCommand cmd = new MySqlCommand(sql_login, dc.Db_Connect());

                DataTable dt = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                dt.Clear();
                msda.Fill(dt);
                dataGridView_users.DataSource = dt;
                //dc.CloseConnection();

                string sql_login_b = "SELECT bug_id, bug, project_name, verified_status FROM tbl_bugs";
                MySqlCommand cmd1 = new MySqlCommand(sql_login_b, dc.Db_Connect());

                DataTable dt1 = new DataTable();
                MySqlDataAdapter msda1 = new MySqlDataAdapter(cmd1);
                dt1.Clear();
                msda1.Fill(dt1);
                dataGridView_bugs.DataSource = dt1;
                dc.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                /// <summary>
                ///extracting combobox value in order to store into database
                ///</summary>
                string pos = comboBox_position.SelectedItem.ToString();
                /// <summary>
                ///reading selected radiobutton in order to store into database
                ///</summary>
                string verified = radioButton_verified_yes.Checked ? "Yes" : "No";
                string sql_add = "INSERT INTO tbl_users(username, password, position, verified) VALUES ('"+text_username.Text+"','"+text_password.Text+"','"+pos+"','"+verified+"')";
                database_connect dc = new database_connect();
                MySqlCommand cmd = new MySqlCommand(sql_add, dc.Db_Connect());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been saved");
                datagrid();
                dc.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                string pos = comboBox_position.SelectedItem.ToString();
                string verified = radioButton_verified_yes.Checked ? "yes" : "no";
                string sql_update = "UPDATE tbl_users SET username='" + text_username.Text + "', password='" + text_password.Text + "', position='" + pos + "', verified='" + verified + "' WHERE username='" + text_username.Text + "'";
                database_connect dc = new database_connect();
                MySqlCommand cmd = new MySqlCommand(sql_update, dc.Db_Connect());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been updated");
                datagrid();
                dc.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                /// <summary>
                ///deleting the selected record after confirmation
                ///</summary>
                DialogResult dr = MessageBox.Show("Are you sure you want to delete the data?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    string sql_del = "DELETE FROM tbl_users WHERE username = '"+text_username.Text+"'";
                    database_connect dc = new database_connect();
                    MySqlCommand cmd = new MySqlCommand(sql_del, dc.Db_Connect());
                    cmd.ExecuteNonQuery();
                    datagrid();
                    dc.CloseConnection();

                    MessageBox.Show("Data has been deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_username.Text = "";
            text_password.Text = "";
        }

        private void dataGridView_users_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                /// <summary>
                /// loading data into datagridview on cellclick event
                /// </summary>
                DataGridViewRow row = dataGridView_users.SelectedRows[0];
                text_username.Text = row.Cells["username"].Value.ToString();
                text_password.Text = row.Cells["password"].Value.ToString();
                //if(row.Cells["position"].Value.ToString()=="Admin")
                //    comboBox_position.SelectedIndex = 1;
                //else if (row.Cells["position"].Value.ToString() == "Tester")
                //    comboBox_position.SelectedIndex = 2;
                //else
                //    comboBox_position.SelectedIndex = 3;
                if (row.Cells["position"].Value.ToString() == "Admin")
                    comboBox_position.Text = "Admin";
                else if (row.Cells["position"].Value.ToString() == "Tester")
                    comboBox_position.Text = "Tester";
                else
                    comboBox_position.Text = "Developer";

                if (row.Cells["verified"].Value.ToString() == "yes")
                    radioButton_verified_yes.Checked = true;
                else
                    radioButton_verified_no.Checked = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_login fl = new Form_login();
            fl.Show();
        }

        private void button_b_update_Click(object sender, EventArgs e)
        {
            try
            {
                string status = radioButton_yes.Checked ? "Yes" : "No";
                DataGridViewRow row = dataGridView_bugs.SelectedRows[0];
                String bugid = row.Cells["bug_id"].Value.ToString();
                database_connect dc = new database_connect();
                string sql_update = "UPDATE tbl_bugs SET project_name = '" + text_prname.Text + "', verified_status='" + status + "' WHERE bug_id='" + bugid + "'";
                MySqlCommand cmd = new MySqlCommand(sql_update, dc.Db_Connect());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been updated");
                datagrid_b();
                dc.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_b_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete the data?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridView_bugs.SelectedRows[0];
                    String bugid = row.Cells["bug_id"].Value.ToString();
                    string sql_delete = "DELETE FROM tbl_bugs WHERE bug_id = '"+ bugid+ "'";
                    database_connect dc = new database_connect();
                    MySqlCommand cmd = new MySqlCommand(sql_delete, dc.Db_Connect());
                    cmd.ExecuteNonQuery();
                    datagrid();
                    dc.CloseConnection();

                    MessageBox.Show("Data has been deleted");
                }
                datagrid_b();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_bugs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView_bugs.SelectedRows[0];
                text_prname.Text = row.Cells["project_name"].Value.ToString();
                label_bug.Text = row.Cells["bug"].Value.ToString();
                if (row.Cells["verified_status"].Value.ToString() == "Yes")
                    radioButton_verified_yes.Checked = true;
                else
                    radioButton_verified_no.Checked = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void button_bug_add_Click(object sender, EventArgs e)
        {
            try
            {
                string status = radioButton_yes.Checked ? "Yes" : "No";
                string sql_add = "INSERT INTO tbl_bugs(project_name, verified_status) VALUES ('" + text_prname.Text + "','" + status + "')";
                database_connect dc = new database_connect();
                MySqlCommand cmd = new MySqlCommand(sql_add, dc.Db_Connect());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been saved");
                datagrid_b();
                dc.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// opening bug_log form
            /// </summary>
            bug_log bl = new bug_log();
            bl.Show();
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            /// <summary>
            /// minimizing admin form when picturebox is clicked
            /// </summary>
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// closing admin form when picturebox is clicked
            /// </summary>
            this.Close();
        }

        private void admin_panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void admin_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void admin_panel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button_git_Click(object sender, EventArgs e)
        {
        }
    }
}
