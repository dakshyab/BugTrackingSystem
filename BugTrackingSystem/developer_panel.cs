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
using System.Text.RegularExpressions;

namespace BugTrackingSystem
{
    public partial class developer_panel : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private void datagrid()
        {
            try
            {
                database_connect dc = new database_connect();
                string sql_select = "SELECT bug_id, bug, project_name, bug_desc, screenshot, code, date_discovered, verified_status, date_verified, solution, updated_by FROM tbl_bugs";
                MySqlCommand cmd0 = new MySqlCommand(sql_select, dc.Db_Connect());
                DataTable dt = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd0);
                dt.Clear();
                msda.Fill(dt);
                dataGridView_developer.DataSource = dt;
                dc.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public developer_panel()
        {
            InitializeComponent();
            label_bug.Visible = false;
            label_projectname.Visible = false;
            label_id.Text = Form_login.idx;
            label_developer.Text = Form_login.usernamex;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView_developer.SelectedRows[0];
                String bugid = row.Cells["bug_id"].Value.ToString();
                String pname = row.Cells["project_name"].Value.ToString();
                String bug = row.Cells["bug"].Value.ToString();
                String dev = label_developer.Text;
                //getting date and time in order to store the date and time to bug log
                String date = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
                string solution = radioButton_yes.Checked ? "Yes" : "No";
                string sql_update = "UPDATE tbl_bugs SET solution = '" + solution + "', code='" + richTextBox_code.Text + "', solution='" + richTextBox_solution.Text + "', updated_by='"+label_developer.Text+"'  WHERE bug_id='" + bugid + "'";
                //inserting data to tbl_buglog when a developer updates the record for a bug each time
                string sql_log = "INSERT INTO tbl_buglog (project_name, bug, updated_by, updated_on ) VALUES('"+pname+"','"+bug+"','"+dev+"', '"+date+"')";
                database_connect dc = new database_connect();
                MySqlCommand cmd = new MySqlCommand(sql_update, dc.Db_Connect());
                MySqlCommand cmd1 = new MySqlCommand(sql_log, dc.Db_Connect());
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data has been updated");
                datagrid();
                dc.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_developer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                string solution = radioButton_yes.Checked ? "Yes" : "No";
                DataGridViewRow row = dataGridView_developer.SelectedRows[0];
                richTextBox_bugdesc.Text = row.Cells["bug_desc"].Value.ToString();
                richTextBox_code.Text = row.Cells["code"].Value.ToString();
                richTextBox_solution.Text = row.Cells["solution"].Value.ToString();
                textBox_filepath.Text = row.Cells["screenshot"].Value.ToString();
                label_projectname.Text = row.Cells["project_name"].Value.ToString();
                label_bug.Text = row.Cells["bug"].Value.ToString();
                label_bug.Visible = true;
                label_projectname.Visible = true;
                if (solution == "Yes")
                {
                    radioButton_yes.Checked = true;
                }
                else
                {
                    radioButton_no.Checked = true;
                }
                Image screen = Image.FromFile(@"C:\Users\daksh\source\repos\BugTrackingSystem\BugTrackingSystem\screens\" + textBox_filepath.Text, true);
                pictureBox_screen.Image = screen;
            }
            catch(Exception ex)
            {

            }
        }

        private void developer_panel_Load(object sender, EventArgs e)
        {
            try
            {
                //executing query and extracting records from database when the tester panel button is loaded in order to display records
                database_connect dc = new database_connect();
                string sql_bugs = "SELECT bug_id, bug, project_name, bug_desc, screenshot, code, date_discovered, verified_status, date_verified, solution, updated_by FROM tbl_bugs";
                MySqlCommand cmd = new MySqlCommand(sql_bugs, dc.Db_Connect());
                DataTable dt = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                dt.Clear();
                msda.Fill(dt);
                dataGridView_developer.DataSource = dt;
                dc.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_login fl = new Form_login();
            fl.Show();
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            bug_log bl = new bug_log();
            bl.Show();
        }

        private void richTextBox_solution_TextChanged(object sender, EventArgs e)
        {
            //defining array in order to store predefined lists of identifiers
            string[] terms1 = new string[] { "class", "void", "private", "public", "string" };
            string[] terms2 = new string[] { "int", "float", "double", "{", "}", "if", "else" };
            foreach (string str in terms1)
            {
                Regex rx = new Regex(str);
                int index = richTextBox_solution.SelectionStart;
                foreach (Match m in rx.Matches(richTextBox_code.Text))
                {
                    richTextBox_solution.Select(m.Index, m.Value.Length);
                    richTextBox_solution.SelectionColor = Color.Green;
                    richTextBox_solution.SelectionStart = index;
                    richTextBox_solution.SelectionColor = Color.DarkSlateGray;
                }
            }
            foreach (string str in terms2)
            {
                Regex rx = new Regex(str);
                int index = richTextBox_solution.SelectionStart;
                foreach (Match m in rx.Matches(richTextBox_code.Text))
                {
                    richTextBox_solution.Select(m.Index, m.Value.Length);
                    richTextBox_solution.SelectionColor = Color.DodgerBlue;
                    richTextBox_solution.SelectionStart = index;
                    richTextBox_solution.SelectionColor = Color.DarkSlateGray;
                }
            }
        }

        private void richTextBox_code_TextChanged(object sender, EventArgs e)
        {
            //defining array in order to store predefined lists of identifiers
            string[] terms1 = new string[] { "class", "void", "private", "public", "string" };
            string[] terms2 = new string[] { "int", "float", "double", "{", "}", "if", "else" };
            foreach (string str in terms1)
            {
                Regex rx = new Regex(str);
                int index = richTextBox_code.SelectionStart;
                foreach (Match m in rx.Matches(richTextBox_code.Text))
                {
                    richTextBox_code.Select(m.Index, m.Value.Length);
                    richTextBox_code.SelectionColor = Color.Green;
                    richTextBox_code.SelectionStart = index;
                    richTextBox_code.SelectionColor = Color.DarkSlateGray;
                }
            }
            foreach (string str in terms2)
            {
                Regex rx = new Regex(str);
                int index = richTextBox_code.SelectionStart;
                foreach (Match m in rx.Matches(richTextBox_code.Text))
                {
                    richTextBox_code.Select(m.Index, m.Value.Length);
                    richTextBox_code.SelectionColor = Color.DodgerBlue;
                    richTextBox_code.SelectionStart = index;
                    richTextBox_code.SelectionColor = Color.DarkSlateGray;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// events in order to move borderless form
        /// </summary>
        private void developer_panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void developer_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void developer_panel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
