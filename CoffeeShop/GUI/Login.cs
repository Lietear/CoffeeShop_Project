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
        private String StaffID;
        private String GetStaffID;
        private String StaffCode;
        private String StaffName;
        private String Gender;
        private String StaffLevel;
        // ประกาศตัวแปรไว้สำหรับเก็บค่า

        private string conDB = "server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True;database=coffee;allowuservariables=True";
        //ประกาศตัวแปรเพื่อ connect ไว้สำหรับเชื่อมต่อกับ database
        int i;
        public Login()
        {
            InitializeComponent();
        }

        private void getTheName(String StaffID) // ดึงข้อมูล StaffCode,StaffName,Gender,StaffLevel จาก Database ด้วย userTextBox
        {
            MySqlConnection connection = new MySqlConnection(conDB);
            connection.ConnectionString = conDB;
            String query = "SELECT * FROM staffs WHERE StaffID = '" + userTextBox.Text + "'";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", StaffID);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    this.GetStaffID = rdr["StaffID"].ToString();
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
            MySqlConnection connection = new MySqlConnection(conDB);
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
                string ID = this.GetStaffID.Trim();
                string Code = this.StaffCode.Trim();
                string Name = this.StaffName.Trim();
                string Gen = this.Gender.Trim();
                string Level = this.StaffLevel.Trim();

                if (Level == "Admin") //เข้าหน้า main_menu สำหรับ Admin (ยังไม่สร้าง)
                {
                    main_admin main_Admin = new main_admin(ID,Code,Name,Gen,Level);
                    main_Admin.Show();
                }
                
                else if(Level == "Maneger")//เข้าหน้า main_menu สำหรับ Maneger (ยังไม่สร้าง)
                {
                    main_manager main_Manager = new main_manager(ID,Code, Name, Gen, Level);
                    main_Manager.Show();
                }

                else if (Level == "Staff") //เข้าหน้า main_menu สำหรับ Staff (ยังไม่สร้าง)
                {
                    main_staff main_Staff = new main_staff(ID,Code, Name, Gen, Level);
                    main_Staff.Show();
                }

                else //ประกาศข้อความแสดงความผิดพลาดเมื่อพบข้อมูลแต่ Level ไม่อยู่ในฐานข้อมูล
                {
                    MessageBox.Show("Data error,Please contact the administrator");
                    
                }
            }

            connection.Close();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            this.connect(userTextBox.Text, passTextBox.Text); //เรียกใช้ method connect เมื่อกดปุ่ม
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
