namespace GrabAViscan.Popup
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.profile_pic = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.addressHoldler = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.nameHolder = new Guna.UI.WinForms.GunaButton();
            this.emailHolder = new Guna.UI.WinForms.GunaButton();
            this.phoneTxt = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel10 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pic)).BeginInit();
            this.gunaPanel4.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // profile_pic
            // 
            this.profile_pic.BaseColor = System.Drawing.Color.White;
            this.profile_pic.Image = ((System.Drawing.Image)(resources.GetObject("profile_pic.Image")));
            this.profile_pic.Location = new System.Drawing.Point(159, 47);
            this.profile_pic.Name = "profile_pic";
            this.profile_pic.Size = new System.Drawing.Size(300, 300);
            this.profile_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile_pic.TabIndex = 0;
            this.profile_pic.TabStop = false;
            this.profile_pic.UseTransfarantBackground = false;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.White;
            this.gunaPanel4.Controls.Add(this.gunaPanel10);
            this.gunaPanel4.Controls.Add(this.emailHolder);
            this.gunaPanel4.Controls.Add(this.nameHolder);
            this.gunaPanel4.Controls.Add(this.profile_pic);
            this.gunaPanel4.Location = new System.Drawing.Point(12, 24);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(599, 493);
            this.gunaPanel4.TabIndex = 0;
            this.gunaPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel4_Paint);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.White;
            this.gunaPanel2.Controls.Add(this.gunaShadowPanel1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(623, 949);
            this.gunaPanel2.TabIndex = 11;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.gunaPanel1);
            this.gunaShadowPanel1.Controls.Add(this.phoneTxt);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel1.Controls.Add(this.addressHoldler);
            this.gunaShadowPanel1.Controls.Add(this.gunaPanel4);
            this.gunaShadowPanel1.Controls.Add(this.gunaButton4);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel1);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(623, 949);
            this.gunaShadowPanel1.TabIndex = 37;
            // 
            // addressHoldler
            // 
            this.addressHoldler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addressHoldler.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.addressHoldler.BorderColor = System.Drawing.Color.Silver;
            this.addressHoldler.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressHoldler.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.addressHoldler.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.addressHoldler.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.addressHoldler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressHoldler.Location = new System.Drawing.Point(78, 594);
            this.addressHoldler.Margin = new System.Windows.Forms.Padding(0);
            this.addressHoldler.Name = "addressHoldler";
            this.addressHoldler.PasswordChar = '\0';
            this.addressHoldler.Radius = 10;
            this.addressHoldler.Size = new System.Drawing.Size(464, 53);
            this.addressHoldler.TabIndex = 36;
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.Firebrick;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = null;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(203, 857);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.Firebrick;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 10;
            this.gunaButton4.Size = new System.Drawing.Size(220, 70);
            this.gunaButton4.TabIndex = 33;
            this.gunaButton4.Text = "CLOSE";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 544);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(115, 32);
            this.gunaLabel1.TabIndex = 34;
            this.gunaLabel1.Text = "ADDRESS";
            // 
            // nameHolder
            // 
            this.nameHolder.AnimationHoverSpeed = 0.07F;
            this.nameHolder.AnimationSpeed = 0.03F;
            this.nameHolder.BackColor = System.Drawing.Color.Transparent;
            this.nameHolder.BaseColor = System.Drawing.Color.Transparent;
            this.nameHolder.BorderColor = System.Drawing.Color.Black;
            this.nameHolder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameHolder.ForeColor = System.Drawing.Color.Black;
            this.nameHolder.Image = null;
            this.nameHolder.ImageSize = new System.Drawing.Size(20, 20);
            this.nameHolder.Location = new System.Drawing.Point(147, 376);
            this.nameHolder.Name = "nameHolder";
            this.nameHolder.OnHoverBaseColor = System.Drawing.Color.White;
            this.nameHolder.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.nameHolder.OnHoverForeColor = System.Drawing.Color.Black;
            this.nameHolder.OnHoverImage = null;
            this.nameHolder.OnPressedColor = System.Drawing.Color.Black;
            this.nameHolder.Size = new System.Drawing.Size(322, 42);
            this.nameHolder.TabIndex = 9;
            this.nameHolder.Text = "First Name Last Name";
            this.nameHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailHolder
            // 
            this.emailHolder.AnimationHoverSpeed = 0.07F;
            this.emailHolder.AnimationSpeed = 0.03F;
            this.emailHolder.BackColor = System.Drawing.Color.Transparent;
            this.emailHolder.BaseColor = System.Drawing.Color.Transparent;
            this.emailHolder.BorderColor = System.Drawing.Color.Black;
            this.emailHolder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailHolder.ForeColor = System.Drawing.Color.Black;
            this.emailHolder.Image = null;
            this.emailHolder.ImageSize = new System.Drawing.Size(20, 20);
            this.emailHolder.Location = new System.Drawing.Point(147, 432);
            this.emailHolder.Name = "emailHolder";
            this.emailHolder.OnHoverBaseColor = System.Drawing.Color.White;
            this.emailHolder.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.emailHolder.OnHoverForeColor = System.Drawing.Color.Black;
            this.emailHolder.OnHoverImage = null;
            this.emailHolder.OnPressedColor = System.Drawing.Color.Black;
            this.emailHolder.Size = new System.Drawing.Size(322, 42);
            this.emailHolder.TabIndex = 10;
            this.emailHolder.Text = "First Name Last Name";
            this.emailHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneTxt
            // 
            this.phoneTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.phoneTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.phoneTxt.BorderColor = System.Drawing.Color.Silver;
            this.phoneTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.phoneTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.phoneTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.Location = new System.Drawing.Point(78, 744);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(0);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.PasswordChar = '\0';
            this.phoneTxt.Radius = 10;
            this.phoneTxt.Size = new System.Drawing.Size(464, 53);
            this.phoneTxt.TabIndex = 38;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(12, 693);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(135, 32);
            this.gunaLabel2.TabIndex = 37;
            this.gunaLabel2.Text = "PHONE NO";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // gunaPanel10
            // 
            this.gunaPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaPanel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel10.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel10.Name = "gunaPanel10";
            this.gunaPanel10.Size = new System.Drawing.Size(599, 13);
            this.gunaPanel10.TabIndex = 11;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Silver;
            this.gunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel1.Location = new System.Drawing.Point(9, 504);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(599, 13);
            this.gunaPanel1.TabIndex = 12;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 949);
            this.Controls.Add(this.gunaPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.profile_pic)).EndInit();
            this.gunaPanel4.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox profile_pic;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaTextBox addressHoldler;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaButton nameHolder;
        private Guna.UI.WinForms.GunaButton emailHolder;
        private Guna.UI.WinForms.GunaTextBox phoneTxt;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel10;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
    }
}