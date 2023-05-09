namespace PhoneProvider
{
    partial class ReceiptForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.receivedLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.fromDtp = new System.Windows.Forms.DateTimePicker();
            this.toDtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // receivedLv
            // 
            this.receivedLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.receivedLv.FullRowSelect = true;
            this.receivedLv.GridLines = true;
            this.receivedLv.Location = new System.Drawing.Point(32, 165);
            this.receivedLv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.receivedLv.Name = "receivedLv";
            this.receivedLv.Size = new System.Drawing.Size(692, 423);
            this.receivedLv.TabIndex = 0;
            this.receivedLv.UseCompatibleStateImageBehavior = false;
            this.receivedLv.View = System.Windows.Forms.View.Details;
            this.receivedLv.SelectedIndexChanged += new System.EventHandler(this.receivedLv_SelectedIndexChanged);
            this.receivedLv.DoubleClick += new System.EventHandler(this.receivedLv_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Received Id";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Received Date";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total";
            this.columnHeader3.Width = 200;
            // 
            // fromDtp
            // 
            this.fromDtp.Location = new System.Drawing.Point(155, 18);
            this.fromDtp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromDtp.Name = "fromDtp";
            this.fromDtp.Size = new System.Drawing.Size(346, 31);
            this.fromDtp.TabIndex = 1;
            this.fromDtp.ValueChanged += new System.EventHandler(this.fromDtp_ValueChanged);
            // 
            // toDtp
            // 
            this.toDtp.Location = new System.Drawing.Point(155, 81);
            this.toDtp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toDtp.Name = "toDtp";
            this.toDtp.Size = new System.Drawing.Size(346, 31);
            this.toDtp.TabIndex = 2;
            this.toDtp.ValueChanged += new System.EventHandler(this.toDtp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toDtp);
            this.panel1.Controls.Add(this.fromDtp);
            this.panel1.Location = new System.Drawing.Point(32, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 131);
            this.panel1.TabIndex = 5;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(606, 11);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(122, 64);
            this.CreateBtn.TabIndex = 6;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(606, 84);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(122, 62);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 609);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.receivedLv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReceiptForm";
            this.Text = "Nhu Linh Co.,Ltd";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView receivedLv;
        private DateTimePicker fromDtp;
        private DateTimePicker toDtp;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button CreateBtn;
        private Button deleteBtn;
    }
}