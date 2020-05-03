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
    public partial class customer : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True;database=coffee;allowuservariables=True");
        int status;
        string ID;
        public customer()
        {
            InitializeComponent();
            conn.Open();
            dataGridView1.DataSource = null;
            MySqlDataAdapter sqlddb = new MySqlDataAdapter("Select * From customers Order By CustomerID", conn);
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
            gen_combo.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            txt_name.Text = this.dataGridView1.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
            txt_phone.Text = this.dataGridView1.Rows[e.RowIndex].Cells["CustomerTelNo"].Value.ToString();
            type_combo.Text = this.dataGridView1.Rows[e.RowIndex].Cells["CustomerType"].Value.ToString();
            select.Enabled = true;
            select.SelectedIndex = 0;
            ID = this.dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            page2.Hide();
            page1.Show();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string Query = "";
            if (status == 1)
            {
                Query = "UPDATE customers SET CustomerName = '" + txt_name.Text + "' , CustomerTelNo = " + txt_phone.Text + " , Gender = '" + gen_combo.Text + "'WHERE CustomerID =" + ID;
            }
            if (status == 2)
            {
                Query = "DELETE FROM customers WHERE CustomerID =" + ID;
            }
            MySqlCommand command = new MySqlCommand(Query, conn);
            command.ExecuteNonQuery();
            dataGridView1.DataSource = null;
            MySqlDataAdapter sqlddb = new MySqlDataAdapter("Select * From customers Order By CustomerID", conn);
            DataTable tbdb = new DataTable();
            sqlddb.Fill(tbdb);
            dataGridView1.DataSource = tbdb;
            page2.Hide();
            page1.Show();
        }

        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select.SelectedIndex == 0)
            {
                txt_name.Enabled = true;
                txt_phone.Enabled = true;
                gen_combo.Enabled = true;
                type_combo.Enabled = true;
                status = 1;
            }
            if (select.SelectedIndex == 1)
            {
                txt_name.Enabled = false;
                txt_phone.Enabled = false;
                gen_combo.Enabled = false;
                type_combo.Enabled = false;
                status = 2;
            }
        }
    }
}
