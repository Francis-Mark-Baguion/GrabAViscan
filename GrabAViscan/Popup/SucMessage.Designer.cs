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
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.Enabled = false;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.Color.Black;
            this.Message.Location = new System.Drawing.Point(-5, 0);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(573, 87);
            this.Message.TabIndex = 5;
            this.Message.Text = "";
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
            // SucMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 98);
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
    }
}