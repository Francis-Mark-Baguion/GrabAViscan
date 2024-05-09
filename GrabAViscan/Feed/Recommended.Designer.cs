namespace GrabAViscan.Feed
{
    partial class Recommended
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recommended));
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.nameTxt = new Guna.UI.WinForms.GunaLabel();
            this.locationTxt = new Guna.UI.WinForms.GunaLabel();
            this.Pic = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(218, 92);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(50, 50);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 3;
            this.gunaPictureBox2.TabStop = false;
            // 
            // nameTxt
            // 
            this.nameTxt.AutoSize = true;
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(211, 25);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(159, 38);
            this.nameTxt.TabIndex = 4;
            this.nameTxt.Text = "gunaLabel1";
            // 
            // locationTxt
            // 
            this.locationTxt.AutoSize = true;
            this.locationTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTxt.Location = new System.Drawing.Point(288, 101);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(137, 32);
            this.locationTxt.TabIndex = 5;
            this.locationTxt.Text = "gunaLabel2";
            // 
            // Pic
            // 
            this.Pic.BaseColor = System.Drawing.Color.White;
            this.Pic.Location = new System.Drawing.Point(18, 13);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(150, 150);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic.TabIndex = 6;
            this.Pic.TabStop = false;
            // 
            // Recommended
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.gunaPictureBox2);
            this.Name = "Recommended";
            this.Size = new System.Drawing.Size(600, 176);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaLabel nameTxt;
        private Guna.UI.WinForms.GunaLabel locationTxt;
        private Guna.UI.WinForms.GunaPictureBox Pic;
    }
}
