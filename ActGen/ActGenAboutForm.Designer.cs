﻿namespace ActGen
{
    partial class ActGenAboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActGenAboutForm));
            this.label_about_title = new System.Windows.Forms.Label();
            this.label_about_detail1 = new System.Windows.Forms.Label();
            this.label_about_version = new System.Windows.Forms.Label();
            this.label_about_detail2 = new System.Windows.Forms.Label();
            this.label_about_contact = new System.Windows.Forms.Label();
            this.linkLabel_about_contact = new System.Windows.Forms.LinkLabel();
            this.label_about_website = new System.Windows.Forms.Label();
            this.linkLabel_about_website = new System.Windows.Forms.LinkLabel();
            this.button_about_donate = new System.Windows.Forms.Button();
            this.button_about_close = new System.Windows.Forms.Button();
            this.linkLabel_about_sourcecode = new System.Windows.Forms.LinkLabel();
            this.label_about_sourcecode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_about_title
            // 
            this.label_about_title.AutoSize = true;
            this.label_about_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_about_title.Location = new System.Drawing.Point(114, 6);
            this.label_about_title.Name = "label_about_title";
            this.label_about_title.Size = new System.Drawing.Size(89, 25);
            this.label_about_title.TabIndex = 0;
            this.label_about_title.Text = "ActGen\r\n";
            // 
            // label_about_detail1
            // 
            this.label_about_detail1.AutoSize = true;
            this.label_about_detail1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_about_detail1.Location = new System.Drawing.Point(12, 89);
            this.label_about_detail1.Name = "label_about_detail1";
            this.label_about_detail1.Size = new System.Drawing.Size(290, 15);
            this.label_about_detail1.TabIndex = 1;
            this.label_about_detail1.Text = " A strong password/activation/serial code generator.\r\n";
            // 
            // label_about_version
            // 
            this.label_about_version.AutoSize = true;
            this.label_about_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_about_version.Location = new System.Drawing.Point(108, 31);
            this.label_about_version.Name = "label_about_version";
            this.label_about_version.Size = new System.Drawing.Size(101, 16);
            this.label_about_version.TabIndex = 2;
            this.label_about_version.Text = "Version: 2.01.11";
            // 
            // label_about_detail2
            // 
            this.label_about_detail2.AutoSize = true;
            this.label_about_detail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_about_detail2.Location = new System.Drawing.Point(118, 52);
            this.label_about_detail2.Name = "label_about_detail2";
            this.label_about_detail2.Size = new System.Drawing.Size(80, 13);
            this.label_about_detail2.TabIndex = 3;
            this.label_about_detail2.Text = "By: Brady Shea";
            // 
            // label_about_contact
            // 
            this.label_about_contact.AutoSize = true;
            this.label_about_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_about_contact.Location = new System.Drawing.Point(32, 115);
            this.label_about_contact.Name = "label_about_contact";
            this.label_about_contact.Size = new System.Drawing.Size(51, 13);
            this.label_about_contact.TabIndex = 4;
            this.label_about_contact.Text = "Contact";
            // 
            // linkLabel_about_contact
            // 
            this.linkLabel_about_contact.AutoSize = true;
            this.linkLabel_about_contact.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_about_contact.Location = new System.Drawing.Point(45, 128);
            this.linkLabel_about_contact.Name = "linkLabel_about_contact";
            this.linkLabel_about_contact.Size = new System.Drawing.Size(109, 13);
            this.linkLabel_about_contact.TabIndex = 5;
            this.linkLabel_about_contact.TabStop = true;
            this.linkLabel_about_contact.Text = "actgen@holylinux.net";
            this.linkLabel_about_contact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_about_contact_LinkClicked);
            // 
            // label_about_website
            // 
            this.label_about_website.AutoSize = true;
            this.label_about_website.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_about_website.Location = new System.Drawing.Point(32, 146);
            this.label_about_website.Name = "label_about_website";
            this.label_about_website.Size = new System.Drawing.Size(53, 13);
            this.label_about_website.TabIndex = 6;
            this.label_about_website.Text = "Website";
            // 
            // linkLabel_about_website
            // 
            this.linkLabel_about_website.AutoSize = true;
            this.linkLabel_about_website.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_about_website.Location = new System.Drawing.Point(45, 160);
            this.linkLabel_about_website.Name = "linkLabel_about_website";
            this.linkLabel_about_website.Size = new System.Drawing.Size(195, 13);
            this.linkLabel_about_website.TabIndex = 7;
            this.linkLabel_about_website.TabStop = true;
            this.linkLabel_about_website.Text = "https://www.holylinux.net/code/actgen";
            this.linkLabel_about_website.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_about_website_LinkClicked);
            // 
            // button_about_donate
            // 
            this.button_about_donate.Location = new System.Drawing.Point(12, 225);
            this.button_about_donate.Name = "button_about_donate";
            this.button_about_donate.Size = new System.Drawing.Size(87, 25);
            this.button_about_donate.TabIndex = 8;
            this.button_about_donate.Text = "Donate";
            this.button_about_donate.UseVisualStyleBackColor = true;
            this.button_about_donate.Click += new System.EventHandler(this.button_about_donate_Click);
            // 
            // button_about_close
            // 
            this.button_about_close.Location = new System.Drawing.Point(217, 225);
            this.button_about_close.Name = "button_about_close";
            this.button_about_close.Size = new System.Drawing.Size(87, 25);
            this.button_about_close.TabIndex = 9;
            this.button_about_close.Text = "Close";
            this.button_about_close.UseVisualStyleBackColor = true;
            this.button_about_close.Click += new System.EventHandler(this.button_about_close_Click);
            // 
            // linkLabel_about_sourcecode
            // 
            this.linkLabel_about_sourcecode.AutoSize = true;
            this.linkLabel_about_sourcecode.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_about_sourcecode.Location = new System.Drawing.Point(45, 188);
            this.linkLabel_about_sourcecode.Name = "linkLabel_about_sourcecode";
            this.linkLabel_about_sourcecode.Size = new System.Drawing.Size(216, 13);
            this.linkLabel_about_sourcecode.TabIndex = 11;
            this.linkLabel_about_sourcecode.TabStop = true;
            this.linkLabel_about_sourcecode.Text = "https://github.com/bmatthewshea/ActGen2";
            // 
            // label_about_sourcecode
            // 
            this.label_about_sourcecode.AutoSize = true;
            this.label_about_sourcecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_about_sourcecode.Location = new System.Drawing.Point(32, 175);
            this.label_about_sourcecode.Name = "label_about_sourcecode";
            this.label_about_sourcecode.Size = new System.Drawing.Size(47, 13);
            this.label_about_sourcecode.TabIndex = 10;
            this.label_about_sourcecode.Text = "Source";
            // 
            // ActGenAboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 262);
            this.Controls.Add(this.linkLabel_about_sourcecode);
            this.Controls.Add(this.label_about_sourcecode);
            this.Controls.Add(this.button_about_close);
            this.Controls.Add(this.button_about_donate);
            this.Controls.Add(this.linkLabel_about_website);
            this.Controls.Add(this.label_about_website);
            this.Controls.Add(this.linkLabel_about_contact);
            this.Controls.Add(this.label_about_contact);
            this.Controls.Add(this.label_about_detail2);
            this.Controls.Add(this.label_about_version);
            this.Controls.Add(this.label_about_detail1);
            this.Controls.Add(this.label_about_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActGenAboutForm";
            this.Text = "About ActGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_about_title;
        private System.Windows.Forms.Label label_about_detail1;
        private System.Windows.Forms.Label label_about_version;
        private System.Windows.Forms.Label label_about_detail2;
        private System.Windows.Forms.Label label_about_contact;
        private System.Windows.Forms.LinkLabel linkLabel_about_contact;
        private System.Windows.Forms.Label label_about_website;
        private System.Windows.Forms.LinkLabel linkLabel_about_website;
        private System.Windows.Forms.Button button_about_donate;
        private System.Windows.Forms.Button button_about_close;
        private System.Windows.Forms.LinkLabel linkLabel_about_sourcecode;
        private System.Windows.Forms.Label label_about_sourcecode;
    }
}