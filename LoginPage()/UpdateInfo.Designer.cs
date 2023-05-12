
namespace LoginPage__
{
    partial class UpdateInfo
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
            this.txtfirstname = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.Label();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE INFORMATION";
            // 
            // txtfirstname
            // 
            this.txtfirstname.AutoSize = true;
            this.txtfirstname.Location = new System.Drawing.Point(181, 114);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(72, 16);
            this.txtfirstname.TabIndex = 18;
            this.txtfirstname.Text = "First Name";
            this.txtfirstname.Click += new System.EventHandler(this.txtfirstname_Click);
            // 
            // txtlastname
            // 
            this.txtlastname.AutoSize = true;
            this.txtlastname.Location = new System.Drawing.Point(181, 153);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(72, 16);
            this.txtlastname.TabIndex = 19;
            this.txtlastname.Text = "Last Name";
            this.txtlastname.Click += new System.EventHandler(this.txtlastname_Click);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(313, 114);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(191, 22);
            this.txtfname.TabIndex = 22;
            this.txtfname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(313, 149);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(191, 22);
            this.txtlname.TabIndex = 23;
            // 
            // txtcontact
            // 
            this.txtcontact.AutoSize = true;
            this.txtcontact.Location = new System.Drawing.Point(181, 188);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(52, 16);
            this.txtcontact.TabIndex = 24;
            this.txtcontact.Text = "Contact";
            this.txtcontact.Click += new System.EventHandler(this.txtcontact_Click);
            // 
            // txtcon
            // 
            this.txtcon.Location = new System.Drawing.Point(313, 188);
            this.txtcon.Name = "txtcon";
            this.txtcon.Size = new System.Drawing.Size(191, 22);
            this.txtcon.TabIndex = 25;
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.Location = new System.Drawing.Point(181, 221);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(41, 16);
            this.txtemail.TabIndex = 26;
            this.txtemail.Text = "Email";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(313, 221);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(191, 22);
            this.txtmail.TabIndex = 27;
            this.txtmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtmail_Validating);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(184, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 52);
            this.button1.TabIndex = 28;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(313, 77);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(191, 22);
            this.txtid.TabIndex = 30;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.Location = new System.Drawing.Point(378, 296);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 52);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(313, 257);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(191, 24);
            this.cmb.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Gender";
            // 
            // UpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcon);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateInfo";
            this.Text = "UpdateInfo";
            this.Load += new System.EventHandler(this.UpdateInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtfirstname;
        private System.Windows.Forms.Label txtlastname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label txtcontact;
        private System.Windows.Forms.TextBox txtcon;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label label2;
    }
}