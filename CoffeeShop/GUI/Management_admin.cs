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
    public partial class Management_admin : Form
    {
        private string conDB = "server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True;database=coffee;allowuservariables=True";
        public Management_admin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(conDB);
            connection.ConnectionString = conDB;
            String query = "SELECT StaffID,StaffCode,StaffName,Gender,StaffLevel FROM staffs Where StaffID = @ID";
            connection.Open();
            if (txt_StaffID.Text != "")
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txt_StaffID.Text));
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    txt_StaffName.Text = data.GetValue(2).ToString();
                    txt_StaffCode.Text = data.GetValue(1).ToString();
                    gender_combo.Text = data.GetValue(3).ToString();
                    stafflevel_combo.Text = data.GetValue(4).ToString();
                    
                }
                connection.Close();
            }
        }

        private void txt_StaffCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string userid ="";
            if (stafflevel_combo.Text == "Admin")
            {
                Random rnd = new Random();
                int rnd1 = rnd.Next(0, 9);
                int rnd2 = rnd.Next(0, 9);
                int rnd3 = rnd.Next(0, 9);
                int rnd4 = rnd.Next(0, 9);
                int rnd5 = rnd.Next(0, 9);
                userid = "A" + rnd1 + rnd2 + rnd3 + rnd4 + rnd5;

            }
            else if (stafflevel_combo.Text == "Manager")
            {
                Random rnd = new Random();
                int rnd1 = rnd.Next(0, 9);
                int rnd2 = rnd.Next(0, 9);
                int rnd3 = rnd.Next(0, 9);
                int rnd4 = rnd.Next(0, 9);
                int rnd5 = rnd.Next(0, 9);
                userid = "M" + rnd1 + rnd2 + rnd3 + rnd4 + rnd5;

            }
            else if (stafflevel_combo.Text == "Staff")
            {
                Random rnd = new Random();
                int rnd1 = rnd.Next(0, 9);
                int rnd2 = rnd.Next(0, 9);
                int rnd3 = rnd.Next(0, 9);
                int rnd4 = rnd.Next(0, 9);
                int rnd5 = rnd.Next(0, 9);
                userid = "S" + rnd1 + rnd2 + rnd3 + rnd4 + rnd5;
            }
            string gender = gender_combo.Text;
            string level = stafflevel_combo.Text;
            MySqlConnection connection = new MySqlConnection(conDB);
            connection.ConnectionString = conDB;
            String query = "Update staffs Set StaffName = '" + txt_StaffName.Text + "',Gender = '" + gender + "' ,StaffCode = '" + userid + "',StaffLevel = '" + level + "' Where StaffID = '" + txt_StaffID.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("DataUpdate");
            txt_StaffName.Clear();
            txt_StaffName.Clear();
            txt_StaffName.Clear();
            txt_StaffCode.Clear();
            gender_combo.Text = "";
            stafflevel_combo.Text = "";

        }
    }
}
