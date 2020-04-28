namespace CoffeeShop.GUI
{
    partial class main_staff
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
            this.getName = new System.Windows.Forms.Label();
            this.getID = new System.Windows.Forms.Label();
            this.order_button = new System.Windows.Forms.Button();
            this.history_button = new System.Windows.Forms.Button();
            this.reg_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // getName
            // 
            this.getName.AutoSize = true;
            this.getName.Location = new System.Drawing.Point(107, 48);
            this.getName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.getName.Name = "getName";
            this.getName.Size = new System.Drawing.Size(43, 17);
            this.getName.TabIndex = 2;
            this.getName.Text = "name";
            // 
            // getID
            // 
            this.getID.AutoSize = true;
            this.getID.Location = new System.Drawing.Point(107, 95);
            this.getID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.getID.Name = "getID";
            this.getID.Size = new System.Drawing.Size(19, 17);
            this.getID.TabIndex = 3;
            this.getID.Text = "id";
            // 
            // order_button
            // 
            this.order_button.Location = new System.Drawing.Point(755, 25);
            this.order_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(213, 86);
            this.order_button.TabIndex = 4;
            this.order_button.Text = "Order";
            this.order_button.UseVisualStyleBackColor = true;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // history_button
            // 
            this.history_button.Location = new System.Drawing.Point(755, 234);
            this.history_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.history_button.Name = "history_button";
            this.history_button.Size = new System.Drawing.Size(213, 70);
            this.history_button.TabIndex = 15;
            this.history_button.Text = "History";
            this.history_button.UseVisualStyleBackColor = true;
            this.history_button.Click += new System.EventHandler(this.history_button_Click);
            // 
            // reg_button
            // 
            this.reg_button.Location = new System.Drawing.Point(755, 127);
            this.reg_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(213, 81);
            this.reg_button.TabIndex = 14;
            this.reg_button.Text = "Register Member";
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // main_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.history_button);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.order_button);
            this.Controls.Add(this.getID);
            this.Controls.Add(this.getName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "main_staff";
            this.Text = "main_staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label getName;
        private System.Windows.Forms.Label getID;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.Button history_button;
        private System.Windows.Forms.Button reg_button;
    }
}