namespace CoffeeShop.GUI
{
    partial class main_manager
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
            this.managment_button = new System.Windows.Forms.Button();
            this.reg_button = new System.Windows.Forms.Button();
            this.history_button = new System.Windows.Forms.Button();
            this.addproduct_button = new System.Windows.Forms.Button();
            this.info_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getID
            // 
            this.getID.AutoSize = true;
            this.getID.BackColor = System.Drawing.Color.Transparent;
            this.getID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getID.Location = new System.Drawing.Point(87, 79);
            this.getID.Name = "getID";
            this.getID.Size = new System.Drawing.Size(80, 17);
            this.getID.TabIndex = 7;
            this.getID.Text = "Get_Code";
            // 
            // getName
            // 
            this.getName.AutoSize = true;
            this.getName.BackColor = System.Drawing.Color.Transparent;
            this.getName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getName.ForeColor = System.Drawing.SystemColors.Control;
            this.getName.Location = new System.Drawing.Point(87, 41);
            this.getName.Name = "getName";
            this.getName.Size = new System.Drawing.Size(82, 17);
            this.getName.TabIndex = 6;
            this.getName.Text = "Get_name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // order_button
            // 
            this.order_button.BackColor = System.Drawing.Color.Maroon;
            this.order_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_button.ForeColor = System.Drawing.Color.White;
            this.order_button.Location = new System.Drawing.Point(38, 148);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(185, 53);
            this.order_button.TabIndex = 8;
            this.order_button.Text = "Order";
            this.order_button.UseVisualStyleBackColor = false;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // managment_button
            // 
            this.managment_button.BackColor = System.Drawing.Color.Maroon;
            this.managment_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managment_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.managment_button.Location = new System.Drawing.Point(360, 148);
            this.managment_button.Name = "managment_button";
            this.managment_button.Size = new System.Drawing.Size(191, 53);
            this.managment_button.TabIndex = 8;
            this.managment_button.Text = "Managment Staff";
            this.managment_button.UseVisualStyleBackColor = false;
            this.managment_button.Click += new System.EventHandler(this.managment_button_Click);
            // 
            // reg_button
            // 
            this.reg_button.BackColor = System.Drawing.SystemColors.ControlText;
            this.reg_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reg_button.Location = new System.Drawing.Point(38, 232);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(185, 54);
            this.reg_button.TabIndex = 8;
            this.reg_button.Text = "Register Member";
            this.reg_button.UseVisualStyleBackColor = false;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // history_button
            // 
            this.history_button.BackColor = System.Drawing.Color.Maroon;
            this.history_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.history_button.Location = new System.Drawing.Point(38, 315);
            this.history_button.Name = "history_button";
            this.history_button.Size = new System.Drawing.Size(185, 57);
            this.history_button.TabIndex = 13;
            this.history_button.Text = "History";
            this.history_button.UseVisualStyleBackColor = false;
            this.history_button.Click += new System.EventHandler(this.history_button_Click);
            // 
            // addproduct_button
            // 
            this.addproduct_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.addproduct_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproduct_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addproduct_button.Location = new System.Drawing.Point(360, 230);
            this.addproduct_button.Name = "addproduct_button";
            this.addproduct_button.Size = new System.Drawing.Size(191, 56);
            this.addproduct_button.TabIndex = 14;
            this.addproduct_button.Text = "Add Product";
            this.addproduct_button.UseVisualStyleBackColor = false;
            // 
            // info_button
            // 
            this.info_button.BackColor = System.Drawing.Color.DarkRed;
            this.info_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.info_button.Location = new System.Drawing.Point(360, 321);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(191, 51);
            this.info_button.TabIndex = 15;
            this.info_button.Text = "Member Information";
            this.info_button.UseVisualStyleBackColor = false;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // main_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShop.Properties.Resources.B6FtNKtgSqRqbnNsUzH6Z3tvb4rr0JtbPFm9X3u2epXJDyoPbc4WVErQJRHNG3x8Uidn52;
            this.ClientSize = new System.Drawing.Size(598, 516);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.addproduct_button);
            this.Controls.Add(this.history_button);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.managment_button);
            this.Controls.Add(this.order_button);
            this.Controls.Add(this.getID);
            this.Controls.Add(this.getName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "main_manager";
            this.Text = "main_manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label getID;
        private System.Windows.Forms.Label getName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.Button managment_button;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.Button history_button;
        private System.Windows.Forms.Button addproduct_button;
        private System.Windows.Forms.Button info_button;
    }
}