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
        public ProductMenu()
        {
            InitializeComponent();
            pnum.Text = "00";
            pname.Text = "Product Name";
            pprice.Text = "0.00";
            pdetail.Text = "";
            pdetail.Text = "Detail";
            select.SelectedIndex = 0;
            conn.Open();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            int productnum = int.Parse(pnum.Text);
            string productname = pname.Text;
            float price = float.Parse(pprice.Text);
            string productdetail = pdetail.Text;
            string Query = "";
            if (this.select.SelectedIndex == 0)
            {
                Query = "INSERT INTO products(ProductName,Price,ProductDetail) VALUES('" + productname + "'," + price + ",'" + productdetail + "')";
            }
            MySqlCommand command = new MySqlCommand(Query, conn);
            command.ExecuteNonQuery();
        }
    }
}
