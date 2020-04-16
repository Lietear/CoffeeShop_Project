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
    public partial class Login : Form
    {
        private String StaffCode;
        private String StaffName;
        private String Gender;
        private String StaffLevel;
        // ประกาศตัวแปรไว้สำหรับเก็บค่า

        private string conn = "server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True;database=coffee;allowuservariables=True";
        //ประกาศตัวแปรเพื่อ connect ไว้สำหรับเชื่อมต่อกับ database
        int i;
        public Login()
        {
            InitializeComponent();
        }

        private void getTheName(String StaffID) // ดึงข้อมูล StaffCode,StaffName,Gender,StaffLevel จาก Database ด้วย userTextBox
        {
            MySqlConnection connection = new MySqlConnection(conn);
            connection.ConnectionString = conn;
            String query = "SELECT StaffCode,StaffName,Gender,StaffLevel FROM staffs WHERE StaffID = '" + userTextBox.Text + "'";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", StaffID);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    this.StaffCode = rdr["StaffCode"].ToString();
                    this.StaffName = rdr["StaffName"].ToString();
                    this.Gender = rdr["Gender"].ToString();
                    this.StaffLevel = rdr["StaffLevel"].ToString();

                }
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }
        }

        private void connect(String username, String password) //เชื่อมต่อกับฐานข้อมูลเพื่อตราวสอบว่าพบข้อมูลใน Database หรือไม่
        {
            i = 0;
            MySqlConnection connection = new MySqlConnection(conn);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staffs where StaffID ='" + username + "' and StaffPassword ='" + password + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0) //ไม่พบข้อมูลใน Database
            {
                MessageBox.Show("you have entered invalid ID or Password");
            }

            else //พบข้อมูลใน Database
            {
                this.getTheName(userTextBox.Text);
                this.Hide();
                string Code = this.StaffCode.Trim();
                string Name = this.StaffName.Trim();
                string Gen = this.Gender.Trim();
                string Level = this.StaffLevel.Trim();

                //ทำหน้า Mainmenu ของ Staffs แต่ละระดับ **ยังคิดไม่ออก
            }

            connection.Close();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            this.connect(userTextBox.Text, passTextBox.Text); //เรียกใช้ method connect เมื่อกดปุ่ม
        }
    }
}
