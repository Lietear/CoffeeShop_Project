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
    public partial class Order : Form
    {
        private string conDB = "server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True;database=coffee;allowuservariables=True";
        public Order(string Code, string Name, string Gen, string Level)
        {
            InitializeComponent();
            this.StaffName_text.Text = Name;
            Fillcombo();
        }
        public Order()
        {
            InitializeComponent();
        }
        public void Fillcombo()
        {
            MySqlConnection connection = new MySqlConnection(conDB);
            connection.ConnectionString = conDB;
            String query = "SELECT * FROM products";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string sName = rdr.GetString("ProductName");
                    menulist.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menulist_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(conDB);
            connection.ConnectionString = conDB;
            String query = "SELECT * FROM products Where ProductName = '" + menulist.Text + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string price = (string)rdr["Price"].ToString();
                txt_price.Text = price;
            }
            connection.Close();
            
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                txt_total.Text = (Convert.ToInt16(txt_price.Text) * Convert.ToInt16(txt_qty.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = menulist.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);
            txt_sub.Text = (Convert.ToInt16(txt_sub.Text)+Convert.ToInt16(txt_total.Text)).ToString();
        }

        private void txt_nat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        listView1.Items[i].Remove();
                    }
                }
            }
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {

        }

        private void txt_point_TextChanged(object sender, EventArgs e)
        {
            if(txt_point.Text.Length > 0)
            {
                txt_net.Text = (Convert.ToInt16(txt_sub.Text) - (Convert.ToInt16(txt_point.Text)/10)).ToString();
            }
        }

        private void txt_receive_TextChanged(object sender, EventArgs e)
        {
            if(txt_receive.Text.Length > 0)
            {
                txt_balance.Text = (Convert.ToInt16(txt_receive.Text) - Convert.ToInt16(txt_net.Text)).ToString();
            }
        }
    }
}
