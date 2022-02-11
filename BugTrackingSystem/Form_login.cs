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

namespace BugTrackingSystem
{
    public partial class Form_login : Form
    {
        /// <summary>
        /// declaring bool and poing variables needed in order to drag the form for moving the program's position
        /// </summary>
        private bool mouseDown;
        private Point lastLocation;
        //declaring variables in order to pass user id and name to other user panels
        public static String idx, usernamex;
        public Form_login()
        {
            InitializeComponent();
            //initialing placeholder for text_user and text_password
            text_user.TextAlign = HorizontalAlignment.Center;
            text_password.TextAlign = HorizontalAlignment.Center;

            text_password.ForeColor = Color.Gray;
            text_user.ForeColor = Color.Gray;

            text_user.Text = "User";
            text_password.Text = "Password";
        }

        private void Form_login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form_login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        /// <summary>
        ///creating and processing placeholder for text_user
        ///</summary>
        private void text_user_Enter(object sender, EventArgs e)
        {
            if (text_user.Text == "User")
            {
                text_user.TextAlign = HorizontalAlignment.Left;
                text_user.ForeColor = Color.Black;
                text_user.Text = "";
            }
        }

        private void text_user_Leave(object sender, EventArgs e)
        {
            if (text_user.Text == "")
            {
                text_user.TextAlign = HorizontalAlignment.Center;
                text_user.ForeColor = Color.Gray;
                text_user.Text = "User";
            }
        }


        /// <summary>
        ///creating and processing placeholder for text_password
        ///</summary>
        private void text_password_Enter(object sender, EventArgs e)
        {
            if (text_password.Text == "Password")
            {
                text_password.TextAlign = HorizontalAlignment.Left;
                text_password.ForeColor = Color.Black;
                text_password.Text = "";
            }
        }

        private void text_password_Leave(object sender, EventArgs e)
        {
            if (text_password.Text == "")
            {
                text_password.TextAlign = HorizontalAlignment.Center;
                text_password.ForeColor = Color.Gray;
                text_password.Text = "Password";
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            try
            {
                //executing query when the login button is clicked
                database_connect dc = new database_connect();
                //string sql_login = "SELECT * FROM tbl_users";
                string veri = "no";
                string sql_signup = "INSERT INTO tbl_users (username, password, verified) VALUES ('" + text_user.Text + "', '" + text_password.Text+ "', '"+veri+"')";
                MySqlCommand cmd = new MySqlCommand(sql_signup, dc.Db_Connect());
                MySqlDataReader r = cmd.ExecuteReader();
                dc.CloseConnection();
                MessageBox.Show("The user is created, please wait further verification from admin");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void text_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button_login.PerformClick();
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                //executing query when the login button is clicked
                database_connect dc = new database_connect();
                string sql_login = "SELECT * FROM tbl_users WHERE username='" + text_user.Text + "' AND password = '" + text_password.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql_login, dc.Db_Connect());
                MySqlDataReader r = cmd.ExecuteReader();


                //switch case in order to open different panels for different type of users
                if (r.Read())
                {
                    String id = r.GetString("user_id");
                    String verified = r.GetString("verified");
                    idx = id;
                    String pos = r.GetString("position");
                    String user = r.GetString("username");
                    usernamex = user;
                    if (verified == "yes")
                    {
                        switch (pos)
                        {
                            case "Admin":
                                MessageBox.Show("Successfully logged in as " + user);
                                admin_panel ap = new admin_panel();
                                //label_admin.Text = text_user.Text;
                                ap.Show();
                                break;
                            case "Developer":
                                MessageBox.Show("Successfully logged in as " + user);
                                developer_panel dp = new developer_panel();
                                dp.Show();
                                break;
                            case "Tester":
                                MessageBox.Show("Successfully logged in as " + user);
                                tester_panel tp = new tester_panel();
                                tp.Show();
                                break;
                            default:
                                MessageBox.Show("Something went wrong try again!");
                                break;
                        }
                        this.Hide();
                        dc.CloseConnection();
                    }
                    else
                    {
                        MessageBox.Show("User unverified or non existant, please contact admin!");
                    }

                }
                else
                {
                    MessageBox.Show("Wrong username or password, Try again!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
