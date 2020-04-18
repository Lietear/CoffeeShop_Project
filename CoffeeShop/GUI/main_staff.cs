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
        public main_staff(string Code, string Name, string Gen, string Level)
        {
            InitializeComponent();
            this.getName.Text = Name;
            this.getID.Text = Code;
        }
        public main_staff()
        {
            InitializeComponent();
        }
    }
}
