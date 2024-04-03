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
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaButton10 = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaPanel3.Controls.Add(this.gunaButton10);
            this.gunaPanel3.Controls.Add(this.label1);
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(533, 408);
            this.gunaPanel3.TabIndex = 3;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(436, 11);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(76, 76);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 8;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // gunaButton10
            // 
            this.gunaButton10.AnimationHoverSpeed = 0.07F;
            this.gunaButton10.AnimationSpeed = 0.03F;
            this.gunaButton10.BaseColor = System.Drawing.Color.White;
            this.gunaButton10.BorderColor = System.Drawing.Color.Black;
            this.gunaButton10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton10.ForeColor = System.Drawing.Color.Black;
            this.gunaButton10.Image = null;
            this.gunaButton10.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton10.Location = new System.Drawing.Point(50, 22);
            this.gunaButton10.Name = "gunaButton10";
            this.gunaButton10.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaButton10.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton10.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton10.OnHoverImage = null;
            this.gunaButton10.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton10.Radius = 5;
            this.gunaButton10.Size = new System.Drawing.Size(371, 55);
            this.gunaButton10.TabIndex = 1;
            this.gunaButton10.Text = "Francis Mark Baguion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "_________________________";
            // 
            // rightWing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaPanel3);
            this.Name = "rightWing";
            this.Size = new System.Drawing.Size(532, 1504);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaButton gunaButton10;
        private System.Windows.Forms.Label label1;
    }
}
