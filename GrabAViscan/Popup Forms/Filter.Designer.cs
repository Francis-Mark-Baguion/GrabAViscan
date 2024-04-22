namespace GrabAViscan.Popup_Forms
{
    partial class Filter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filter));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.place = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.Close_btn = new Guna.UI.WinForms.GunaButton();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(16, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(52, 25);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Place";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(219, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(84, 25);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Category";
            // 
            // place
            // 
            this.place.FormattingEnabled = true;
            this.place.Location = new System.Drawing.Point(21, 54);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(121, 28);
            this.place.TabIndex = 4;
            this.place.SelectedIndexChanged += new System.EventHandler(this.place_SelectedIndexChanged);
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(224, 54);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 28);
            this.category.TabIndex = 5;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged_1);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(398, 54);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(139, 28);
            this.gunaButton1.TabIndex = 6;
            this.gunaButton1.Text = "CLEAR";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.Close_btn);
            this.gunaShadowPanel1.Controls.Add(this.category);
            this.gunaShadowPanel1.Controls.Add(this.gunaButton1);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel1);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel1.Controls.Add(this.place);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(551, 103);
            this.gunaShadowPanel1.TabIndex = 7;
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
            this.Close_btn.Location = new System.Drawing.Point(514, 12);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.Close_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Close_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Close_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("Close_btn.OnHoverImage")));
            this.Close_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Close_btn.Size = new System.Drawing.Size(25, 25);
            this.Close_btn.TabIndex = 14;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 103);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 63);
            this.Name = "Filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.Filter_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.ComboBox place;
        private System.Windows.Forms.ComboBox category;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaButton Close_btn;
    }
}