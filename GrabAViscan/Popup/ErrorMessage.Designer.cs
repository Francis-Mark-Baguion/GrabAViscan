namespace GrabAViscan.Popup
{
    partial class ErrorMessage
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
            this.Message = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(12, 27);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(61, 30);
            this.Message.TabIndex = 0;
            this.Message.Text = "Error";
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 88);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(573, 10);
            this.gunaPanel2.TabIndex = 2;
            // 
            // ErrorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 98);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.Message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 1000);
            this.Name = "ErrorMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ErrorMessage";
            this.Load += new System.EventHandler(this.ErrorMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel Message;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
    }
}