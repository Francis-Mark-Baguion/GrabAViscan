namespace GrabAViscan.Classes.notif
{
    partial class Notify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notify));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.flow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Close_btn = new Guna.UI.WinForms.GunaButton();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(199, 45);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Notification";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.Close_btn);
            this.gunaShadowPanel1.Controls.Add(this.flow1);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel1);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(600, 1061);
            this.gunaShadowPanel1.TabIndex = 0;
            this.gunaShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaShadowPanel1_Paint);
            // 
            // flow1
            // 
            this.flow1.AutoScroll = true;
            this.flow1.BackColor = System.Drawing.Color.White;
            this.flow1.Location = new System.Drawing.Point(20, 108);
            this.flow1.Name = "flow1";
            this.flow1.Size = new System.Drawing.Size(555, 941);
            this.flow1.TabIndex = 1;
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
            this.Close_btn.Location = new System.Drawing.Point(525, 16);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.Close_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Close_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Close_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("Close_btn.OnHoverImage")));
            this.Close_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Close_btn.Size = new System.Drawing.Size(50, 50);
            this.Close_btn.TabIndex = 32;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 1061);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1200, 142);
            this.Name = "Notify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notify";
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.FlowLayoutPanel flow1;
        private Guna.UI.WinForms.GunaButton Close_btn;
    }
}