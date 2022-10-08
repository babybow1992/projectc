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
    public partial class UpdateItems : Form
    {
        private string admin;

        public UpdateItems(string admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

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
            UpdatedataequimentInUp.DataSource = dt;
            con.Close();
        }
        private void showEquipment()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM equipment";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            UpdatedataequimentInUp.DataSource = ds.Tables[0].DefaultView;


        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            RemoveItems ds = new RemoveItems(admin);
            this.Hide();
            ds.Show();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login ds = new Login();
            this.Hide();
            ds.Show();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtCategoryItemsInUp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHistoryInUp_Click(object sender, EventArgs e)
        {
            History ds = new History(admin);
            this.Hide();
            ds.Show();
        }

        private void btnUpdateInUp_Click(object sender, EventArgs e)
        {
            int selectedRow = UpdatedataequimentInUp.CurrentCell.RowIndex;
            int id = Convert.ToInt32(UpdatedataequimentInUp.Rows[selectedRow].Cells["id"].Value);
            string sql = "UPDATE equipment SET category = '" + txtCategoryInUp.Text + "',name = '" + txtNameInUp.Text + "',price = '" + txtPriceInUp.Text + "',quanitity = '" + txtQuanitityInUp.Text + "' WHERE id = '" + id + "'";
            DialogResult re = MessageBox.Show("ยืนยันที่จะอัพเดทหรือไม่", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK)
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                {
                    MessageBox.Show("อัพเดตแล้วเรียบร้อย");
                    showEquipment();
                }
            }
           
        }

        private void UpdateItems_Load(object sender, EventArgs e)
        {
            showEquipment();
        
           
        }

        private void UpdatedataequimentInUp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtCategoryInUp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdatedataequimentInUp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdatedataequimentInUp.CurrentRow.Selected = true;
            txtCategoryInUp.Text = UpdatedataequimentInUp.Rows[e.RowIndex].Cells["category"].FormattedValue.ToString();
            txtNameInUp.Text = UpdatedataequimentInUp.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            txtPriceInUp.Text = UpdatedataequimentInUp.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
            txtQuanitityInUp.Text = UpdatedataequimentInUp.Rows[e.RowIndex].Cells["quanitity"].FormattedValue.ToString();
        }

       
    }
}
