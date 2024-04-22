namespace GrabAViscan.notif
{
    partial class NotifBoxCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifBoxCancel));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.category = new Guna.UI.WinForms.GunaPictureBox();
            this.nameHolder = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.category)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(190, 60);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(236, 25);
            this.gunaLabel1.TabIndex = 60;
            this.gunaLabel1.Text = "CANCELLED YOUR REQUEST";
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.Transparent;
            this.category.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("category.BackgroundImage")));
            this.category.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.category.BaseColor = System.Drawing.Color.Transparent;
            this.category.Location = new System.Drawing.Point(0, 0);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(100, 100);
            this.category.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.category.TabIndex = 58;
            this.category.TabStop = false;
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
            this.nameHolder.Location = new System.Drawing.Point(119, 6);
            this.nameHolder.Margin = new System.Windows.Forms.Padding(0);
            this.nameHolder.Name = "nameHolder";
            this.nameHolder.PasswordChar = '\0';
            this.nameHolder.Radius = 10;
            this.nameHolder.Size = new System.Drawing.Size(370, 50);
            this.nameHolder.TabIndex = 59;
            this.nameHolder.Text = "First Name Last Name";
            this.nameHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NotifBoxCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.nameHolder);
            this.Controls.Add(this.category);
            this.Name = "NotifBoxCancel";
            this.Size = new System.Drawing.Size(507, 100);
            ((System.ComponentModel.ISupportInitialize)(this.category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox category;
        private Guna.UI.WinForms.GunaTextBox nameHolder;
    }
}
