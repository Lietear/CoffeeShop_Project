namespace CoffeeShop.GUI
{
    partial class History
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
            this.shw_all = new System.Windows.Forms.Button();
            this.balanceTxt = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.page2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // page1
            // 
            this.page1.Controls.Add(this.shw_all);
            this.page1.Controls.Add(this.balanceTxt);
            this.page1.Controls.Add(this.show);
            this.page1.Controls.Add(this.date2);
            this.page1.Controls.Add(this.dataGridView1);
            this.page1.Location = new System.Drawing.Point(8, 29);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(819, 412);
            this.page1.TabIndex = 6;
            // 
            // shw_all
            // 
            this.shw_all.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shw_all.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shw_all.Location = new System.Drawing.Point(411, 48);
            this.shw_all.Name = "shw_all";
            this.shw_all.Size = new System.Drawing.Size(75, 23);
            this.shw_all.TabIndex = 5;
            this.shw_all.Text = "show all";
            this.shw_all.UseVisualStyleBackColor = false;
            this.shw_all.Click += new System.EventHandler(this.shw_all_Click);
            // 
            // balanceTxt
            // 
            this.balanceTxt.AutoSize = true;
            this.balanceTxt.Location = new System.Drawing.Point(12, 341);
            this.balanceTxt.Name = "balanceTxt";
            this.balanceTxt.Size = new System.Drawing.Size(83, 17);
            this.balanceTxt.TabIndex = 4;
            this.balanceTxt.Text = "Balance = 0";
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.Sienna;
            this.show.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show.Location = new System.Drawing.Point(273, 48);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 3;
            this.show.Text = "show";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // date2
            // 
            this.date2.CustomFormat = "yyyy-MM-dd";
            this.date2.Location = new System.Drawing.Point(15, 49);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 22);
            this.date2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(724, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // page2
            // 
            this.page2.Controls.Add(this.button1);
            this.page2.Controls.Add(this.dataGridView2);
            this.page2.Location = new System.Drawing.Point(49, 12);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(745, 461);
            this.page2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(324, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(721, 358);
            this.dataGridView2.TabIndex = 0;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(839, 515);
            this.Controls.Add(this.page1);
            this.Controls.Add(this.page2);
            this.Name = "History";
            this.Text = "History";
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.page2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel page1;
        private System.Windows.Forms.Button shw_all;
        private System.Windows.Forms.Label balanceTxt;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel page2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}