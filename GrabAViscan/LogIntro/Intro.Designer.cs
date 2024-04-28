namespace GrabAViscan
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.signUp_btn = new Guna.UI.WinForms.GunaButton();
            this.Log_in_btn = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signUp_btn
            // 
            this.signUp_btn.AnimationHoverSpeed = 0.07F;
            this.signUp_btn.AnimationSpeed = 0.03F;
            this.signUp_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUp_btn.BackgroundImage")));
            this.signUp_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signUp_btn.BaseColor = System.Drawing.Color.Transparent;
            this.signUp_btn.BorderColor = System.Drawing.Color.Black;
            this.signUp_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signUp_btn.ForeColor = System.Drawing.Color.White;
            this.signUp_btn.Image = null;
            this.signUp_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.signUp_btn.Location = new System.Drawing.Point(1010, 1061);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.signUp_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.signUp_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.signUp_btn.OnHoverImage = null;
            this.signUp_btn.OnPressedColor = System.Drawing.Color.Black;
            this.signUp_btn.Size = new System.Drawing.Size(520, 75);
            this.signUp_btn.TabIndex = 6;
            this.signUp_btn.Click += new System.EventHandler(this.signUp_btn_Click);
            // 
            // Log_in_btn
            // 
            this.Log_in_btn.AnimationHoverSpeed = 0.07F;
            this.Log_in_btn.AnimationSpeed = 0.03F;
            this.Log_in_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Log_in_btn.BackgroundImage")));
            this.Log_in_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Log_in_btn.BaseColor = System.Drawing.Color.Transparent;
            this.Log_in_btn.BorderColor = System.Drawing.Color.Black;
            this.Log_in_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Log_in_btn.ForeColor = System.Drawing.Color.White;
            this.Log_in_btn.Image = null;
            this.Log_in_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.Log_in_btn.Location = new System.Drawing.Point(1010, 929);
            this.Log_in_btn.Name = "Log_in_btn";
            this.Log_in_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Log_in_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Log_in_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Log_in_btn.OnHoverImage = null;
            this.Log_in_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Log_in_btn.Size = new System.Drawing.Size(520, 75);
            this.Log_in_btn.TabIndex = 4;
            this.Log_in_btn.Click += new System.EventHandler(this.Log_in_btn_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(536, 252);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(1455, 576);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 5;
            this.gunaPictureBox1.TabStop = false;
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2560, 1600);
            this.Controls.Add(this.signUp_btn);
            this.Controls.Add(this.Log_in_btn);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Intro";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton signUp_btn;
        private Guna.UI.WinForms.GunaButton Log_in_btn;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}

