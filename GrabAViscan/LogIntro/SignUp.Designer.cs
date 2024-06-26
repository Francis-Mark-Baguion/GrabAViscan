﻿namespace GrabAViscan
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.agree = new System.Windows.Forms.CheckBox();
            this.confirm_btn = new Guna.UI.WinForms.GunaButton();
            this.passwordTxt = new Guna.UI.WinForms.GunaTextBox();
            this.emailTxt = new Guna.UI.WinForms.GunaTextBox();
            this.TermsAndConditionLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.LogInLink = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Minimize_btn = new Guna.UI.WinForms.GunaButton();
            this.Close_btn = new Guna.UI.WinForms.GunaButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2560, 1600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.agree);
            this.panel2.Controls.Add(this.confirm_btn);
            this.panel2.Controls.Add(this.passwordTxt);
            this.panel2.Controls.Add(this.emailTxt);
            this.panel2.Controls.Add(this.TermsAndConditionLink);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LogInLink);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(856, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 527);
            this.panel2.TabIndex = 1;
            // 
            // agree
            // 
            this.agree.AutoSize = true;
            this.agree.Location = new System.Drawing.Point(674, 310);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(22, 21);
            this.agree.TabIndex = 11;
            this.agree.UseVisualStyleBackColor = true;
            this.agree.CheckedChanged += new System.EventHandler(this.agree_CheckedChanged);
            // 
            // confirm_btn
            // 
            this.confirm_btn.AnimationHoverSpeed = 0.07F;
            this.confirm_btn.AnimationSpeed = 0.03F;
            this.confirm_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirm_btn.BackgroundImage")));
            this.confirm_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confirm_btn.BaseColor = System.Drawing.Color.Transparent;
            this.confirm_btn.BorderColor = System.Drawing.Color.Black;
            this.confirm_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirm_btn.ForeColor = System.Drawing.Color.White;
            this.confirm_btn.Image = null;
            this.confirm_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.confirm_btn.Location = new System.Drawing.Point(170, 359);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.confirm_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.confirm_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.confirm_btn.OnHoverImage = null;
            this.confirm_btn.OnPressedColor = System.Drawing.Color.Black;
            this.confirm_btn.Size = new System.Drawing.Size(520, 75);
            this.confirm_btn.TabIndex = 10;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.passwordTxt.BorderColor = System.Drawing.Color.Silver;
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.passwordTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(115)))));
            this.passwordTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTxt.Location = new System.Drawing.Point(170, 218);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Radius = 10;
            this.passwordTxt.Size = new System.Drawing.Size(520, 53);
            this.passwordTxt.TabIndex = 9;
            this.passwordTxt.Text = "Password";
            this.passwordTxt.Click += new System.EventHandler(this.passwordTxt_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.emailTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.emailTxt.BorderColor = System.Drawing.Color.Silver;
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.emailTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(115)))));
            this.emailTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTxt.Location = new System.Drawing.Point(170, 108);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(0);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.Radius = 10;
            this.emailTxt.Size = new System.Drawing.Size(520, 53);
            this.emailTxt.TabIndex = 8;
            this.emailTxt.Text = "Email";
            this.emailTxt.Click += new System.EventHandler(this.emailTxt_Click);
            // 
            // TermsAndConditionLink
            // 
            this.TermsAndConditionLink.AutoSize = true;
            this.TermsAndConditionLink.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermsAndConditionLink.LinkColor = System.Drawing.Color.Black;
            this.TermsAndConditionLink.Location = new System.Drawing.Point(439, 302);
            this.TermsAndConditionLink.Name = "TermsAndConditionLink";
            this.TermsAndConditionLink.Size = new System.Drawing.Size(218, 28);
            this.TermsAndConditionLink.TabIndex = 7;
            this.TermsAndConditionLink.TabStop = true;
            this.TermsAndConditionLink.Text = " terms and conditions";
            this.TermsAndConditionLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Terms_and_Condition_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yes, I agree to the";
            // 
            // LogInLink
            // 
            this.LogInLink.AutoSize = true;
            this.LogInLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLink.LinkColor = System.Drawing.Color.Black;
            this.LogInLink.Location = new System.Drawing.Point(512, 452);
            this.LogInLink.Name = "LogInLink";
            this.LogInLink.Size = new System.Drawing.Size(71, 25);
            this.LogInLink.TabIndex = 5;
            this.LogInLink.TabStop = true;
            this.LogInLink.Text = "Log in";
            this.LogInLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Log_In_Redirect);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(170, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(170, 54);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Already have an account?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(1709, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 527);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Minimize_btn);
            this.panel4.Controls.Add(this.Close_btn);
            this.panel4.Location = new System.Drawing.Point(673, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 99);
            this.panel4.TabIndex = 3;
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.AnimationHoverSpeed = 0.07F;
            this.Minimize_btn.AnimationSpeed = 0.03F;
            this.Minimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimize_btn.BaseColor = System.Drawing.Color.Transparent;
            this.Minimize_btn.BorderColor = System.Drawing.Color.Black;
            this.Minimize_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Minimize_btn.ForeColor = System.Drawing.Color.White;
            this.Minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("Minimize_btn.Image")));
            this.Minimize_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Minimize_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.Minimize_btn.Location = new System.Drawing.Point(34, 15);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.Minimize_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Minimize_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Minimize_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("Minimize_btn.OnHoverImage")));
            this.Minimize_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Minimize_btn.Size = new System.Drawing.Size(50, 50);
            this.Minimize_btn.TabIndex = 16;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.AnimationHoverSpeed = 0.07F;
            this.Close_btn.AnimationSpeed = 0.03F;
            this.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close_btn.BaseColor = System.Drawing.Color.Transparent;
            this.Close_btn.BorderColor = System.Drawing.Color.Black;
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Image = ((System.Drawing.Image)(resources.GetObject("Close_btn.Image")));
            this.Close_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Close_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.Close_btn.Location = new System.Drawing.Point(114, 15);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.Close_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Close_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Close_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("Close_btn.OnHoverImage")));
            this.Close_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Close_btn.Size = new System.Drawing.Size(50, 50);
            this.Close_btn.TabIndex = 15;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2560, 1600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel LogInLink;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel TermsAndConditionLink;
        private Guna.UI.WinForms.GunaTextBox emailTxt;
        private Guna.UI.WinForms.GunaTextBox passwordTxt;
        private Guna.UI.WinForms.GunaButton confirm_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaButton Minimize_btn;
        private Guna.UI.WinForms.GunaButton Close_btn;
        private System.Windows.Forms.CheckBox agree;
    }
}