﻿using System;
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
    public partial class History : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True;database=coffee;allowuservariables=True");
        public History()
        {
            InitializeComponent();
            conn.Open();
            page2.Hide();
            page1.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string saleID = this.dataGridView1.Rows[e.RowIndex].Cells["SaleID"].Value.ToString();
            page1.Hide();
            page2.Show();
            dataGridView2.DataSource = null;
            MySqlDataAdapter sqlddb = new MySqlDataAdapter("Select * From sale_details Where SaleID =" + saleID, conn);
            DataTable tbdb = new DataTable();
            sqlddb.Fill(tbdb);
            dataGridView2.DataSource = tbdb;
        }

        private void show_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string dateserch = this.date2.Value.ToString("d/M/yyyy");
            MySqlDataAdapter sqlddb = new MySqlDataAdapter("Select SaleID,CustomerID,StaffID,GrandTotal From sales WHERE SaleDateTime like '" + dateserch + "%'", conn);
            DataTable tbdb = new DataTable();
            sqlddb.Fill(tbdb);
            dataGridView1.DataSource = tbdb;
            decimal val = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                val += Convert.ToDecimal(item.Cells[3].Value);
            }
            balanceTxt.Text = "Balance = " + val.ToString();
        }

        private void shw_all_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            MySqlDataAdapter sqlddb = new MySqlDataAdapter("Select * From sales Order By SaleDateTime", conn);
            DataTable tbdb = new DataTable();
            sqlddb.Fill(tbdb);
            dataGridView1.DataSource = tbdb;
            decimal val = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                val += Convert.ToDecimal(item.Cells[4].Value);
            }
            balanceTxt.Text = "Balance = " + val.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            page2.Hide();
            page1.Show();
            dataGridView1.DataSource = null;
        }
    }
}