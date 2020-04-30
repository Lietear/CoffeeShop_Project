namespace CoffeeShop.GUI
{
    partial class register_customer
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.gen_combo = new System.Windows.Forms.ComboBox();
            this.type_combo = new System.Windows.Forms.ComboBox();
            this.reg_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(248, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(49, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(49, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(49, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "PhoneNo.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(49, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(139, 93);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(240, 24);
            this.txt_name.TabIndex = 6;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(139, 185);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(169, 24);
            this.txt_phone.TabIndex = 8;
            // 
            // gen_combo
            // 
            this.gen_combo.FormattingEnabled = true;
            this.gen_combo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gen_combo.Location = new System.Drawing.Point(139, 135);
            this.gen_combo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gen_combo.Name = "gen_combo";
            this.gen_combo.Size = new System.Drawing.Size(131, 27);
            this.gen_combo.TabIndex = 10;
            // 
            // type_combo
            // 
            this.type_combo.FormattingEnabled = true;
            this.type_combo.Items.AddRange(new object[] {
            "Member",
            "VIP",
            "Other"});
            this.type_combo.Location = new System.Drawing.Point(139, 229);
            this.type_combo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.type_combo.Name = "type_combo";
            this.type_combo.Size = new System.Drawing.Size(160, 27);
            this.type_combo.TabIndex = 11;
            // 
            // reg_button
            // 
            this.reg_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reg_button.Font = new System.Drawing.Font("Fredoka One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reg_button.Location = new System.Drawing.Point(471, 247);
            this.reg_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(136, 38);
            this.reg_button.TabIndex = 12;
            this.reg_button.Text = "Register";
            this.reg_button.UseVisualStyleBackColor = false;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.DarkRed;
            this.close_button.Font = new System.Drawing.Font("Fredoka One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close_button.Location = new System.Drawing.Point(471, 327);
            this.close_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(136, 38);
            this.close_button.TabIndex = 12;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // register_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::CoffeeShop.Properties.Resources.coffee_66850_12801;
            this.ClientSize = new System.Drawing.Size(693, 401);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.type_combo);
            this.Controls.Add(this.gen_combo);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "register_customer";
            this.Text = "register_customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.ComboBox gen_combo;
        private System.Windows.Forms.ComboBox type_combo;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.Button close_button;
    }
}