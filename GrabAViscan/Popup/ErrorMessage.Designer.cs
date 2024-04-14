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
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.Message = new System.Windows.Forms.RichTextBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.Firebrick;
            this.gunaPanel2.Controls.Add(this.gunaPanel1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel2.Location = new System.Drawing.Point(560, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(13, 98);
            this.gunaPanel2.TabIndex = 2;
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.Color.White;
            this.Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Message.Enabled = false;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.Color.Black;
            this.Message.Location = new System.Drawing.Point(0, 0);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(560, 98);
            this.Message.TabIndex = 3;
            this.Message.Text = "";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Firebrick;
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 88);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(13, 10);
            this.gunaPanel1.TabIndex = 3;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Firebrick;
            this.gunaPanel3.Controls.Add(this.gunaPanel4);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(560, 10);
            this.gunaPanel3.TabIndex = 4;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.Firebrick;
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel4.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(560, 10);
            this.gunaPanel4.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 10);
            this.panel1.TabIndex = 5;
            // 
            // ErrorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 98);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.gunaPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 1000);
            this.Name = "ErrorMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ErrorMessage";
            this.Load += new System.EventHandler(this.ErrorMessage_Load);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private System.Windows.Forms.RichTextBox Message;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private System.Windows.Forms.Panel panel1;
    }
}