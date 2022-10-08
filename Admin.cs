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
    public partial class Admin : Form
    {
        private string admin;

        public Admin(string admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=stock;charset=utf8;";

            MySqlConnection con = new MySqlConnection(connectionString);

            return con;
        }

        private void showAdmin()
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

            listAdmin.DataSource = ds.Tables[0].DefaultView;

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            showAdmin();
        }

        private void btnRemoveInOrder_Click(object sender, EventArgs e)
        {
            int selectedRow = listAdmin.CurrentCell.RowIndex;
            string id = listAdmin.Rows[selectedRow].Cells["id"].Value.ToString();

            MySqlConnection con = databaseConnection();

            string sql = "DELETE FROM admin WHERE id = '" + id + "'";
            DialogResult re = MessageBox.Show("ต้องการลบหรือไม่", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK)
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("ลบแล้ว");
                    showAdmin();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 8)
            {
                int count = listAdmin.RowCount;
                string id = "";
                if (count.ToString().Length == 1)
                {
                    id = "000" + count.ToString();
                }
                else if (count.ToString().Length == 2)
                {
                    id = "00" + count.ToString();
                }
                else if (count.ToString().Length == 3)
                {
                    id = "0" + count.ToString();
                }
                else if (count.ToString().Length == 4)
                {
                    id = count.ToString();
                }

                MySqlConnection con = databaseConnection();
                string sql = "INSERT INTO `admin`(`id`, `username`, `password`) VALUES ('" + id + "','" + txtUsername.Text + "','" + txtPassword.Text + "')";
                DialogResult re = MessageBox.Show("ต้องการเพิ่มหรือไม่", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (re == DialogResult.OK)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    con.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("ทำการเพิ่มสำเร็จ");
                        showAdmin();
                    }
                }
            }
            else
            {
                MessageBox.Show("password ต้องมี 8 ตัว");
            }
        }

        private void btnUpdateItemsInOrder_Click(object sender, EventArgs e)
        {
            UpdateItems ds = new UpdateItems(admin);
            this.Hide();
            ds.Show();
        }

        private void btnRemoveItemsInOrder_Click(object sender, EventArgs e)
        {
            RemoveItems ds = new RemoveItems(admin);
            this.Hide();
            ds.Show();
        }

        private void btnHistoryInOrder_Click(object sender, EventArgs e)
        {
            History ds = new History(admin);
            this.Hide();
            ds.Show();
        }

        private void btnLogoutInOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }

        private void btnExitInOrder_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order(admin);
            this.Hide();
            order.Show();
        }

        private void btnAddItemsInOrder_Click_1(object sender, EventArgs e)
        {
            AddItems ds = new AddItems(admin);
            this.Hide();
            ds.Show();
        }
    }
}
