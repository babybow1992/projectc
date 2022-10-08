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
namespace reallyreallylast
{
    public partial class History : Form
    {

        private string admin;
        private int total;

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=stock;charset=utf8;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=stock");
        DataTable mainTable = new DataTable();

        private void database(string sql)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            DataTable dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            Historydataequiment.DataSource = dt;
            con.Close();
        }
        private void showEquipment()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM history";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            Historydataequiment.DataSource = ds.Tables[0].DefaultView;

            int t = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                t += Convert.ToInt32(row["price"].ToString());
            }
            totalTxt.Text = t.ToString();
        }
        public History(string admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {
            showEquipment();
        }

        private void DateShow()
        {
            //string date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            //if(date== "" )
            //{
            //    Sql = "SELECT * FROM carts ";

            //}
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login ds = new Login();
            this.Hide();
            ds.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Order ds = new Order(admin);
            this.Hide();
            ds.Show();
        }

        private void btnAdditemsInHis_Click(object sender, EventArgs e)
        {
            AddItems ds = new AddItems(admin);
            this.Hide();
            ds.Show();
        }

        private void btnUpdateItemsInHis_Click(object sender, EventArgs e)
        {
            UpdateItems ds = new UpdateItems(admin);
            this.Hide();
            ds.Show();
        }

        private void btnRemoveItemsInHis_Click(object sender, EventArgs e)
        {
            RemoveItems ds = new RemoveItems(admin);
            this.Hide();
            ds.Show();
        }

        private void btnEnterInHistory_Click(object sender, EventArgs e)
        {
            string datePick = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string adminName = txtsearch.Text;
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM history WHERE (admin = '"+adminName+"' AND date = '"+datePick+"')";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            Historydataequiment.DataSource = ds.Tables[0].DefaultView;

            int t = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                t += Convert.ToInt32(row["price"].ToString());
            }
            totalTxt.Text = t.ToString();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string adminName = txtsearch.Text;
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM history WHERE admin = '" + adminName + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            Historydataequiment.DataSource = ds.Tables[0].DefaultView;

            int t = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                t += Convert.ToInt32(row["price"].ToString());
            }
            totalTxt.Text = t.ToString();
        }
    }
}
