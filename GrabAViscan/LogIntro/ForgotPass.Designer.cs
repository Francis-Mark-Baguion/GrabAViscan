namespace GrabAViscan.LogIntro
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.changePass_btn = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Close_btn = new Guna.UI.WinForms.GunaButton();
            this.emailTxt = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // changePass_btn
            // 
            this.changePass_btn.AnimationHoverSpeed = 0.07F;
            this.changePass_btn.AnimationSpeed = 0.03F;
            this.changePass_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.changePass_btn.BorderColor = System.Drawing.Color.Black;
            this.changePass_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePass_btn.ForeColor = System.Drawing.Color.White;
            this.changePass_btn.Image = null;
            this.changePass_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.changePass_btn.Location = new System.Drawing.Point(307, 445);
            this.changePass_btn.Name = "changePass_btn";
            this.changePass_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.changePass_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.changePass_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.changePass_btn.OnHoverImage = null;
            this.changePass_btn.OnPressedColor = System.Drawing.Color.Black;
            this.changePass_btn.Radius = 10;
            this.changePass_btn.Size = new System.Drawing.Size(220, 70);
            this.changePass_btn.TabIndex = 49;
            this.changePass_btn.Text = "Continue";
            this.changePass_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.changePass_btn.Click += new System.EventHandler(this.changePass_btn_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaLabel1.Location = new System.Drawing.Point(299, 244);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(271, 45);
            this.gunaLabel1.TabIndex = 50;
            this.gunaLabel1.Text = "Forgot Password?";
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
            this.Close_btn.Location = new System.Drawing.Point(12, 12);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.Close_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Close_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Close_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("Close_btn.OnHoverImage")));
            this.Close_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Close_btn.Size = new System.Drawing.Size(50, 50);
            this.Close_btn.TabIndex = 48;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.emailTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.emailTxt.BorderColor = System.Drawing.Color.Silver;
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.emailTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.emailTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTxt.Location = new System.Drawing.Point(153, 336);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(0);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.Radius = 10;
            this.emailTxt.Size = new System.Drawing.Size(520, 53);
            this.emailTxt.TabIndex = 52;
            this.emailTxt.Text = "Enter Email";
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 805);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.changePass_btn);
            this.Controls.Add(this.Close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton Close_btn;
        private Guna.UI.WinForms.GunaButton changePass_btn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox emailTxt;
    }
}