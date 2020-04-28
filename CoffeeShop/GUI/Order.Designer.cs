namespace CoffeeShop.GUI
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.StaffName_text = new System.Windows.Forms.Label();
            this.confirm_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menulist = new System.Windows.Forms.ComboBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.txt_point = new System.Windows.Forms.TextBox();
            this.txt_net = new System.Windows.Forms.TextBox();
            this.txt_receive = new System.Windows.Forms.TextBox();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_getpoint = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CodeID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // StaffName_text
            // 
            this.StaffName_text.AutoSize = true;
            this.StaffName_text.Location = new System.Drawing.Point(65, 19);
            this.StaffName_text.Name = "StaffName_text";
            this.StaffName_text.Size = new System.Drawing.Size(29, 13);
            this.StaffName_text.TabIndex = 1;
            this.StaffName_text.Text = "Staff";
            // 
            // confirm_button
            // 
            this.confirm_button.BackColor = System.Drawing.Color.Firebrick;
            this.confirm_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirm_button.Location = new System.Drawing.Point(416, 422);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(144, 23);
            this.confirm_button.TabIndex = 21;
            this.confirm_button.Text = "Confirm";
            this.confirm_button.UseVisualStyleBackColor = false;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Select Menu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // menulist
            // 
            this.menulist.FormattingEnabled = true;
            this.menulist.Location = new System.Drawing.Point(138, 64);
            this.menulist.Name = "menulist";
            this.menulist.Size = new System.Drawing.Size(374, 21);
            this.menulist.TabIndex = 25;
            this.menulist.SelectedIndexChanged += new System.EventHandler(this.menulist_SelectedIndexChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(85, 117);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 26;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(203, 117);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 20);
            this.txt_qty.TabIndex = 27;
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(327, 117);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 28;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(433, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 31);
            this.button1.TabIndex = 29;
            this.button1.Text = "Add Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Total";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 176);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(533, 142);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 330;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 68;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 67;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "PhoneNumber";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_customer
            // 
            this.txt_customer.Location = new System.Drawing.Point(316, 19);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(121, 20);
            this.txt_customer.TabIndex = 45;
            this.txt_customer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(433, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 27);
            this.button2.TabIndex = 46;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_sub
            // 
            this.txt_sub.Location = new System.Drawing.Point(85, 324);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.Size = new System.Drawing.Size(100, 20);
            this.txt_sub.TabIndex = 47;
            this.txt_sub.Text = "0";
            this.txt_sub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_point
            // 
            this.txt_point.Location = new System.Drawing.Point(255, 324);
            this.txt_point.Name = "txt_point";
            this.txt_point.Size = new System.Drawing.Size(100, 20);
            this.txt_point.TabIndex = 48;
            this.txt_point.TextChanged += new System.EventHandler(this.txt_point_TextChanged);
            // 
            // txt_net
            // 
            this.txt_net.Location = new System.Drawing.Point(416, 324);
            this.txt_net.Name = "txt_net";
            this.txt_net.Size = new System.Drawing.Size(144, 20);
            this.txt_net.TabIndex = 49;
            // 
            // txt_receive
            // 
            this.txt_receive.Location = new System.Drawing.Point(416, 350);
            this.txt_receive.Name = "txt_receive";
            this.txt_receive.Size = new System.Drawing.Size(144, 20);
            this.txt_receive.TabIndex = 50;
            this.txt_receive.TextChanged += new System.EventHandler(this.txt_receive_TextChanged);
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(416, 376);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(144, 20);
            this.txt_balance.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "SubTotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Use Points";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(386, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Net";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(363, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Receive";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Balance";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(443, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Points";
            // 
            // txt_getpoint
            // 
            this.txt_getpoint.Location = new System.Drawing.Point(485, 19);
            this.txt_getpoint.Name = "txt_getpoint";
            this.txt_getpoint.Size = new System.Drawing.Size(75, 20);
            this.txt_getpoint.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 36);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "ID";
            // 
            // CodeID
            // 
            this.CodeID.AutoSize = true;
            this.CodeID.Location = new System.Drawing.Point(68, 36);
            this.CodeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodeID.Name = "CodeID";
            this.CodeID.Size = new System.Drawing.Size(32, 13);
            this.CodeID.TabIndex = 60;
            this.CodeID.Text = "Code";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(588, 457);
            this.Controls.Add(this.CodeID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_getpoint);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.txt_receive);
            this.Controls.Add(this.txt_net);
            this.Controls.Add(this.txt_point);
            this.Controls.Add(this.txt_sub);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_customer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.menulist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.StaffName_text);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Selling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StaffName_text;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox menulist;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_sub;
        private System.Windows.Forms.TextBox txt_point;
        private System.Windows.Forms.TextBox txt_net;
        private System.Windows.Forms.TextBox txt_receive;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_getpoint;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label CodeID;
    }
}