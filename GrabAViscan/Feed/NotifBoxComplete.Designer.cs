namespace GrabAViscan.Feed
{
    partial class NotifBoxComplete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifBoxComplete));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.nameHolder = new Guna.UI.WinForms.GunaTextBox();
            this.category = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.category)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(199, 60);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(241, 25);
            this.gunaLabel1.TabIndex = 63;
            this.gunaLabel1.Text = "COMPLETED YOUR REQUEST";
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
            this.nameHolder.Location = new System.Drawing.Point(128, 6);
            this.nameHolder.Margin = new System.Windows.Forms.Padding(0);
            this.nameHolder.Name = "nameHolder";
            this.nameHolder.PasswordChar = '\0';
            this.nameHolder.Radius = 10;
            this.nameHolder.Size = new System.Drawing.Size(370, 50);
            this.nameHolder.TabIndex = 62;
            this.nameHolder.Text = "First Name Last Name";
            this.nameHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.Transparent;
            this.category.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("category.BackgroundImage")));
            this.category.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.category.BaseColor = System.Drawing.Color.Transparent;
            this.category.Dock = System.Windows.Forms.DockStyle.Left;
            this.category.Location = new System.Drawing.Point(0, 0);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(105, 100);
            this.category.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.category.TabIndex = 61;
            this.category.TabStop = false;
            // 
            // NotifBoxComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.nameHolder);
            this.Controls.Add(this.category);
            this.Name = "NotifBoxComplete";
            this.Size = new System.Drawing.Size(507, 100);
            ((System.ComponentModel.ISupportInitialize)(this.category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox nameHolder;
        private Guna.UI.WinForms.GunaPictureBox category;
    }
}
