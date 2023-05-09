namespace PhoneProvider
{
    partial class DetailedReceipt
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
            this.receivedProductsLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.dateLabel = new System.Windows.Forms.Label();
            this.receiptedDateTxt = new System.Windows.Forms.TextBox();
            this.totalTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.receiptedIdTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addPnl = new System.Windows.Forms.Panel();
            this.quantityTxb = new System.Windows.Forms.TextBox();
            this.priceTxb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productIdTxb = new System.Windows.Forms.TextBox();
            this.productNameTxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // receivedProductsLv
            // 
            this.receivedProductsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.receivedProductsLv.FullRowSelect = true;
            this.receivedProductsLv.GridLines = true;
            this.receivedProductsLv.Location = new System.Drawing.Point(15, 139);
            this.receivedProductsLv.Margin = new System.Windows.Forms.Padding(4);
            this.receivedProductsLv.Name = "receivedProductsLv";
            this.receivedProductsLv.Size = new System.Drawing.Size(1049, 403);
            this.receivedProductsLv.TabIndex = 0;
            this.receivedProductsLv.UseCompatibleStateImageBehavior = false;
            this.receivedProductsLv.View = System.Windows.Forms.View.Details;
            this.receivedProductsLv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.receivedProductsLv_MouseDoubleClick);
            this.receivedProductsLv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.receivedProductsLv_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Id";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total Amount";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 200;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(32, 71);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(123, 25);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Received Date";
            // 
            // receiptedDateTxt
            // 
            this.receiptedDateTxt.BackColor = System.Drawing.SystemColors.Menu;
            this.receiptedDateTxt.Enabled = false;
            this.receiptedDateTxt.Location = new System.Drawing.Point(171, 68);
            this.receiptedDateTxt.Margin = new System.Windows.Forms.Padding(4);
            this.receiptedDateTxt.Name = "receiptedDateTxt";
            this.receiptedDateTxt.Size = new System.Drawing.Size(196, 31);
            this.receiptedDateTxt.TabIndex = 3;
            // 
            // totalTxb
            // 
            this.totalTxb.Enabled = false;
            this.totalTxb.Location = new System.Drawing.Point(784, 559);
            this.totalTxb.Margin = new System.Windows.Forms.Padding(4);
            this.totalTxb.Name = "totalTxb";
            this.totalTxb.Size = new System.Drawing.Size(255, 31);
            this.totalTxb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(712, 562);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Received ID";
            // 
            // receiptedIdTxt
            // 
            this.receiptedIdTxt.BackColor = System.Drawing.SystemColors.Menu;
            this.receiptedIdTxt.Enabled = false;
            this.receiptedIdTxt.Location = new System.Drawing.Point(171, 21);
            this.receiptedIdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.receiptedIdTxt.Name = "receiptedIdTxt";
            this.receiptedIdTxt.Size = new System.Drawing.Size(196, 31);
            this.receiptedIdTxt.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(372, 401);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(125, 36);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(1086, 95);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(125, 36);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addPnl
            // 
            this.addPnl.Controls.Add(this.quantityTxb);
            this.addPnl.Controls.Add(this.priceTxb);
            this.addPnl.Controls.Add(this.label7);
            this.addPnl.Controls.Add(this.label6);
            this.addPnl.Controls.Add(this.label5);
            this.addPnl.Controls.Add(this.productIdTxb);
            this.addPnl.Controls.Add(this.productNameTxb);
            this.addPnl.Controls.Add(this.label4);
            this.addPnl.Controls.Add(this.addBtn);
            this.addPnl.Location = new System.Drawing.Point(1072, 141);
            this.addPnl.Margin = new System.Windows.Forms.Padding(4);
            this.addPnl.Name = "addPnl";
            this.addPnl.Size = new System.Drawing.Size(680, 446);
            this.addPnl.TabIndex = 12;
            // 
            // quantityTxb
            // 
            this.quantityTxb.Location = new System.Drawing.Point(152, 196);
            this.quantityTxb.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTxb.Name = "quantityTxb";
            this.quantityTxb.Size = new System.Drawing.Size(344, 31);
            this.quantityTxb.TabIndex = 18;
            this.quantityTxb.TextChanged += new System.EventHandler(this.quantityTxb_TextChanged);
            // 
            // priceTxb
            // 
            this.priceTxb.Enabled = false;
            this.priceTxb.Location = new System.Drawing.Point(152, 146);
            this.priceTxb.Margin = new System.Windows.Forms.Padding(4);
            this.priceTxb.Name = "priceTxb";
            this.priceTxb.Size = new System.Drawing.Size(344, 31);
            this.priceTxb.TabIndex = 17;
            this.priceTxb.TextChanged += new System.EventHandler(this.priceTxb_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Product Id";
            // 
            // productIdTxb
            // 
            this.productIdTxb.Enabled = false;
            this.productIdTxb.Location = new System.Drawing.Point(152, 41);
            this.productIdTxb.Margin = new System.Windows.Forms.Padding(4);
            this.productIdTxb.Name = "productIdTxb";
            this.productIdTxb.Size = new System.Drawing.Size(344, 31);
            this.productIdTxb.TabIndex = 13;
            this.productIdTxb.TextChanged += new System.EventHandler(this.productIdTxb_TextChanged);
            // 
            // productNameTxb
            // 
            this.productNameTxb.Location = new System.Drawing.Point(152, 94);
            this.productNameTxb.Margin = new System.Windows.Forms.Padding(4);
            this.productNameTxb.Name = "productNameTxb";
            this.productNameTxb.Size = new System.Drawing.Size(344, 31);
            this.productNameTxb.TabIndex = 12;
            this.productNameTxb.TextChanged += new System.EventHandler(this.productNameTxb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Product Name";
            // 
            // DetailedReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 741);
            this.Controls.Add(this.addPnl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.receiptedIdTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalTxb);
            this.Controls.Add(this.receiptedDateTxt);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.receivedProductsLv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetailedReceipt";
            this.Text = "Nhu Linh Co.,Ltd";
            this.Load += new System.EventHandler(this.DetailedReceipt_Load);
            this.addPnl.ResumeLayout(false);
            this.addPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView receivedProductsLv;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label dateLabel;
        private TextBox receiptedDateTxt;
        private TextBox totalTxb;
        private Label label1;
        private Label label2;
        private TextBox receiptedIdTxt;
        private Button addBtn;
        private Button deleteBtn;
        private Panel addPnl;
        private TextBox quantityTxb;
        private TextBox priceTxb;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox productIdTxb;
        private TextBox productNameTxb;
        private Label label4;
    }
}