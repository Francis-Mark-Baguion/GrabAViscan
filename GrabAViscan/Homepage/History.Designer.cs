namespace GrabAViscan
{
    partial class History
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradiantButton1 = new Guna.UI.WinForms.GunaGradiantButton();
            this.flow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1982, 65);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(51, 6);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(144, 48);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "History";
            // 
            // gunaGradiantButton1
            // 
            this.gunaGradiantButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradiantButton1.AnimationSpeed = 0.03F;
            this.gunaGradiantButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaGradiantButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(115)))));
            this.gunaGradiantButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradiantButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradiantButton1.Image = null;
            this.gunaGradiantButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradiantButton1.Location = new System.Drawing.Point(-3, 57);
            this.gunaGradiantButton1.Name = "gunaGradiantButton1";
            this.gunaGradiantButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaGradiantButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(115)))));
            this.gunaGradiantButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradiantButton1.OnHoverImage = null;
            this.gunaGradiantButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradiantButton1.Size = new System.Drawing.Size(1985, 172);
            this.gunaGradiantButton1.TabIndex = 15;
            // 
            // flow1
            // 
            this.flow1.AutoScroll = true;
            this.flow1.Location = new System.Drawing.Point(-3, 230);
            this.flow1.Name = "flow1";
            this.flow1.Size = new System.Drawing.Size(1985, 1262);
            this.flow1.TabIndex = 16;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.flow1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaGradiantButton1);
            this.Name = "History";
            this.Size = new System.Drawing.Size(1982, 1497);
            this.Load += new System.EventHandler(this.History_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaGradiantButton gunaGradiantButton1;
        private System.Windows.Forms.FlowLayoutPanel flow1;
    }
}
