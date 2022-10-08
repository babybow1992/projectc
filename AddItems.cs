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
    public partial class AddItems : Form
    {
        private string admin;

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=stock;charset=utf8;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
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

            listitems.DataSource = ds.Tables[0].DefaultView;


        }
        public AddItems(string admin)
        {
            this.admin = admin;
            InitializeComponent();
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

        private void AddItems_Load(object sender, EventArgs e)
        {
            showEquipment();
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

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login ds = new Login();
            this.Hide();
            ds.Show();

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History ds = new History(admin);
            this.Hide();
            ds.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCategoryItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            MySqlConnection con = databaseConnection();
            string sql = "INSERT INTO equipment(category,name,price,quanitity)VALUES('"+txtCategoryInAdd.Text+"','"+txtNameItems.Text+"','"+ txtQuanitityItems.Text+ "','"+ txtPriceItems.Text+"')";
            DialogResult re = MessageBox.Show("ต้องการเพิ่มหรือไม่", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK)
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("เพิ่มแล้ว");
                    showEquipment();
                }
            }       
        
        }
        public void clearAll()
        {
            txtCategoryInAdd.SelectedIndex = -1;
            txtNameItems.Clear();
            txtPriceItems.Clear();
            txtQuanitityItems.Clear();
        }

        private void listitems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showEquipment();
        }

        private void txtNameItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
