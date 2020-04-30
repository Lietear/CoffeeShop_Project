namespace CoffeeShop.GUI
{
    partial class main_admin
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
            this.getID = new System.Windows.Forms.Label();
            this.getName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.order_button = new System.Windows.Forms.Button();
            this.management_button = new System.Windows.Forms.Button();
            this.reg_button = new System.Windows.Forms.Button();
            this.addproduct_button = new System.Windows.Forms.Button();
            this.history_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getID
            // 
            this.getID.AutoSize = true;
            this.getID.BackColor = System.Drawing.Color.Transparent;
            this.getID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getID.Location = new System.Drawing.Point(119, 82);
            this.getID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.getID.Name = "getID";
            this.getID.Size = new System.Drawing.Size(24, 20);
            this.getID.TabIndex = 7;
            this.getID.Text = "id";
            // 
            // getName
            // 
            this.getName.AutoSize = true;
            this.getName.BackColor = System.Drawing.Color.Transparent;
            this.getName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getName.ForeColor = System.Drawing.Color.White;
            this.getName.Location = new System.Drawing.Point(119, 36);
            this.getName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.getName.Name = "getName";
            this.getName.Size = new System.Drawing.Size(54, 20);
            this.getName.TabIndex = 6;
            this.getName.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(49, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // order_button
            // 
            this.order_button.BackColor = System.Drawing.Color.Maroon;
            this.order_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.order_button.Location = new System.Drawing.Point(67, 162);
            this.order_button.Margin = new System.Windows.Forms.Padding(4);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(245, 62);
            this.order_button.TabIndex = 8;
            this.order_button.Text = "Order";
            this.order_button.UseVisualStyleBackColor = false;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // management_button
            // 
            this.management_button.BackColor = System.Drawing.Color.Maroon;
            this.management_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.management_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.management_button.Location = new System.Drawing.Point(443, 162);
            this.management_button.Margin = new System.Windows.Forms.Padding(4);
            this.management_button.Name = "management_button";
            this.management_button.Size = new System.Drawing.Size(245, 62);
            this.management_button.TabIndex = 9;
            this.management_button.Text = "Management";
            this.management_button.UseVisualStyleBackColor = false;
            this.management_button.Click += new System.EventHandler(this.management_button_Click);
            // 
            // reg_button
            // 
            this.reg_button.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.reg_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reg_button.Location = new System.Drawing.Point(67, 309);
            this.reg_button.Margin = new System.Windows.Forms.Padding(4);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(245, 63);
            this.reg_button.TabIndex = 10;
            this.reg_button.Text = "Register Member";
            this.reg_button.UseVisualStyleBackColor = false;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // addproduct_button
            // 
            this.addproduct_button.BackColor = System.Drawing.Color.Black;
            this.addproduct_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproduct_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addproduct_button.Location = new System.Drawing.Point(443, 309);
            this.addproduct_button.Margin = new System.Windows.Forms.Padding(4);
            this.addproduct_button.Name = "addproduct_button";
            this.addproduct_button.Size = new System.Drawing.Size(245, 65);
            this.addproduct_button.TabIndex = 11;
            this.addproduct_button.Text = "Add Product";
            this.addproduct_button.UseVisualStyleBackColor = false;
            this.addproduct_button.Click += new System.EventHandler(this.addproduct_button_Click);
            // 
            // history_button
            // 
            this.history_button.BackColor = System.Drawing.Color.Sienna;
            this.history_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.history_button.Location = new System.Drawing.Point(249, 447);
            this.history_button.Margin = new System.Windows.Forms.Padding(4);
            this.history_button.Name = "history_button";
            this.history_button.Size = new System.Drawing.Size(245, 70);
            this.history_button.TabIndex = 12;
            this.history_button.Text = "History";
            this.history_button.UseVisualStyleBackColor = false;
            this.history_button.Click += new System.EventHandler(this.history_button_Click);
            // 
            // main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShop.Properties.Resources.coffee_2565441_19202;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(805, 632);
            this.Controls.Add(this.history_button);
            this.Controls.Add(this.addproduct_button);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.management_button);
            this.Controls.Add(this.order_button);
            this.Controls.Add(this.getID);
            this.Controls.Add(this.getName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "main_admin";
            this.Text = "CoffeeShop(Administrator)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label getID;
        private System.Windows.Forms.Label getName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.Button management_button;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.Button addproduct_button;
        private System.Windows.Forms.Button history_button;
    }
}