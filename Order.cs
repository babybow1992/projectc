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
    public partial class Order : Form
    {
        private string admin;
        private int total;
        public Order(string admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        //public Order()
        //{
        //    InitializeComponent();
        //}

        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=stock");
        private int id = 0;

        private void database(string sql)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            DataTable dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            con.Close();

        }

        DataSet ds = new DataSet();

        public void showCart()
        {
            dataCartsInOrder.DataSource = null;
            con.Open();

            MySqlCommand cmd;

            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM carts WHERE admin = '" + admin + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            con.Close();
            dataCartsInOrder.DataSource = ds.Tables[0].DefaultView;
            int t = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                t += Convert.ToInt32(row["total"].ToString());
            }
            labelTotalAmount.Text = t.ToString();

        }

        public string[] dataCategory()
        {
            con.Open();
            List<string> list = new List<string>();
            string sql = "SELECT * FROM equipment ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr.GetString("category"));
            }
            con.Close();
            string[] category = list.Distinct().ToArray();
            return category;
        }

        public string[] dataMenuCategory(string category)
        {
            con.Open();
            List<string> list = new List<string>();
            string sql = "SELECT * FROM equipment WHERE category = '" + category + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr.GetString("name"));
            }
            con.Close();
            string[] listItemsCategory = list.Distinct().ToArray();
            return listItemsCategory;
        }

        public int[] dataListMenuCategory(string name)
        {
            con.Open();
            List<int> list = new List<int>();
            string sql = "SELECT * FROM equipment WHERE name = '" + name + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr.GetInt32("price"));
                list.Add(dr.GetInt32("quanitity"));
            }
            con.Close();
            int[] listItemsCategory = list.ToArray();
            return listItemsCategory;
        }

        public int dataIDInCard()
        {
            con.Open();
            List<int> list = new List<int>();
            string sql = "SELECT * FROM carts";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr.GetInt32("id"));
            }
            con.Close();
            int idCarts = 0;
            if (list.Count > 0)
            {
                 idCarts = list[list.Count - 1] + 1;

            }
            return idCarts;
        }

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
            cmd.CommandText = $"SELECT * FROM equipment";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

          

        }

        

        private void txtCategoryItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = txtCategoryItems.Text;
            Menu.Items.Clear();
            string[] listNameMenu = dataMenuCategory(category);
            foreach (string categoryItem in listNameMenu)
            {
                //MessageBox.Show(categoryItem);
                Menu.Items.Add(categoryItem);

            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtQuanitityInOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItemsInOrder_Click(object sender, EventArgs e)
        {
            AddItems ds = new AddItems(admin);
            this.Hide();
            ds.Show();
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

        private void Order_Load(object sender, EventArgs e)
        {
            id = dataIDInCard();
            showCart();
        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = txtPriceItemsInOrder.Text;
        }

        private void txtNameInOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string name = Menu.Items[Menu.SelectedIndex].ToString();
            txtNameInOrder.Text = name;
            int[] pq = dataListMenuCategory(name);
            txtPriceItemsInOrder.Text = pq[0].ToString();
            txtQuanitityInOrder.Maximum = Convert.ToInt32(pq[1]);
            txtTotalInOrder.Text = pq[0].ToString();
        }

        private void txtQuanitityInOrder_ValueChanged(object sender, EventArgs e)
        {

            string name = Menu.Items[Menu.SelectedIndex].ToString();
            int[] pq = dataListMenuCategory(name);
            decimal quan = txtQuanitityInOrder.Value;
            txtTotalInOrder.Text = (pq[0] * quan).ToString();
        }

        

        private void dataCartsInOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataCartsInOrder.CurrentRow.Selected = true;
        }

        private void btnRemoveInOrder_Click(object sender, EventArgs e)
        {
            int selectedRow = dataCartsInOrder.CurrentCell.RowIndex;
            string name = dataCartsInOrder.Rows[selectedRow].Cells["name"].FormattedValue.ToString();
            int quantity = Convert.ToInt32(dataCartsInOrder.Rows[selectedRow].Cells["Quantity"].Value);
            int total = Convert.ToInt32(dataCartsInOrder.Rows[selectedRow].Cells["total"].Value);

            DialogResult result = MessageBox.Show("confirm", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string sql = "DELETE FROM carts WHERE name ='" + name + "' AND id = '" + id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                {
                    MessageBox.Show("deleted");
                }
                showCart();
                int total2 = Convert.ToInt32(labelTotalAmount.Text);

                labelTotalAmount.Text = (total2 - total).ToString();
            }
        }

        private void btnAddToCardInOrder_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("ต้องการเพิ่มหรือไม่", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK)
            {
                string sql = "INSERT INTO carts(id,UnitPrice,name,Quantity,total,admin)VALUES('" + id + "','" + txtPriceItemsInOrder.Text + "','" + txtNameInOrder.Text + "','" + txtQuanitityInOrder.Value + "','" + txtTotalInOrder.Text + "','"+admin+"')";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                int menuTotal = Convert.ToInt32(txtTotalInOrder.Text);

                labelTotalAmount.Text = (total + menuTotal).ToString();
                total = Convert.ToInt32(labelTotalAmount.Text);
                showCart();
            }
        }
                

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Recipt", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(380,30));
            e.Graphics.DrawString("===================================================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(40, 80));
            e.Graphics.DrawString("Amount", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(40, 120));
            e.Graphics.DrawString("Name", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(400, 120));
            e.Graphics.DrawString("Price", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(700, 120));
            e.Graphics.DrawString("===================================================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(40, 160));
            int y = 200;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                e.Graphics.DrawString(row["Quantity"].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(40, y));
                e.Graphics.DrawString(row["name"].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(400, y));
                e.Graphics.DrawString(row["total"].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(700, y));
                y += 40;
            }
            e.Graphics.DrawString("===================================================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(40, y));
            y += 40;
            e.Graphics.DrawString("Total", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString(total.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, y));
            e.Graphics.DrawString("Baht", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(700, y));
        }

        private void btnPrintInOrder_Click(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            DialogResult re = MessageBox.Show("ยืนยันที่จะออกใบเสร็จหรือไม่", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK)
            {
                MySqlConnection conn = databaseConnection();
                MySqlCommand cmd;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string sql2 = "INSERT INTO history(id, name, price, amount, date, admin)VALUES('" + id + "','" + row["name"].ToString() + "','" + row["total"].ToString() + "','" + row["Quantity"].ToString() + "','" + now + "','" + admin + "')";
                    cmd = new MySqlCommand(sql2, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                string sql = "DELETE FROM carts  WHERE admin = '" + admin + "'";
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                total = Convert.ToInt32(labelTotalAmount.Text);

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                Order order = new Order(admin);
                this.Hide();
                order.Show();

                //Receipt receipt = new Receipt(total, id, admin);
                //receipt.Show();
                //this.Hide();
            }
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();
            //string sql = "SELECT nemu,จำนวน,รวม FROM history WHERE phone = '" + login.phonr + "' and status='0' ";
            //MySqlConnection con = new MySqlConnection(conn);
            //MySqlCommand cmd = new MySqlCommand(sql, con);
            //con.Open();
            //MySqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    sql = "UPDATE `history` SET status='1' WHERE phone = '" + login.phonr + "' and nemu='" + reader.GetString("nemu") + "' ";
            //    con = new MySqlConnection(conn);
            //    cmd = new MySqlCommand(sql, con);
            //    con.Open();
            //    int rows1_ = cmd.ExecuteNonQuery();
            //    con.Close();
            //}
            //sql = "UPDATE `counter` SET จ่าย='1' WHERE phone = '" + login.phonr + "' and name='" + login.nameU + "' ";
            //MessageBox.Show(sql);
            //con = new MySqlConnection(conn);
            //cmd = new MySqlCommand(sql, con);
            //con.Open();

                //int rows1__ = cmd.ExecuteNonQuery();
                //con.Close();
                //MessageBox.Show("จ่ายตังสำเร็จขอบคุณที่ใช้บริการ");
                //this.Hide();

        }

        private void AdminButt_Click(object sender, EventArgs e)
        {
            Admin a = new Admin(admin);
            this.Hide();
            a.Show();
        }
    }
}
