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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signUp_btn = new Guna.UI.WinForms.GunaButton();
            this.Log_in_btn = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LOGO = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2561, 1600);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.signUp_btn);
            this.panel1.Controls.Add(this.Log_in_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(853, 533);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 533);
            this.panel1.TabIndex = 0;
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
            this.signUp_btn.Location = new System.Drawing.Point(181, 296);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.signUp_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.signUp_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.signUp_btn.OnHoverImage = null;
            this.signUp_btn.OnPressedColor = System.Drawing.Color.Black;
            this.signUp_btn.Size = new System.Drawing.Size(520, 75);
            this.signUp_btn.TabIndex = 3;
            this.signUp_btn.Click += new System.EventHandler(this.Sign_up_Click);
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
            this.Log_in_btn.Location = new System.Drawing.Point(181, 201);
            this.Log_in_btn.Name = "Log_in_btn";
            this.Log_in_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Log_in_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Log_in_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Log_in_btn.OnHoverImage = null;
            this.Log_in_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Log_in_btn.Size = new System.Drawing.Size(520, 75);
            this.Log_in_btn.TabIndex = 2;
            this.Log_in_btn.Click += new System.EventHandler(this.Log_in_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 3);
            this.panel2.Controls.Add(this.LOGO);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2561, 533);
            this.panel2.TabIndex = 1;
            // 
            // LOGO
            // 
            this.LOGO.BackgroundImage = global::GrabAViscan.Properties.Resources.GrabAViscan;
            this.LOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LOGO.Location = new System.Drawing.Point(853, 222);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(846, 100);
            this.LOGO.TabIndex = 0;
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2560, 1600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Intro";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel LOGO;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton Log_in_btn;
        private Guna.UI.WinForms.GunaButton signUp_btn;
    }
}

