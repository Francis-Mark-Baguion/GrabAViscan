namespace GrabAViscan.Feed
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
            this.dateCompleted = new Guna.UI.WinForms.GunaLabel();
            this.categeryTxt = new Guna.UI.WinForms.GunaTextBox();
            this.nameHolder = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.Label = new Guna.UI.WinForms.GunaLabel();
            this.category = new Guna.UI.WinForms.GunaPictureBox();
            this.profile = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Close_btn = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.Close_btn);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel1.Controls.Add(this.repost_btn);
            this.gunaElipsePanel1.Controls.Add(this.category);
            this.gunaElipsePanel1.Controls.Add(this.dateCompleted);
            this.gunaElipsePanel1.Controls.Add(this.categeryTxt);
            this.gunaElipsePanel1.Controls.Add(this.nameHolder);
            this.gunaElipsePanel1.Controls.Add(this.profile);
            this.gunaElipsePanel1.Controls.Add(this.gunaElipsePanel2);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 20;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1950, 100);
            this.gunaElipsePanel1.TabIndex = 4;
            this.gunaElipsePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel1_Paint);
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
            this.repost_btn.Location = new System.Drawing.Point(1573, 22);
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
            // categeryTxt
            // 
            this.categeryTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.categeryTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.categeryTxt.BorderColor = System.Drawing.Color.Silver;
            this.categeryTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categeryTxt.Enabled = false;
            this.categeryTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.categeryTxt.FocusedBorderColor = System.Drawing.Color.Silver;
            this.categeryTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.categeryTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categeryTxt.Location = new System.Drawing.Point(1043, 22);
            this.categeryTxt.Margin = new System.Windows.Forms.Padding(0);
            this.categeryTxt.Name = "categeryTxt";
            this.categeryTxt.PasswordChar = '\0';
            this.categeryTxt.Radius = 10;
            this.categeryTxt.Size = new System.Drawing.Size(292, 50);
            this.categeryTxt.TabIndex = 34;
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
            this.nameHolder.Location = new System.Drawing.Point(419, 7);
            this.nameHolder.Margin = new System.Windows.Forms.Padding(0);
            this.nameHolder.Name = "nameHolder";
            this.nameHolder.PasswordChar = '\0';
            this.nameHolder.Radius = 10;
            this.nameHolder.Size = new System.Drawing.Size(370, 50);
            this.nameHolder.TabIndex = 8;
            this.nameHolder.Text = "First Name Last Name";
            this.nameHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Label.Location = new System.Drawing.Point(46, 26);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(218, 48);
            this.Label.TabIndex = 7;
            this.Label.Text = "CANCELLED";
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
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(487, 65);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(252, 35);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "CANCELLED YOUR REQUEST";
            // 
            // Close_btn
            // 
            this.Close_btn.AnimationHoverSpeed = 0.07F;
            this.Close_btn.AnimationSpeed = 0.03F;
            this.Close_btn.BackColor = System.Drawing.Color.Transparent;
            this.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close_btn.BaseColor = System.Drawing.Color.Transparent;
            this.Close_btn.BorderColor = System.Drawing.Color.Black;
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Image = ((System.Drawing.Image)(resources.GetObject("Close_btn.Image")));
            this.Close_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Close_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.Close_btn.Location = new System.Drawing.Point(1865, 14);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.Close_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Close_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Close_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("Close_btn.OnHoverImage")));
            this.Close_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Close_btn.Size = new System.Drawing.Size(71, 68);
            this.Close_btn.TabIndex = 63;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // CancelledRepost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "CancelledRepost";
            this.Size = new System.Drawing.Size(1950, 100);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaPictureBox category;
        private Guna.UI.WinForms.GunaLabel dateCompleted;
        private Guna.UI.WinForms.GunaTextBox categeryTxt;
        private Guna.UI.WinForms.GunaTextBox nameHolder;
        private Guna.UI.WinForms.GunaCirclePictureBox profile;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaLabel Label;
        private Guna.UI.WinForms.GunaButton repost_btn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton Close_btn;
    }
}
