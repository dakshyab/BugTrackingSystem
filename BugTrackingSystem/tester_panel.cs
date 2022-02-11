using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;

namespace BugTrackingSystem
{
    public partial class tester_panel : Form
    {
        //declaring bool and poing variables needed in order to drag the form for moving the program's position
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
                dataGridView_tester.DataSource = dt;
                dc.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void prname()
        {
            database_connect dc = new database_connect();
            string sql = "SELECT project_name from tbl_bugs";
            MySqlCommand cmd = new MySqlCommand(sql, dc.Db_Connect());
            DataTable dt = new DataTable();
            MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
            msda.Fill(dt);
            comboBox_project.DisplayMember = "project_name";
            comboBox_project.ValueMember = "project_name";
            comboBox_project.DataSource = dt;
        }
        public tester_panel()
        {
            InitializeComponent();
            label_id.Text = Form_login.idx;
            label_user.Text = Form_login.usernamex;
        }

        //public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        //{
        //    // Convert Image to byte[]
        //    image.Save(ms, format);
        //    byte[] imageBytes = ms.ToArray();

        //    // Convert byte[] to Base64 String
        //    string base64String = Convert.ToBase64String(imageBytes);
        //    return base64String;
        //}
        //public Image Base64ToImage(string base64String)
        //{
        //    // Convert Base64 String to byte[]
        //    byte[] imageBytes = Convert.FromBase64String(base64String);
        //    MemoryStream ms = new MemoryStream(imageBytes, 0,
        //      imageBytes.Length);

        //    // Convert byte[] to Image
        //    ms.Write(imageBytes, 0, imageBytes.Length);
        //    Image image = Image.FromStream(ms, true);
        //    return image;
        //}
        private void tester_panel_Load(object sender, EventArgs e)
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
                dataGridView_tester.DataSource = dt;
                prname();
                dc.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string verified = radioButton_yes.Checked ? "Yes" : "No";
            //string loc = @"..\..\screens\";
            //string path = @"..\bin\Debug\";
            //string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\screens"));
            //label8.Text = @loc;
            //File.Copy()
            //string sql_add = "INSERT INTO tbl_bugs(bug, bug_desc, screenshot, code, date_discovered, verified_status, date_verified) VALUES ('" + text_bug.Text + "','" + richTextBox_bugdesc.Text + "','" + ImageToBase64(pictureBox_screen.Image,System.Drawing.Imaging.ImageFormat.Png) + "','"+richTextBox_code.Text+"', '"+text_datedisc.Text+"', '"+verified+"', '"+ text_datever+ "')";
            string path = ConfigurationSettings.AppSettings["filePath"].ToString();
            //string path = Configuration
            string filename = Path.GetFileName(textBox_filepath.Text);
            File.Copy(textBox_filepath.Text, Path.Combine(@path, filename), true);

            string sql_add = "INSERT INTO tbl_bugs(project_name, bug, bug_desc, code, date_discovered, verified_status, date_verified, screenshot) VALUES ('"+comboBox_project.Text+"','" + text_bug.Text + "','" + richTextBox_bugdesc.Text + "','" + richTextBox_code.Text + "', '" + text_datedisc.Text + "', '" + verified + "', '" + text_datever.Text + "', '"+filename+"')";
            database_connect dc = new database_connect();
            MySqlCommand cmd = new MySqlCommand(sql_add, dc.Db_Connect());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved");
            datagrid();
            dc.CloseConnection();
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// browsing image
            /// </summary>
            OpenFileDialog dialog = new OpenFileDialog();
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|png|*.png|All files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            //if (res == DialogResult.OK)
            //{
            //    string imglocation = dialog.FileName;
            //    textBox_filepath.Text = imglocation;
            //    pictureBox_screen.Image = Image.FromFile(openFileDialog1.FileName);
            //}
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imglocation = dialog.FileName;
                textBox_filepath.Text = imglocation;
                pictureBox_screen.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void dataGridView_tester_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                string verified = radioButton_yes.Checked ? "Yes" : "No";
                DataGridViewRow row = dataGridView_tester.SelectedRows[0];
                text_bug.Text = row.Cells["bug"].Value.ToString();
                richTextBox_bugdesc.Text = row.Cells["bug_desc"].Value.ToString();
                richTextBox_code.Text = row.Cells["code"].Value.ToString();
                text_datedisc.Text = row.Cells["date_discovered"].Value.ToString();
                text_datever.Text = row.Cells["date_verified"].Value.ToString();
                richTextBox_solution.Text = row.Cells["solution"].Value.ToString();
                textBox_filepath.Text = row.Cells["screenshot"].Value.ToString();
                if (verified == "Yes")
                {
                    radioButton_yes.Checked = true;
                }
                else
                {
                    radioButton_no.Checked = true;
                }
                Image screen = Image.FromFile(@"C:\Users\daksh\source\repos\BugTrackingSystem\BugTrackingSystem\screens\" + textBox_filepath.Text, true);
                pictureBox_screen.Image = screen;
                //byte[] img = Convert.FromBase64String(row.Cells["screenshot"].Value.ToString());
                //pictureBox_screen.Image = img[];
                //database_connect dc = new database_connect();
                //string id = row.Cells["bug_id"].Value.ToString();
                //string sql_select = "SELECT screenshot FROM tbl_bugs WHERE bug_id = '"+id+"'";
                //MySqlCommand cmd = new MySqlCommand(sql_select);
                //MySqlDataReader dr = cmd.ExecuteReader();
                //while (dr.Read())
                //{
                //    pictureBox_screen.Image = Base64ToImage(dr[1].ToString());
                //}
                //pictureBox_screen.Image = Base64ToImage(row.Cells["screenshot"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView_tester.SelectedRows[0];
                String bugid = row.Cells["bug_id"].Value.ToString();
                string verified = radioButton_yes.Checked ? "Yes" : "No";
                string sql_update = "UPDATE tbl_bugs SET project_name = '"+comboBox_project.Text+"', bug='" + text_bug.Text + "', bug_desc='"  +richTextBox_bugdesc.Text + "', code='" + richTextBox_code.Text + "', date_discovered='"+ text_datedisc.Text + "', verified_status= '"+verified+"', date_verified = '" + text_datever.Text + "'  WHERE bug_id='" + bugid + "'";
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
                DialogResult dr = MessageBox.Show("Are you sure you want to delete the data?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridView_tester.SelectedRows[0];
                    String bugid = row.Cells["bug_id"].Value.ToString();
                    string sql_delete = "DELETE FROM tbl_bugs WHERE bug_id = '" + bugid + "'";
                    database_connect dc = new database_connect();
                    MySqlCommand cmd = new MySqlCommand(sql_delete, dc.Db_Connect());
                    cmd.ExecuteNonQuery();
                    datagrid();
                    dc.CloseConnection();

                    MessageBox.Show("Data has been deleted");
                }
                datagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_bug.Text = "";
            richTextBox_code.Text = "";
            richTextBox_bugdesc.Text = "";
            text_datedisc.Text = "";
            text_datever.Text = "";
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

        private void richTextBox_code_TextChanged(object sender, EventArgs e)
        {
            /// <summary>
            ///defining array in order to store predefined lists of identifiers
            ///</summary>
            string[] terms1 = new string[] { "class", "void", "private", "public", "string"};
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

        private void richTextBox_solution_TextChanged(object sender, EventArgs e)
        {
            //defining array in order to store predefined lists of identifiers
            string[] terms1 = new string[] { "class", "void", "private", "public", "string" };
            string[] terms2 = new string[] { "int", "float", "double", "{", "}","if","else"};
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tester_panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void tester_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void tester_panel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}