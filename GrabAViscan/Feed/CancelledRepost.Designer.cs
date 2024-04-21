﻿namespace GrabAViscan.Feed
{
    partial class CancelledRepost
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelledRepost));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.repost_btn = new Guna.UI.WinForms.GunaButton();
            this.category = new Guna.UI.WinForms.GunaPictureBox();
            this.dateCompleted = new Guna.UI.WinForms.GunaLabel();
            this.requestTxt = new Guna.UI.WinForms.GunaTextBox();
            this.nameHolder = new Guna.UI.WinForms.GunaTextBox();
            this.profile = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.Label = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.gunaElipsePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.repost_btn);
            this.gunaElipsePanel1.Controls.Add(this.category);
            this.gunaElipsePanel1.Controls.Add(this.dateCompleted);
            this.gunaElipsePanel1.Controls.Add(this.requestTxt);
            this.gunaElipsePanel1.Controls.Add(this.nameHolder);
            this.gunaElipsePanel1.Controls.Add(this.profile);
            this.gunaElipsePanel1.Controls.Add(this.gunaElipsePanel2);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 20;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1960, 100);
            this.gunaElipsePanel1.TabIndex = 4;
            // 
            // repost_btn
            // 
            this.repost_btn.AnimationHoverSpeed = 0.07F;
            this.repost_btn.AnimationSpeed = 0.03F;
            this.repost_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.repost_btn.BorderColor = System.Drawing.Color.Black;
            this.repost_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repost_btn.ForeColor = System.Drawing.Color.White;
            this.repost_btn.Image = null;
            this.repost_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.repost_btn.Location = new System.Drawing.Point(1716, 20);
            this.repost_btn.Name = "repost_btn";
            this.repost_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.repost_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.repost_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.repost_btn.OnHoverImage = null;
            this.repost_btn.OnPressedColor = System.Drawing.Color.Black;
            this.repost_btn.Radius = 10;
            this.repost_btn.Size = new System.Drawing.Size(217, 52);
            this.repost_btn.TabIndex = 58;
            this.repost_btn.Text = "REPOST";
            this.repost_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.repost_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.Transparent;
            this.category.BaseColor = System.Drawing.Color.Transparent;
            this.category.Location = new System.Drawing.Point(940, 10);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(80, 80);
            this.category.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.category.TabIndex = 57;
            this.category.TabStop = false;
            // 
            // dateCompleted
            // 
            this.dateCompleted.AutoSize = true;
            this.dateCompleted.BackColor = System.Drawing.Color.White;
            this.dateCompleted.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateCompleted.Location = new System.Drawing.Point(814, 34);
            this.dateCompleted.Name = "dateCompleted";
            this.dateCompleted.Size = new System.Drawing.Size(86, 25);
            this.dateCompleted.TabIndex = 36;
            this.dateCompleted.Text = "00/00/00";
            // 
            // requestTxt
            // 
            this.requestTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.requestTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.requestTxt.BorderColor = System.Drawing.Color.Silver;
            this.requestTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.requestTxt.Enabled = false;
            this.requestTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.requestTxt.FocusedBorderColor = System.Drawing.Color.Silver;
            this.requestTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.requestTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestTxt.Location = new System.Drawing.Point(1043, 22);
            this.requestTxt.Margin = new System.Windows.Forms.Padding(0);
            this.requestTxt.Name = "requestTxt";
            this.requestTxt.PasswordChar = '\0';
            this.requestTxt.Radius = 10;
            this.requestTxt.Size = new System.Drawing.Size(638, 50);
            this.requestTxt.TabIndex = 34;
            // 
            // nameHolder
            // 
            this.nameHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nameHolder.BaseColor = System.Drawing.Color.White;
            this.nameHolder.BorderColor = System.Drawing.Color.Silver;
            this.nameHolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameHolder.Enabled = false;
            this.nameHolder.FocusedBaseColor = System.Drawing.Color.White;
            this.nameHolder.FocusedBorderColor = System.Drawing.Color.Silver;
            this.nameHolder.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.nameHolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameHolder.Location = new System.Drawing.Point(419, 22);
            this.nameHolder.Margin = new System.Windows.Forms.Padding(0);
            this.nameHolder.Name = "nameHolder";
            this.nameHolder.PasswordChar = '\0';
            this.nameHolder.Radius = 10;
            this.nameHolder.Size = new System.Drawing.Size(370, 50);
            this.nameHolder.TabIndex = 8;
            this.nameHolder.Text = "First Name Last Name";
            this.nameHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.White;
            this.profile.BaseColor = System.Drawing.Color.White;
            this.profile.Image = ((System.Drawing.Image)(resources.GetObject("profile.Image")));
            this.profile.Location = new System.Drawing.Point(319, 10);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(80, 80);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile.TabIndex = 1;
            this.profile.TabStop = false;
            this.profile.UseTransfarantBackground = false;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.Firebrick;
            this.gunaElipsePanel2.Controls.Add(this.Label);
            this.gunaElipsePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaElipsePanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(300, 100);
            this.gunaElipsePanel2.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.White;
            this.Label.Location = new System.Drawing.Point(15, 24);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(218, 48);
            this.Label.TabIndex = 7;
            this.Label.Text = "CANCELLED";
            // 
            // CancelledRepost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "CancelledRepost";
            this.Size = new System.Drawing.Size(1960, 100);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaPictureBox category;
        private Guna.UI.WinForms.GunaLabel dateCompleted;
        private Guna.UI.WinForms.GunaTextBox requestTxt;
        private Guna.UI.WinForms.GunaTextBox nameHolder;
        private Guna.UI.WinForms.GunaCirclePictureBox profile;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaLabel Label;
        private Guna.UI.WinForms.GunaButton repost_btn;
    }
}
