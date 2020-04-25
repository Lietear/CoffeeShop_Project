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
    public partial class register_customer : Form
    {
        private string conDB = "server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True;database=coffee;allowuservariables=True";
        public register_customer()
        {
            InitializeComponent();
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            int point = 100;
            MySqlConnection connection = new MySqlConnection(conDB);
            connection.ConnectionString = conDB;
            String query = "INSERT INTO customers(CustomerName,Gender,CustomerType,CustomerTelNo,Points) VALUES ('" + txt_name.Text + "','" + gen_combo.Text + "','" + type_combo.Text + "','" + txt_phone.Text + "','" + point + "')";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Register Complete");
            txt_name.Clear();
            gen_combo.Text = "";
            type_combo.Text = "";
            txt_phone.Clear();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
    }
}
