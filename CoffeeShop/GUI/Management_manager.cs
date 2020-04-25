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
    public partial class Management_manager : Form
    {
        public Management_manager()
        {
            InitializeComponent();
        }
        private string conDB = "server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True;database=coffee;allowuservariables=True";
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(conDB);
            connection.ConnectionString = conDB;
            String query = "SELECT StaffID,StaffCode,StaffName,Gender,StaffLevel FROM staffs Where StaffID = @ID And StaffLevel IS 'Staff'";
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
           string userid = "";
           if (stafflevel_combo.Text == "Staff")
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
            String query = "INSERT INTO staffs(StaffID,StaffCode,StaffName,Gender,StaffPassword,StaffLevel) VALUES ('" + txt_StaffID.Text + "','" + userid + "','" + txt_StaffName.Text + "','" + gender + "','" + txt_pass.Text + "','" + level +"')";
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

        private void delete_button_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(conDB);
            connection.ConnectionString = conDB;
            String query = "DELETE FROM staffs WHERE StaffID = '" + txt_StaffID.Text + "' AND StaffLevel IS 'Staff'";
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
