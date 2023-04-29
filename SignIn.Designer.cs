namespace VKN
{
    partial class SignIn
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.repeatTB = new System.Windows.Forms.TextBox();
            this.signB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repeat Password:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(210, 43);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(316, 22);
            this.nameTB.TabIndex = 3;
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(210, 113);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(316, 22);
            this.passTB.TabIndex = 4;
            // 
            // repeatTB
            // 
            this.repeatTB.Location = new System.Drawing.Point(210, 182);
            this.repeatTB.Name = "repeatTB";
            this.repeatTB.Size = new System.Drawing.Size(316, 22);
            this.repeatTB.TabIndex = 5;
            // 
            // signB
            // 
            this.signB.Location = new System.Drawing.Point(303, 245);
            this.signB.Name = "signB";
            this.signB.Size = new System.Drawing.Size(133, 49);
            this.signB.TabIndex = 6;
            this.signB.Text = "Sign in";
            this.signB.UseVisualStyleBackColor = true;
            this.signB.Click += new System.EventHandler(this.signB_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 317);
            this.Controls.Add(this.signB);
            this.Controls.Add(this.repeatTB);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.TextBox repeatTB;
        private System.Windows.Forms.Button signB;
    }
}