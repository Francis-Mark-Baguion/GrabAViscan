namespace GrabAViscan.Popup
{
    partial class Notifications
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
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.gunaPanel1);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 5;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(563, 1504);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(568, 106);
            this.gunaPanel1.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(37, 31);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(201, 45);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Notifications";
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaElipsePanel1);
            this.Location = new System.Drawing.Point(1300, 142);
            this.Name = "Notifications";
            this.Size = new System.Drawing.Size(563, 1504);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
