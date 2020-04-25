namespace CoffeeShop.GUI
{
    partial class Management_manager
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
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.stafflevel_combo = new System.Windows.Forms.ComboBox();
            this.gender_combo = new System.Windows.Forms.ComboBox();
            this.txt_StaffName = new System.Windows.Forms.TextBox();
            this.txt_StaffID = new System.Windows.Forms.TextBox();
            this.txt_StaffCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.SaddleBrown;
            this.delete_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_button.Location = new System.Drawing.Point(455, 363);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(134, 31);
            this.delete_button.TabIndex = 26;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.Black;
            this.update_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_button.Location = new System.Drawing.Point(211, 363);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(136, 31);
            this.update_button.TabIndex = 25;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // stafflevel_combo
            // 
            this.stafflevel_combo.FormattingEnabled = true;
            this.stafflevel_combo.Items.AddRange(new object[] {
            "Staff"});
            this.stafflevel_combo.Location = new System.Drawing.Point(365, 191);
            this.stafflevel_combo.Name = "stafflevel_combo";
            this.stafflevel_combo.Size = new System.Drawing.Size(121, 21);
            this.stafflevel_combo.TabIndex = 23;
            // 
            // gender_combo
            // 
            this.gender_combo.FormattingEnabled = true;
            this.gender_combo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_combo.Location = new System.Drawing.Point(365, 157);
            this.gender_combo.Name = "gender_combo";
            this.gender_combo.Size = new System.Drawing.Size(121, 21);
            this.gender_combo.TabIndex = 22;
            // 
            // txt_StaffName
            // 
            this.txt_StaffName.Location = new System.Drawing.Point(365, 99);
            this.txt_StaffName.Name = "txt_StaffName";
            this.txt_StaffName.Size = new System.Drawing.Size(171, 20);
            this.txt_StaffName.TabIndex = 21;
            // 
            // txt_StaffID
            // 
            this.txt_StaffID.Location = new System.Drawing.Point(365, 57);
            this.txt_StaffID.Name = "txt_StaffID";
            this.txt_StaffID.Size = new System.Drawing.Size(140, 20);
            this.txt_StaffID.TabIndex = 20;
            // 
            // txt_StaffCode
            // 
            this.txt_StaffCode.Location = new System.Drawing.Point(365, 233);
            this.txt_StaffCode.Name = "txt_StaffCode";
            this.txt_StaffCode.Size = new System.Drawing.Size(113, 20);
            this.txt_StaffCode.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(295, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "StaffLevel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(295, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(295, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "StaffName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(295, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "StaffCode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(295, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "StaffID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(295, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Password";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(365, 130);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(171, 20);
            this.txt_pass.TabIndex = 28;
            // 
            // Management_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label6);
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
            this.Name = "Management_manager";
            this.Text = "Managment_manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.ComboBox stafflevel_combo;
        private System.Windows.Forms.ComboBox gender_combo;
        private System.Windows.Forms.TextBox txt_StaffName;
        private System.Windows.Forms.TextBox txt_StaffID;
        private System.Windows.Forms.TextBox txt_StaffCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pass;
    }
}