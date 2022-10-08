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
    public partial class Receipt : Form
    {
        private int total;
        private int id;
        private string admin;
        public Receipt(int total, int id, string admin)
        {
            this.total = total;
            this.id = id;
            this.admin = admin;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=stock;charset=utf8;Convert Zero Datetime=True;";

            MySqlConnection con = new MySqlConnection(connectionString);

            return con;
        }

        private void showReciptList()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM history WHERE id = "+id;

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            receiptList.DataSource = ds.Tables[0].DefaultView;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            price.Text = total.ToString();
            showReciptList();
        }

        private void btnExitInOrder_Click(object sender, EventArgs e)
        {
            Order or = new Order(admin);
            this.Hide();
            or.Show();
        }
    }
}
