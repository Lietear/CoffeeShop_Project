namespace CoffeeShop.GUI
{
    partial class Management_admin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_StaffCode = new System.Windows.Forms.TextBox();
            this.txt_StaffID = new System.Windows.Forms.TextBox();
            this.txt_StaffName = new System.Windows.Forms.TextBox();
            this.gender_combo = new System.Windows.Forms.ComboBox();
            this.stafflevel_combo = new System.Windows.Forms.ComboBox();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(228, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "StaffID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(228, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "StaffCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(228, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "StaffName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(228, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(228, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "StaffLevel";
            // 
            // txt_StaffCode
            // 
            this.txt_StaffCode.Location = new System.Drawing.Point(321, 232);
            this.txt_StaffCode.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StaffCode.Name = "txt_StaffCode";
            this.txt_StaffCode.Size = new System.Drawing.Size(149, 22);
            this.txt_StaffCode.TabIndex = 10;
            this.txt_StaffCode.TextChanged += new System.EventHandler(this.txt_StaffCode_TextChanged);
            // 
            // txt_StaffID
            // 
            this.txt_StaffID.Location = new System.Drawing.Point(321, 15);
            this.txt_StaffID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StaffID.Name = "txt_StaffID";
            this.txt_StaffID.Size = new System.Drawing.Size(185, 22);
            this.txt_StaffID.TabIndex = 6;
            this.txt_StaffID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_StaffName
            // 
            this.txt_StaffName.Location = new System.Drawing.Point(321, 66);
            this.txt_StaffName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StaffName.Name = "txt_StaffName";
            this.txt_StaffName.Size = new System.Drawing.Size(227, 22);
            this.txt_StaffName.TabIndex = 7;
            // 
            // gender_combo
            // 
            this.gender_combo.FormattingEnabled = true;
            this.gender_combo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_combo.Location = new System.Drawing.Point(321, 120);
            this.gender_combo.Margin = new System.Windows.Forms.Padding(4);
            this.gender_combo.Name = "gender_combo";
            this.gender_combo.Size = new System.Drawing.Size(160, 24);
            this.gender_combo.TabIndex = 8;
            // 
            // stafflevel_combo
            // 
            this.stafflevel_combo.FormattingEnabled = true;
            this.stafflevel_combo.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Staff"});
            this.stafflevel_combo.Location = new System.Drawing.Point(321, 180);
            this.stafflevel_combo.Margin = new System.Windows.Forms.Padding(4);
            this.stafflevel_combo.Name = "stafflevel_combo";
            this.stafflevel_combo.Size = new System.Drawing.Size(160, 24);
            this.stafflevel_combo.TabIndex = 9;
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.Transparent;
            this.update_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update_button.Image = global::CoffeeShop.Properties.Resources.Untitled_1__2_1;
            this.update_button.Location = new System.Drawing.Point(153, 392);
            this.update_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(145, 45);
            this.update_button.TabIndex = 13;
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Image = global::CoffeeShop.Properties.Resources.Untitled_1__2_2;
            this.delete_button.Location = new System.Drawing.Point(441, 392);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(136, 45);
            this.delete_button.TabIndex = 14;
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // Management_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::CoffeeShop.Properties.Resources.Cappuccino_dooddot_1;
            this.ClientSize = new System.Drawing.Size(762, 532);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.stafflevel_combo);
            this.Controls.Add(this.gender_combo);
            this.Controls.Add(this.txt_StaffName);
            this.Controls.Add(this.txt_StaffID);
            this.Controls.Add(this.txt_StaffCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Management_admin";
            this.Text = "Management(Administrator)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_StaffID;
        private System.Windows.Forms.TextBox txt_StaffCode;
        private System.Windows.Forms.TextBox txt_StaffName;
        private System.Windows.Forms.ComboBox gender_combo;
        private System.Windows.Forms.ComboBox stafflevel_combo;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
    }
}