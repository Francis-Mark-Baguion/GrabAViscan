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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.flow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_personal = new Guna.UI.WinForms.GunaButton();
            this.btn_delivery = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.btn_delivery);
            this.gunaPanel1.Controls.Add(this.btn_personal);
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
            // flow1
            // 
            this.flow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow1.Location = new System.Drawing.Point(0, 65);
            this.flow1.Name = "flow1";
            this.flow1.Size = new System.Drawing.Size(1982, 1432);
            this.flow1.TabIndex = 16;
            // 
            // btn_personal
            // 
            this.btn_personal.AnimationHoverSpeed = 0.07F;
            this.btn_personal.AnimationSpeed = 0.03F;
            this.btn_personal.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btn_personal.BorderColor = System.Drawing.Color.Black;
            this.btn_personal.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_personal.ForeColor = System.Drawing.Color.Black;
            this.btn_personal.Image = ((System.Drawing.Image)(resources.GetObject("btn_personal.Image")));
            this.btn_personal.ImageOffsetX = 20;
            this.btn_personal.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_personal.Location = new System.Drawing.Point(235, 3);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.btn_personal.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_personal.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_personal.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btn_personal.OnHoverImage")));
            this.btn_personal.OnPressedColor = System.Drawing.Color.Black;
            this.btn_personal.Radius = 15;
            this.btn_personal.Size = new System.Drawing.Size(473, 60);
            this.btn_personal.TabIndex = 6;
            this.btn_personal.Text = "PERSONAL REQUEST";
            this.btn_personal.TextOffsetX = 30;
            this.btn_personal.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // btn_delivery
            // 
            this.btn_delivery.AnimationHoverSpeed = 0.07F;
            this.btn_delivery.AnimationSpeed = 0.03F;
            this.btn_delivery.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btn_delivery.BorderColor = System.Drawing.Color.Black;
            this.btn_delivery.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delivery.ForeColor = System.Drawing.Color.Black;
            this.btn_delivery.Image = ((System.Drawing.Image)(resources.GetObject("btn_delivery.Image")));
            this.btn_delivery.ImageOffsetX = 20;
            this.btn_delivery.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_delivery.Location = new System.Drawing.Point(714, 2);
            this.btn_delivery.Name = "btn_delivery";
            this.btn_delivery.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.btn_delivery.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_delivery.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_delivery.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btn_delivery.OnHoverImage")));
            this.btn_delivery.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delivery.Radius = 15;
            this.btn_delivery.Size = new System.Drawing.Size(400, 60);
            this.btn_delivery.TabIndex = 7;
            this.btn_delivery.Text = "DELIVERIES";
            this.btn_delivery.TextOffsetX = 30;
            this.btn_delivery.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.flow1);
            this.Controls.Add(this.gunaPanel1);
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
        private System.Windows.Forms.FlowLayoutPanel flow1;
        private Guna.UI.WinForms.GunaButton btn_delivery;
        private Guna.UI.WinForms.GunaButton btn_personal;
    }
}
