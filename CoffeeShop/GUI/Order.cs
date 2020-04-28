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
        string ID;
        public Order(string ID,string Code, string Name, string Gen, string Level)
        {
            InitializeComponent();
            this.StaffName_text.Text = Name;
            this.CodeID.Text = Code;
            Fillcombo();
            this.ID = ID;
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
                        txt_sub.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(listView1.Items[1].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString();
            MySqlConnection connection = new MySqlConnection(conDB);
            connection.ConnectionString = conDB;
            connection.Open();
            string Codestaff = ID;
            string customerID = txt_customer.Text;
            string Query = "INSERT INTO sales(SaleDateTime,CustomerID,StaffID,GrandTotal) VALUES('" + time + "','" + customerID + "','" + Codestaff + "','" + txt_sub.Text + "')";
            MySqlCommand command = new MySqlCommand(Query, connection);
            command.ExecuteNonQuery();
            foreach (ListViewItem item in this.listView1.Items)
            {
                String pname = item.SubItems[0].Text;
                String price = item.SubItems[1].Text;
                String quantity = item.SubItems[2].Text;
                String amount = item.SubItems[3].Text;
                Query = "INSERT INTO sale_details SELECT null,SaleID,ProductID,'" + price + "','" + quantity + "','" + amount + "'" +
                                                  "FROM sales,products " +
                                                  "WHERE SaleDateTime ='" + time + "'AND ProductName ='" + pname + "'";
                command = new MySqlCommand(Query, connection);
                command.ExecuteNonQuery();
               
            }
            if (txt_point.Text != "0")
            {
                int point = (Convert.ToInt16(txt_getpoint.Text) - Convert.ToInt16(txt_point.Text));
                string Query2 = "UPDATE Customers SET Points = '" + point + "'";
                command = new MySqlCommand(Query2, connection);
                command.ExecuteNonQuery();
            }
            else
            {
                int point = (Convert.ToInt16(txt_getpoint.Text) + (Convert.ToInt16(txt_sub.Text) / 10));
                string Query2 = "UPDATE Customers SET Points = '" + point + "'";
                command = new MySqlCommand(Query2, connection);
                command.ExecuteNonQuery();
            }

            listView1.Clear();
            txt_customer.Clear();
            txt_sub.Text = "0";
            connection.Close();
            MessageBox.Show("Completed purchase");
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
        public void getPoint(string customerID)
        {
            MySqlConnection connection = new MySqlConnection(conDB);
            connection.ConnectionString = conDB;
            String query = "SELECT * FROM customers WHERE CustomerID='" + customerID + "' ";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string point = rdr.GetString("Points");
                    txt_getpoint.Text = point;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            getPoint(txt_customer.Text);
        }
    }
}
