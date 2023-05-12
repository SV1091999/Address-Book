namespace LoginPage__
{
    partial class delete
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(235, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "DELETE FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(375, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 52);
            this.button3.TabIndex = 14;
            this.button3.Text = "CANCEL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(62, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(652, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Are you sure you want to delete the contact information?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtfirstname
            // 
            this.txtfirstname.AutoSize = true;
            this.txtfirstname.Location = new System.Drawing.Point(242, 164);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(72, 16);
            this.txtfirstname.TabIndex = 17;
            this.txtfirstname.Text = "First Name";
            // 
            // txtlastname
            // 
            this.txtlastname.AutoSize = true;
            this.txtlastname.Location = new System.Drawing.Point(242, 194);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(72, 16);
            this.txtlastname.TabIndex = 18;
            this.txtlastname.Text = "Last Name";
            this.txtlastname.Click += new System.EventHandler(this.txtlastname_Click);
            // 
            // txtcontact
            // 
            this.txtcontact.AutoSize = true;
            this.txtcontact.Location = new System.Drawing.Point(242, 226);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(52, 16);
            this.txtcontact.TabIndex = 19;
            this.txtcontact.Text = "Contact";
            this.txtcontact.Click += new System.EventHandler(this.txtcontact_Click);
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.Location = new System.Drawing.Point(242, 257);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(41, 16);
            this.txtemail.TabIndex = 20;
            this.txtemail.Text = "Email";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(339, 194);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(191, 22);
            this.txtLName.TabIndex = 22;
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(339, 226);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(191, 22);
            this.txtCon.TabIndex = 23;
            this.txtCon.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(339, 257);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(191, 22);
            this.txtMail.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(339, 134);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(191, 22);
            this.txtid.TabIndex = 26;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(339, 162);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(191, 22);
            this.txtFName.TabIndex = 27;
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "delete";
            this.Text = "delete";
            this.Load += new System.EventHandler(this.delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtfirstname;
        private System.Windows.Forms.Label txtlastname;
        private System.Windows.Forms.Label txtcontact;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtFName;
    }
}