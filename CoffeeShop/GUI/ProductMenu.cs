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

namespace CoffeeShop.GUI
{
    public partial class ProductMenu : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True;database=coffee;allowuservariables=True");
        int status;
        public ProductMenu()
        {
            InitializeComponent();
            conn.Open();
            dataGridView1.DataSource = null;
            MySqlDataAdapter sqlddb = new MySqlDataAdapter("Select * From products Order By ProductID", conn);
            DataTable tbdb = new DataTable();
            sqlddb.Fill(tbdb);
            dataGridView1.DataSource = tbdb;
            page2.Hide();
            page1.Show();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string Query = "";
            if (status == 0)
            {
                Query = "INSERT INTO products(ProductName,Price,ProductDetail) VALUES('" + pname.Text + "'," + pprice.Text + ",'" + pdetail.Text + "')";
            }
            if (status == 1)
            {
                Query = "UPDATE products SET ProductName = '" + pname.Text + "' , Price = " + pprice.Text + " , ProductDetail = '" + pdetail.Text + "'WHERE ProductID =" + pnum.Text;
            }
            if (status == 2)
            {
                Query = "DELETE FROM products WHERE ProductID =" + pnum.Text;
            }
            MySqlCommand command = new MySqlCommand(Query, conn);
            command.ExecuteNonQuery();
            dataGridView1.DataSource = null;
            MySqlDataAdapter sqlddb = new MySqlDataAdapter("Select * From products Order By ProductID", conn);
            DataTable tbdb = new DataTable();
            sqlddb.Fill(tbdb);
            dataGridView1.DataSource = tbdb;
            page2.Hide();
            page1.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            page1.Hide();
            page2.Show();
            pnum.Enabled = false;
            pnum.Text = this.dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
            pname.Text = this.dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            pprice.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            pdetail.Text = this.dataGridView1.Rows[e.RowIndex].Cells["ProductDetail"].Value.ToString();
            select.Enabled = true;
            select.SelectedIndex = 0;
        }

        private void add_Click(object sender, EventArgs e)
        {
            page1.Hide();
            page2.Show();
            pnum.Enabled = false;
            select.Enabled = false;
            pname.Enabled = true;
            pprice.Enabled = true;
            pdetail.Enabled = true;
            select.Text = "";
            pnum.Text = "00";
            pname.Text = "Product Name";
            pprice.Text = "0.00";
            pdetail.Text = "Detail";
            status = 0;
        }

        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select.SelectedIndex == 0)
            {
                pname.Enabled = true;
                pprice.Enabled = true;
                pdetail.Enabled = true;
                status = 1;
            }
            if (select.SelectedIndex == 1)
            {
                pname.Enabled = false;
                pprice.Enabled = false;
                pdetail.Enabled = false;
                status = 2;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            page2.Hide();
            page1.Show();
        }
    }
}
