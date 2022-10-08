using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reallyreallylast
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=stock;charset=utf8;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }

        //private void ContinueAsGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    dashboard ds = new dashboard();
        //    this.Hide();
        //    ds.Show();
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM admin";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            bool isFound = false;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (txtUsername.Text == row["username"].ToString() && txtPassword.Text == row["password"].ToString())
                {
                    isFound = true;
                }
            }

            if (isFound)
            {
                MessageBox.Show("เข้าสู่ระบบสำเร็จ");
                Order or = new Order(txtUsername.Text);
                or.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("username หรือ password ไม่ถูกต้อง");
            }
            

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
