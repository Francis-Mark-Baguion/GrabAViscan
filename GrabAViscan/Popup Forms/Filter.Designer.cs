namespace GrabAViscan.Popup_Forms
{
    partial class Filter
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
            this.place = new Guna.UI.WinForms.GunaComboBox();
            this.category = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // place
            // 
            this.place.BackColor = System.Drawing.Color.Transparent;
            this.place.BaseColor = System.Drawing.Color.White;
            this.place.BorderColor = System.Drawing.Color.Silver;
            this.place.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.place.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.place.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.place.ForeColor = System.Drawing.Color.Black;
            this.place.FormattingEnabled = true;
            this.place.Location = new System.Drawing.Point(12, 56);
            this.place.Name = "place";
            this.place.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.place.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.place.Size = new System.Drawing.Size(182, 35);
            this.place.TabIndex = 0;
            this.place.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.Transparent;
            this.category.BaseColor = System.Drawing.Color.White;
            this.category.BorderColor = System.Drawing.Color.Silver;
            this.category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.category.ForeColor = System.Drawing.Color.Black;
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(215, 56);
            this.category.Name = "category";
            this.category.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.category.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.category.Size = new System.Drawing.Size(182, 35);
            this.category.TabIndex = 1;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(7, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(52, 25);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Place";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(210, 18);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(84, 25);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Category";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 103);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.place);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 142);
            this.Name = "Filter";
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.Filter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox place;
        private Guna.UI.WinForms.GunaComboBox category;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}