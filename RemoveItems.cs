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
    public partial class RemoveItems : Form
    {
        private string admin;
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
            Removedataequiment.DataSource = dt;
            con.Close();
        }
        private void showEquipment()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM equipment";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            Removedataequiment.DataSource = ds.Tables[0].DefaultView;


        }
        public RemoveItems(string admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order ds = new Order(admin);
            this.Hide();
            ds.Show();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            AddItems ds = new AddItems(admin);
            this.Hide();
            ds.Show();

        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            UpdateItems ds = new UpdateItems(admin);
            this.Hide();
            ds.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            History ds = new History(admin);
            this.Hide();
            ds.Show();
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login ds = new Login();
            this.Hide();
            ds.Show();
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {

        }

        private void RemoveItems_Load(object sender, EventArgs e)
        {
            showEquipment();

        }

        private void btnRemoveInRe_Click(object sender, EventArgs e)
        {
            int selectedRow = Removedataequiment.CurrentCell.RowIndex;
            int id = Convert.ToInt32(Removedataequiment.Rows[selectedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();

            string sql = "DELETE FROM equipment  WHERE id = '" + id + "'";
            DialogResult re = MessageBox.Show("ต้องการลบหรือไม่", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK)
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("ลบแล้ว");
                    showEquipment();
                }
            }
        }

        private void Removedataequiment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showEquipment();
        }

        private void Removedataequiment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Removedataequiment.CurrentRow.Selected = true;
            int select = Removedataequiment.CurrentCell.RowIndex;
            int id = Convert.ToInt32(Removedataequiment.Rows[select].Cells["id"].FormattedValue.ToString());
            string name = Removedataequiment.Rows[select].Cells["name"].FormattedValue.ToString();
            int quan = Convert.ToInt32(Removedataequiment.Rows[select].Cells["quanitity"].FormattedValue.ToString());
            int price = Convert.ToInt32(Removedataequiment.Rows[select].Cells["price"].FormattedValue.ToString());

    
           // txtCategoryInUp.Text = UpdatedataequimentInUp.Rows[e.RowIndex].Cells["category"].FormattedValue.ToString();
            //txtNameInUp.Text = UpdatedataequimentInUp.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            //txtPriceInUp.Text = UpdatedataequimentInUp.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
           // txtQuanitityInUp.Text = UpdatedataequimentInUp.Rows[e.RowIndex].Cells["quanitity"].FormattedValue.ToString();
        }
    
    }
}
