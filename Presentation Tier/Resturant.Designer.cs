namespace VPAssignment5
{
    partial class resturant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resturant));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pizzaGridView = new System.Windows.Forms.DataGridView();
            this.pizzaiImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.friesGridView = new System.Windows.Forms.DataGridView();
            this.friesImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.drinksGridView = new System.Windows.Forms.DataGridView();
            this.drinksImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.placeOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Informal Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(56, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHIANG MAI PIZZA SHOP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(869, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(254, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 80);
            this.panel1.TabIndex = 5;
            // 
            // pizzaGridView
            // 
            this.pizzaGridView.AllowUserToAddRows = false;
            this.pizzaGridView.AllowUserToOrderColumns = true;
            this.pizzaGridView.BackgroundColor = System.Drawing.Color.White;
            this.pizzaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pizzaGridView.ColumnHeadersVisible = false;
            this.pizzaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pizzaiImg});
            this.pizzaGridView.Location = new System.Drawing.Point(17, 280);
            this.pizzaGridView.Name = "pizzaGridView";
            this.pizzaGridView.RowHeadersVisible = false;
            this.pizzaGridView.RowTemplate.Height = 120;
            this.pizzaGridView.Size = new System.Drawing.Size(319, 499);
            this.pizzaGridView.TabIndex = 10;
            this.pizzaGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.pizzaGridView_CellMouseClick);
            // 
            // pizzaiImg
            // 
            this.pizzaiImg.HeaderText = "pizzaiImg";
            this.pizzaiImg.Name = "pizzaiImg";
            // 
            // friesGridView
            // 
            this.friesGridView.AllowUserToAddRows = false;
            this.friesGridView.AllowUserToOrderColumns = true;
            this.friesGridView.BackgroundColor = System.Drawing.Color.White;
            this.friesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.friesGridView.ColumnHeadersVisible = false;
            this.friesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.friesImg});
            this.friesGridView.Location = new System.Drawing.Point(383, 280);
            this.friesGridView.Name = "friesGridView";
            this.friesGridView.RowHeadersVisible = false;
            this.friesGridView.RowTemplate.Height = 120;
            this.friesGridView.Size = new System.Drawing.Size(319, 499);
            this.friesGridView.TabIndex = 11;
            this.friesGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.friesGridView_CellMouseClick);
            // 
            // friesImg
            // 
            this.friesImg.HeaderText = "friesImg";
            this.friesImg.Name = "friesImg";
            // 
            // drinksGridView
            // 
            this.drinksGridView.AllowUserToAddRows = false;
            this.drinksGridView.AllowUserToOrderColumns = true;
            this.drinksGridView.BackgroundColor = System.Drawing.Color.White;
            this.drinksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drinksGridView.ColumnHeadersVisible = false;
            this.drinksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drinksImg});
            this.drinksGridView.Location = new System.Drawing.Point(748, 280);
            this.drinksGridView.Name = "drinksGridView";
            this.drinksGridView.RowHeadersVisible = false;
            this.drinksGridView.RowTemplate.Height = 120;
            this.drinksGridView.Size = new System.Drawing.Size(319, 499);
            this.drinksGridView.TabIndex = 12;
            this.drinksGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.drinksGridView_CellMouseClick);
            // 
            // drinksImg
            // 
            this.drinksImg.HeaderText = "drinksImg";
            this.drinksImg.Name = "drinksImg";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Informal Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(85, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 58);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pizza";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Informal Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(472, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 58);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fries";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Informal Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(838, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 58);
            this.label4.TabIndex = 15;
            this.label4.Text = "Drinks";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(17, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 66);
            this.panel2.TabIndex = 16;
            // 
            // placeOrder
            // 
            this.placeOrder.BackColor = System.Drawing.Color.Maroon;
            this.placeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrder.ForeColor = System.Drawing.Color.White;
            this.placeOrder.Location = new System.Drawing.Point(17, 128);
            this.placeOrder.Name = "placeOrder";
            this.placeOrder.Size = new System.Drawing.Size(167, 50);
            this.placeOrder.TabIndex = 17;
            this.placeOrder.Text = "Place Order";
            this.placeOrder.UseVisualStyleBackColor = false;
            this.placeOrder.Click += new System.EventHandler(this.placeOrder_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Informal Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(310, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(406, 58);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Selected Items:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Informal Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(803, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 58);
            this.label5.TabIndex = 20;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // resturant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 791);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.placeOrder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.drinksGridView);
            this.Controls.Add(this.friesGridView);
            this.Controls.Add(this.pizzaGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1101, 847);
            this.Name = "resturant";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Reservation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn pizzaiImg;
        private System.Windows.Forms.DataGridViewImageColumn friesImg;
        private System.Windows.Forms.DataGridViewImageColumn drinksImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button placeOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView pizzaGridView;
        public System.Windows.Forms.DataGridView friesGridView;
        public System.Windows.Forms.DataGridView drinksGridView;
    }
}

