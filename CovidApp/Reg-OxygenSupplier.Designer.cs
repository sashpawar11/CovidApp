﻿namespace CovidApp
{
    partial class Form1
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
            this.username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hosp_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hosp_no = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hosp_addr = new System.Windows.Forms.TextBox();
            this.inc_name = new System.Windows.Forms.TextBox();
            this.hospitalDetailbox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.hospitalDetailbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username :";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(223, 54);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(239, 22);
            this.username.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(514, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 204);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(589, 342);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(435, 87);
            this.registerBtn.TabIndex = 23;
            this.registerBtn.Text = "REGISTER";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name :";
            // 
            // hosp_name
            // 
            this.hosp_name.Location = new System.Drawing.Point(159, 62);
            this.hosp_name.Name = "hosp_name";
            this.hosp_name.Size = new System.Drawing.Size(239, 22);
            this.hosp_name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact Number :";
            // 
            // hosp_no
            // 
            this.hosp_no.Location = new System.Drawing.Point(159, 137);
            this.hosp_no.Name = "hosp_no";
            this.hosp_no.Size = new System.Drawing.Size(239, 22);
            this.hosp_no.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address :";
            // 
            // hosp_addr
            // 
            this.hosp_addr.Location = new System.Drawing.Point(159, 212);
            this.hosp_addr.Multiline = true;
            this.hosp_addr.Name = "hosp_addr";
            this.hosp_addr.Size = new System.Drawing.Size(239, 55);
            this.hosp_addr.TabIndex = 10;
            // 
            // inc_name
            // 
            this.inc_name.Location = new System.Drawing.Point(159, 320);
            this.inc_name.Name = "inc_name";
            this.inc_name.Size = new System.Drawing.Size(239, 22);
            this.inc_name.TabIndex = 12;
            // 
            // hospitalDetailbox
            // 
            this.hospitalDetailbox.Controls.Add(this.button1);
            this.hospitalDetailbox.Controls.Add(this.label6);
            this.hospitalDetailbox.Controls.Add(this.inc_name);
            this.hospitalDetailbox.Controls.Add(this.label5);
            this.hospitalDetailbox.Controls.Add(this.hosp_addr);
            this.hospitalDetailbox.Controls.Add(this.label4);
            this.hospitalDetailbox.Controls.Add(this.hosp_no);
            this.hospitalDetailbox.Controls.Add(this.label3);
            this.hospitalDetailbox.Controls.Add(this.hosp_name);
            this.hospitalDetailbox.Controls.Add(this.label2);
            this.hospitalDetailbox.Location = new System.Drawing.Point(23, 34);
            this.hospitalDetailbox.Name = "hospitalDetailbox";
            this.hospitalDetailbox.Size = new System.Drawing.Size(476, 493);
            this.hospitalDetailbox.TabIndex = 21;
            this.hospitalDetailbox.TabStop = false;
            this.hospitalDetailbox.Text = "Oxygen Supplier Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Map :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Company Name :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(223, 126);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '*';
            this.maskedTextBox1.PromptChar = '-';
            this.maskedTextBox1.Size = new System.Drawing.Size(239, 22);
            this.maskedTextBox1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Locate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 520);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hospitalDetailbox);
            this.Name = "Form1";
            this.Text = "Register As Supplier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.hospitalDetailbox.ResumeLayout(false);
            this.hospitalDetailbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hosp_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hosp_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hosp_addr;
        private System.Windows.Forms.TextBox inc_name;
        private System.Windows.Forms.GroupBox hospitalDetailbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
    }
}