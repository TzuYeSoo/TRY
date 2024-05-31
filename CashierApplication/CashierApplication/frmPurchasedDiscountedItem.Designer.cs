namespace CashierApplication
{
    partial class frmPurchasedDiscountedItem
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
            this.Compute_Disc = new System.Windows.Forms.Button();
            this.txPriced = new System.Windows.Forms.TextBox();
            this.txQuan = new System.Windows.Forms.TextBox();
            this.Disc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.ChangeCus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.itemName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pogiKoBatGanonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicaationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Price";
            // 
            // Compute_Disc
            // 
            this.Compute_Disc.BackColor = System.Drawing.Color.DarkGray;
            this.Compute_Disc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Compute_Disc.Location = new System.Drawing.Point(127, 145);
            this.Compute_Disc.Name = "Compute_Disc";
            this.Compute_Disc.Size = new System.Drawing.Size(75, 23);
            this.Compute_Disc.TabIndex = 9;
            this.Compute_Disc.Text = "Compute";
            this.Compute_Disc.UseVisualStyleBackColor = false;
            this.Compute_Disc.Click += new System.EventHandler(this.Compute_Disc_Click);
            // 
            // txPriced
            // 
            this.txPriced.Location = new System.Drawing.Point(54, 88);
            this.txPriced.Name = "txPriced";
            this.txPriced.Size = new System.Drawing.Size(121, 20);
            this.txPriced.TabIndex = 7;
            // 
            // txQuan
            // 
            this.txQuan.Location = new System.Drawing.Point(248, 88);
            this.txQuan.Name = "txQuan";
            this.txQuan.Size = new System.Drawing.Size(67, 20);
            this.txQuan.TabIndex = 6;
            // 
            // Disc
            // 
            this.Disc.Location = new System.Drawing.Point(184, 52);
            this.Disc.Name = "Disc";
            this.Disc.Size = new System.Drawing.Size(131, 20);
            this.Disc.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Discount%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Payment Recieve: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Change: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 17;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(154, 212);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(28, 17);
            this.TotalPrice.TabIndex = 18;
            this.TotalPrice.Text = "0.0";
            // 
            // ChangeCus
            // 
            this.ChangeCus.AutoSize = true;
            this.ChangeCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeCus.Location = new System.Drawing.Point(154, 290);
            this.ChangeCus.Name = "ChangeCus";
            this.ChangeCus.Size = new System.Drawing.Size(28, 17);
            this.ChangeCus.TabIndex = 19;
            this.ChangeCus.Text = "0.0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(271, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(11, 52);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(164, 20);
            this.itemName.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Item";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pogiKoBatGanonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(359, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pogiKoBatGanonToolStripMenuItem
            // 
            this.pogiKoBatGanonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem,
            this.exitApplicaationToolStripMenuItem});
            this.pogiKoBatGanonToolStripMenuItem.Name = "pogiKoBatGanonToolStripMenuItem";
            this.pogiKoBatGanonToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.pogiKoBatGanonToolStripMenuItem.Text = "Pogi ko bat ganon";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // exitApplicaationToolStripMenuItem
            // 
            this.exitApplicaationToolStripMenuItem.Name = "exitApplicaationToolStripMenuItem";
            this.exitApplicaationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitApplicaationToolStripMenuItem.Text = "Exit Applicaation";
            this.exitApplicaationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicaationToolStripMenuItem_Click);
            // 
            // frmPurchasedDiscountedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 327);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChangeCus);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Disc);
            this.Controls.Add(this.Compute_Disc);
            this.Controls.Add(this.txPriced);
            this.Controls.Add(this.txQuan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPurchasedDiscountedItem";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPurchasedDiscountedItem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Compute_Disc;
        private System.Windows.Forms.TextBox txPriced;
        private System.Windows.Forms.TextBox txQuan;
        private System.Windows.Forms.TextBox Disc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label ChangeCus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pogiKoBatGanonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicaationToolStripMenuItem;
    }
}