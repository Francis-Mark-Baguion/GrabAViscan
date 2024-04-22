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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.flow1 = new System.Windows.Forms.FlowLayoutPanel();
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
    }
}