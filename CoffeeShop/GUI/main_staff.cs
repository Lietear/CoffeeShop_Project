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
    public partial class main_staff : Form
    {
        private String id;
        private String code;
        private String name;
        private String gen;
        private String level;
        public String ID
        {
            get { return id; }
            set { id = value; }
        }
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
        public main_staff(string ID, string Code, string Name, string Gen, string Level)
        {
            InitializeComponent();
            this.getName.Text = Name;
            this.getID.Text = Code;
            this.Code = Code;
            this.Name = Name;
            this.Gen = Gen;
            this.Level = Level;
            this.ID = ID;
        }
        public main_staff()
        {
            InitializeComponent();
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            Order order = new Order(ID, Code, Name, Gen, Level);
            order.Show();
        }

        private void history_button_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            register_customer register = new register_customer();
            register.Show();
        }
    }
}
