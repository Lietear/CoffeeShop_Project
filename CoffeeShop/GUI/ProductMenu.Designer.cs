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
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(235, 348);
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
            "add",
            "update",
            "drop"});
            this.select.Location = new System.Drawing.Point(235, 308);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(121, 24);
            this.select.TabIndex = 10;
            // 
            // pdetail
            // 
            this.pdetail.Location = new System.Drawing.Point(235, 193);
            this.pdetail.Multiline = true;
            this.pdetail.Name = "pdetail";
            this.pdetail.Size = new System.Drawing.Size(190, 88);
            this.pdetail.TabIndex = 9;
            // 
            // pprice
            // 
            this.pprice.Location = new System.Drawing.Point(235, 141);
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(64, 22);
            this.pprice.TabIndex = 8;
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(235, 95);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(190, 22);
            this.pname.TabIndex = 7;
            // 
            // pnum
            // 
            this.pnum.Location = new System.Drawing.Point(235, 44);
            this.pnum.Name = "pnum";
            this.pnum.Size = new System.Drawing.Size(64, 22);
            this.pnum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Product detail";
            // 
            // ProductMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.pdetail);
            this.Controls.Add(this.pprice);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.pnum);
            this.Name = "ProductMenu";
            this.Text = "ProductMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}