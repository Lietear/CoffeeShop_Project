namespace CoffeeShop.GUI
{
    partial class customer
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
            this.page1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.page2 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.ComboBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.type_combo = new System.Windows.Forms.ComboBox();
            this.gen_combo = new System.Windows.Forms.ComboBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.page2.SuspendLayout();
            this.SuspendLayout();
            // 
            // page1
            // 
            this.page1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.page1.Controls.Add(this.label5);
            this.page1.Controls.Add(this.dataGridView1);
            this.page1.Location = new System.Drawing.Point(40, 12);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(688, 426);
            this.page1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Member";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(647, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // page2
            // 
            this.page2.Controls.Add(this.type_combo);
            this.page2.Controls.Add(this.gen_combo);
            this.page2.Controls.Add(this.txt_phone);
            this.page2.Controls.Add(this.txt_name);
            this.page2.Controls.Add(this.label1);
            this.page2.Controls.Add(this.label4);
            this.page2.Controls.Add(this.label3);
            this.page2.Controls.Add(this.label2);
            this.page2.Controls.Add(this.cancel);
            this.page2.Controls.Add(this.select);
            this.page2.Controls.Add(this.bt1);
            this.page2.Location = new System.Drawing.Point(173, 12);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(428, 407);
            this.page2.TabIndex = 18;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.DarkRed;
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel.Location = new System.Drawing.Point(272, 323);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 26);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // select
            // 
            this.select.FormattingEnabled = true;
            this.select.Items.AddRange(new object[] {
            "update",
            "delete"});
            this.select.Location = new System.Drawing.Point(129, 29);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(121, 24);
            this.select.TabIndex = 10;
            this.select.SelectedIndexChanged += new System.EventHandler(this.select_SelectedIndexChanged);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.Desktop;
            this.bt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt1.Location = new System.Drawing.Point(130, 323);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 26);
            this.bt1.TabIndex = 11;
            this.bt1.Text = "OK";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // type_combo
            // 
            this.type_combo.FormattingEnabled = true;
            this.type_combo.Items.AddRange(new object[] {
            "Member",
            "VIP",
            "Other"});
            this.type_combo.Location = new System.Drawing.Point(129, 218);
            this.type_combo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.type_combo.Name = "type_combo";
            this.type_combo.Size = new System.Drawing.Size(160, 24);
            this.type_combo.TabIndex = 24;
            // 
            // gen_combo
            // 
            this.gen_combo.FormattingEnabled = true;
            this.gen_combo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gen_combo.Location = new System.Drawing.Point(129, 124);
            this.gen_combo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gen_combo.Name = "gen_combo";
            this.gen_combo.Size = new System.Drawing.Size(131, 24);
            this.gen_combo.TabIndex = 23;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(129, 174);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(169, 22);
            this.txt_phone.TabIndex = 22;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(129, 82);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(240, 22);
            this.txt_name.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(39, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(39, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "PhoneNo.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(39, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(39, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.page1);
            this.Controls.Add(this.page2);
            this.Name = "customer";
            this.Text = "customer";
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.page2.ResumeLayout(false);
            this.page2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel page1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel page2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.ComboBox type_combo;
        private System.Windows.Forms.ComboBox gen_combo;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}