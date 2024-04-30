namespace GrabAViscan
{
    partial class rightWing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rightWing));
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.nameHolder = new Guna.UI.WinForms.GunaButton();
            this.Notif_btn = new Guna.UI.WinForms.GunaButton();
            this.EditPost_btn = new Guna.UI.WinForms.GunaButton();
            this.ProfilePic = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.flow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.gunaLabel1);
            this.gunaPanel3.Controls.Add(this.nameHolder);
            this.gunaPanel3.Controls.Add(this.Notif_btn);
            this.gunaPanel3.Controls.Add(this.EditPost_btn);
            this.gunaPanel3.Controls.Add(this.ProfilePic);
            this.gunaPanel3.Controls.Add(this.label1);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(640, 235);
            this.gunaPanel3.TabIndex = 3;
            // 
            // nameHolder
            // 
            this.nameHolder.AnimationHoverSpeed = 0.07F;
            this.nameHolder.AnimationSpeed = 0.03F;
            this.nameHolder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.nameHolder.BorderColor = System.Drawing.Color.Black;
            this.nameHolder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameHolder.ForeColor = System.Drawing.Color.Black;
            this.nameHolder.Image = null;
            this.nameHolder.ImageSize = new System.Drawing.Size(20, 20);
            this.nameHolder.Location = new System.Drawing.Point(218, 32);
            this.nameHolder.Name = "nameHolder";
            this.nameHolder.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.nameHolder.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.nameHolder.OnHoverForeColor = System.Drawing.Color.Black;
            this.nameHolder.OnHoverImage = null;
            this.nameHolder.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.nameHolder.Radius = 10;
            this.nameHolder.Size = new System.Drawing.Size(308, 55);
            this.nameHolder.TabIndex = 1;
            this.nameHolder.Text = "Francis Mark Baguion";
            this.nameHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nameHolder.Click += new System.EventHandler(this.nameHolder_Click);
            // 
            // Notif_btn
            // 
            this.Notif_btn.AnimationHoverSpeed = 0.07F;
            this.Notif_btn.AnimationSpeed = 0.03F;
            this.Notif_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Notif_btn.BaseColor = System.Drawing.Color.Transparent;
            this.Notif_btn.BorderColor = System.Drawing.Color.Black;
            this.Notif_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Notif_btn.ForeColor = System.Drawing.Color.White;
            this.Notif_btn.Image = ((System.Drawing.Image)(resources.GetObject("Notif_btn.Image")));
            this.Notif_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Notif_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.Notif_btn.Location = new System.Drawing.Point(139, 27);
            this.Notif_btn.Name = "Notif_btn";
            this.Notif_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.Notif_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Notif_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Notif_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("Notif_btn.OnHoverImage")));
            this.Notif_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Notif_btn.Radius = 10;
            this.Notif_btn.Size = new System.Drawing.Size(73, 71);
            this.Notif_btn.TabIndex = 15;
            this.Notif_btn.Click += new System.EventHandler(this.Notification_click);
            // 
            // EditPost_btn
            // 
            this.EditPost_btn.AnimationHoverSpeed = 0.07F;
            this.EditPost_btn.AnimationSpeed = 0.03F;
            this.EditPost_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditPost_btn.BaseColor = System.Drawing.Color.Transparent;
            this.EditPost_btn.BorderColor = System.Drawing.Color.Black;
            this.EditPost_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditPost_btn.ForeColor = System.Drawing.Color.White;
            this.EditPost_btn.Image = ((System.Drawing.Image)(resources.GetObject("EditPost_btn.Image")));
            this.EditPost_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EditPost_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.EditPost_btn.Location = new System.Drawing.Point(51, 27);
            this.EditPost_btn.Name = "EditPost_btn";
            this.EditPost_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.EditPost_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EditPost_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.EditPost_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("EditPost_btn.OnHoverImage")));
            this.EditPost_btn.OnPressedColor = System.Drawing.Color.Black;
            this.EditPost_btn.Radius = 10;
            this.EditPost_btn.Size = new System.Drawing.Size(73, 71);
            this.EditPost_btn.TabIndex = 14;
            this.EditPost_btn.Click += new System.EventHandler(this.EditPost_btn_Click);
            // 
            // ProfilePic
            // 
            this.ProfilePic.BaseColor = System.Drawing.Color.White;
            this.ProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePic.Image")));
            this.ProfilePic.Location = new System.Drawing.Point(542, 22);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(76, 76);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePic.TabIndex = 8;
            this.ProfilePic.TabStop = false;
            this.ProfilePic.UseTransfarantBackground = false;
            this.ProfilePic.Click += new System.EventHandler(this.ProfilePic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.label1.Location = new System.Drawing.Point(3, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "______________________________";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // flow1
            // 
            this.flow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow1.Location = new System.Drawing.Point(0, 235);
            this.flow1.Name = "flow1";
            this.flow1.Size = new System.Drawing.Size(640, 1263);
            this.flow1.TabIndex = 4;
            this.flow1.Paint += new System.Windows.Forms.PaintEventHandler(this.flow1_Paint);
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(16, 180);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(224, 38);
            this.gunaLabel1.TabIndex = 16;
            this.gunaLabel1.Text = "RECOMMENDED";
            // 
            // rightWing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.flow1);
            this.Controls.Add(this.gunaPanel3);
            this.Name = "rightWing";
            this.Size = new System.Drawing.Size(640, 1498);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaCirclePictureBox ProfilePic;
        private Guna.UI.WinForms.GunaButton nameHolder;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton Notif_btn;
        private Guna.UI.WinForms.GunaButton EditPost_btn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.FlowLayoutPanel flow1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
    }
}
