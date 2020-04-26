using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop.GUI
{
    public partial class main_admin : Form
    {
        private String code;
        private String name;
        private String gen;
        private String level;
        public String Code
        {
            get { return code; }
            set { code = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Gen
        {
            get { return gen; }
            set { gen = value; }
        }
        public String Level
        {
            get { return level; }
            set { level = value; }
        }
        public main_admin(string Code, string Name, string Gen, string Level)
        {
            InitializeComponent();
            this.getName.Text = Name;
            this.getID.Text = Code;
            this.Code = Code;
            this.Name = Name;
            this.Gen = Gen;
            this.Level = Level;
        }
        public main_admin()
        {
            InitializeComponent();
        }
        private void order_button_Click(object sender, EventArgs e)
        {
            Order order = new Order(Code, Name, Gen, Level);
            order.Show();
        }

        private void management_button_Click(object sender, EventArgs e)
        {
            Management_admin management_Admin = new Management_admin();
            management_Admin.Show();
        }
        private void reg_button_Click(object sender, EventArgs e)
        {
            register_customer register_Customer = new register_customer();
            register_Customer.Show();
        }

        private void addproduct_button_Click(object sender, EventArgs e)
        {
            ProductMenu productMenu = new ProductMenu();
            productMenu.Show();
        }

        private void history_button_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }
    }
}
