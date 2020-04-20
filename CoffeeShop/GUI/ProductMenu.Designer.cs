namespace CoffeeShop.GUI
{
    partial class ProductMenu
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
            this.bt1 = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.ComboBox();
            this.pdetail = new System.Windows.Forms.TextBox();
            this.pprice = new System.Windows.Forms.TextBox();
            this.pname = new System.Windows.Forms.TextBox();
            this.pnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.page2 = new System.Windows.Forms.Panel();
            this.page1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.page2.SuspendLayout();
            this.page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(130, 323);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 11;
            this.bt1.Text = "ok";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // select
            // 
            this.select.FormattingEnabled = true;
            this.select.Items.AddRange(new object[] {
            "update",
            "delete"});
            this.select.Location = new System.Drawing.Point(130, 30);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(121, 24);
            this.select.TabIndex = 10;
            this.select.SelectedIndexChanged += new System.EventHandler(this.select_SelectedIndexChanged);
            // 
            // pdetail
            // 
            this.pdetail.Location = new System.Drawing.Point(130, 221);
            this.pdetail.Multiline = true;
            this.pdetail.Name = "pdetail";
            this.pdetail.Size = new System.Drawing.Size(254, 88);
            this.pdetail.TabIndex = 9;
            // 
            // pprice
            // 
            this.pprice.Location = new System.Drawing.Point(130, 169);
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(64, 22);
            this.pprice.TabIndex = 8;
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(130, 123);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(190, 22);
            this.pname.TabIndex = 7;
            // 
            // pnum
            // 
            this.pnum.Location = new System.Drawing.Point(130, 75);
            this.pnum.Name = "pnum";
            this.pnum.Size = new System.Drawing.Size(64, 22);
            this.pnum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Product detail";
            // 
            // page2
            // 
            this.page2.Controls.Add(this.cancel);
            this.page2.Controls.Add(this.label1);
            this.page2.Controls.Add(this.select);
            this.page2.Controls.Add(this.label4);
            this.page2.Controls.Add(this.pnum);
            this.page2.Controls.Add(this.label3);
            this.page2.Controls.Add(this.pname);
            this.page2.Controls.Add(this.label2);
            this.page2.Controls.Add(this.pprice);
            this.page2.Controls.Add(this.pdetail);
            this.page2.Controls.Add(this.bt1);
            this.page2.Location = new System.Drawing.Point(180, 12);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(400, 407);
            this.page2.TabIndex = 16;
            // 
            // page1
            // 
            this.page1.Controls.Add(this.label5);
            this.page1.Controls.Add(this.add);
            this.page1.Controls.Add(this.dataGridView1);
            this.page1.Location = new System.Drawing.Point(29, 31);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(717, 407);
            this.page1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(647, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(18, 344);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(272, 323);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Product Menu";
            // 
            // ProductMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.page1);
            this.Controls.Add(this.page2);
            this.Name = "ProductMenu";
            this.Text = "ProductMenu";
            this.page2.ResumeLayout(false);
            this.page2.PerformLayout();
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.TextBox pdetail;
        private System.Windows.Forms.TextBox pprice;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.TextBox pnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel page2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Panel page1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}