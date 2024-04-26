namespace GrabAViscan.Feed
{
    partial class PersonalReq
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
            this.flow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaGradiantButton1 = new Guna.UI.WinForms.GunaGradiantButton();
            this.SuspendLayout();
            // 
            // flow1
            // 
            this.flow1.AutoScroll = true;
            this.flow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow1.Location = new System.Drawing.Point(0, 60);
            this.flow1.Name = "flow1";
            this.flow1.Size = new System.Drawing.Size(1982, 1372);
            this.flow1.TabIndex = 18;
            // 
            // gunaGradiantButton1
            // 
            this.gunaGradiantButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradiantButton1.AnimationSpeed = 0.03F;
            this.gunaGradiantButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaGradiantButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(115)))));
            this.gunaGradiantButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradiantButton1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradiantButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradiantButton1.Image = null;
            this.gunaGradiantButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradiantButton1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradiantButton1.Name = "gunaGradiantButton1";
            this.gunaGradiantButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaGradiantButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(115)))));
            this.gunaGradiantButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradiantButton1.OnHoverImage = null;
            this.gunaGradiantButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradiantButton1.Size = new System.Drawing.Size(1982, 60);
            this.gunaGradiantButton1.TabIndex = 17;
            this.gunaGradiantButton1.Text = "PERSONAL REQUEST";
            this.gunaGradiantButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PersonalReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flow1);
            this.Controls.Add(this.gunaGradiantButton1);
            this.Name = "PersonalReq";
            this.Size = new System.Drawing.Size(1982, 1432);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flow1;
        private Guna.UI.WinForms.GunaGradiantButton gunaGradiantButton1;
    }
}
