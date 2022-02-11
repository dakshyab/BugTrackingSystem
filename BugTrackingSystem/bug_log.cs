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
    public partial class bug_log : Form
    {
        public bug_log()
        {
            InitializeComponent();
        }

        private void bug_log_Load(object sender, EventArgs e)
        {
            try
            {
                //executing query and extracting records from database when the tester panel button is loaded in order to display records
                database_connect dc = new database_connect();
                string sql_bugs = "SELECT * FROM tbl_buglog";
                MySqlCommand cmd = new MySqlCommand(sql_bugs, dc.Db_Connect());
                DataTable dt = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                dt.Clear();
                msda.Fill(dt);
                dataGridView_log.DataSource = dt;
                dc.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
