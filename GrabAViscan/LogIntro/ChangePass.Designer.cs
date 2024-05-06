namespace GrabAViscan.LogIntro
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.changePass_btn = new Guna.UI.WinForms.GunaButton();
            this.codeTxt = new Guna.UI.WinForms.GunaTextBox();
            this.Close_btn = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.newPassTxt = new Guna.UI.WinForms.GunaTextBox();
            this.confirmTxt = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaLabel1.Location = new System.Drawing.Point(246, 176);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(347, 48);
            this.gunaLabel1.TabIndex = 54;
            this.gunaLabel1.Text = "Reset your password";
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
            this.changePass_btn.Location = new System.Drawing.Point(307, 571);
            this.changePass_btn.Name = "changePass_btn";
            this.changePass_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.changePass_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.changePass_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.changePass_btn.OnHoverImage = null;
            this.changePass_btn.OnPressedColor = System.Drawing.Color.Black;
            this.changePass_btn.Radius = 10;
            this.changePass_btn.Size = new System.Drawing.Size(220, 70);
            this.changePass_btn.TabIndex = 53;
            this.changePass_btn.Text = "Reset Password";
            this.changePass_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.changePass_btn.Click += new System.EventHandler(this.changePass_btn_Click);
            // 
            // codeTxt
            // 
            this.codeTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.codeTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.codeTxt.BorderColor = System.Drawing.Color.Silver;
            this.codeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.codeTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(115)))));
            this.codeTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.codeTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.codeTxt.Location = new System.Drawing.Point(157, 302);
            this.codeTxt.Margin = new System.Windows.Forms.Padding(0);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.PasswordChar = '\0';
            this.codeTxt.Radius = 10;
            this.codeTxt.Size = new System.Drawing.Size(520, 53);
            this.codeTxt.TabIndex = 51;
            this.codeTxt.Text = "Enter Code";
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
            this.Close_btn.TabIndex = 52;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaLabel2.Location = new System.Drawing.Point(240, 248);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(361, 30);
            this.gunaLabel2.TabIndex = 55;
            this.gunaLabel2.Text = "We have set the code to your email.";
            // 
            // newPassTxt
            // 
            this.newPassTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newPassTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.newPassTxt.BorderColor = System.Drawing.Color.Silver;
            this.newPassTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPassTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.newPassTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(115)))));
            this.newPassTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.newPassTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newPassTxt.Location = new System.Drawing.Point(157, 391);
            this.newPassTxt.Margin = new System.Windows.Forms.Padding(0);
            this.newPassTxt.Name = "newPassTxt";
            this.newPassTxt.PasswordChar = '\0';
            this.newPassTxt.Radius = 10;
            this.newPassTxt.Size = new System.Drawing.Size(520, 53);
            this.newPassTxt.TabIndex = 56;
            this.newPassTxt.Text = "New password";
            // 
            // confirmTxt
            // 
            this.confirmTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.confirmTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.confirmTxt.BorderColor = System.Drawing.Color.Silver;
            this.confirmTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.confirmTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(115)))));
            this.confirmTxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmTxt.Location = new System.Drawing.Point(157, 479);
            this.confirmTxt.Margin = new System.Windows.Forms.Padding(0);
            this.confirmTxt.Name = "confirmTxt";
            this.confirmTxt.PasswordChar = '\0';
            this.confirmTxt.Radius = 10;
            this.confirmTxt.Size = new System.Drawing.Size(520, 53);
            this.confirmTxt.TabIndex = 57;
            this.confirmTxt.Text = "Confirm Password";
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 805);
            this.Controls.Add(this.confirmTxt);
            this.Controls.Add(this.newPassTxt);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.changePass_btn);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.codeTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton changePass_btn;
        private Guna.UI.WinForms.GunaButton Close_btn;
        private Guna.UI.WinForms.GunaTextBox codeTxt;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox newPassTxt;
        private Guna.UI.WinForms.GunaTextBox confirmTxt;
    }
}