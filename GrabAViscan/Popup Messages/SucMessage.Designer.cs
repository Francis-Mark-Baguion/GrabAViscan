namespace GrabAViscan.Popup
{
    partial class SucMessage
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
            this.Message = new System.Windows.Forms.RichTextBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.SuspendLayout();
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
            this.Message.Size = new System.Drawing.Size(563, 88);
            this.Message.TabIndex = 5;
            this.Message.Text = "";
            this.Message.TextChanged += new System.EventHandler(this.Message_TextChanged);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 88);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(563, 10);
            this.gunaPanel2.TabIndex = 4;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(563, 10);
            this.gunaPanel1.TabIndex = 6;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel3.Location = new System.Drawing.Point(550, 10);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(13, 78);
            this.gunaPanel3.TabIndex = 7;
            // 
            // SucMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 98);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.gunaPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 1000);
            this.Name = "SucMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SucMessage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Message;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
    }
}