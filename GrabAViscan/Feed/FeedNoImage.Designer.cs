namespace GrabAViscan.Feed
{
    partial class FeedNoImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedNoImage));
            this.MainPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.category = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.deadline = new Guna.UI.WinForms.GunaButton();
            this.quantityTxt = new Guna.UI.WinForms.GunaButton();
            this.requestTxt = new Guna.UI.WinForms.GunaButton();
            this.Quantity_label = new Guna.UI.WinForms.GunaLabel();
            this.Request_label = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton9 = new Guna.UI.WinForms.GunaButton();
            this.Fee = new Guna.UI.WinForms.GunaButton();
            this.deliveryTxt = new Guna.UI.WinForms.GunaButton();
            this.pickUpTxt = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.descriptionTxt = new System.Windows.Forms.RichTextBox();
            this.Category_label = new Guna.UI.WinForms.GunaLabel();
            this.profile = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.Name_label = new Guna.UI.WinForms.GunaButton();
            this.TimeTxt = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.MainPanel.BaseColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.category);
            this.MainPanel.Controls.Add(this.gunaLabel1);
            this.MainPanel.Controls.Add(this.deadline);
            this.MainPanel.Controls.Add(this.quantityTxt);
            this.MainPanel.Controls.Add(this.requestTxt);
            this.MainPanel.Controls.Add(this.Quantity_label);
            this.MainPanel.Controls.Add(this.Request_label);
            this.MainPanel.Controls.Add(this.gunaButton9);
            this.MainPanel.Controls.Add(this.Fee);
            this.MainPanel.Controls.Add(this.deliveryTxt);
            this.MainPanel.Controls.Add(this.pickUpTxt);
            this.MainPanel.Controls.Add(this.gunaLabel4);
            this.MainPanel.Controls.Add(this.descriptionTxt);
            this.MainPanel.Controls.Add(this.Category_label);
            this.MainPanel.Controls.Add(this.profile);
            this.MainPanel.Controls.Add(this.Name_label);
            this.MainPanel.Controls.Add(this.TimeTxt);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Radius = 30;
            this.MainPanel.Size = new System.Drawing.Size(1315, 800);
            this.MainPanel.TabIndex = 5;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.Transparent;
            this.category.BaseColor = System.Drawing.Color.Transparent;
            this.category.Location = new System.Drawing.Point(805, 441);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(50, 50);
            this.category.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.category.TabIndex = 49;
            this.category.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaLabel1.Location = new System.Drawing.Point(51, 540);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(98, 30);
            this.gunaLabel1.TabIndex = 48;
            this.gunaLabel1.Text = "PICK UP";
            // 
            // deadline
            // 
            this.deadline.AnimationHoverSpeed = 0.07F;
            this.deadline.AnimationSpeed = 0.03F;
            this.deadline.BaseColor = System.Drawing.Color.White;
            this.deadline.BorderColor = System.Drawing.Color.Black;
            this.deadline.Enabled = false;
            this.deadline.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadline.ForeColor = System.Drawing.Color.Black;
            this.deadline.Image = ((System.Drawing.Image)(resources.GetObject("deadline.Image")));
            this.deadline.ImageSize = new System.Drawing.Size(20, 20);
            this.deadline.Location = new System.Drawing.Point(801, 522);
            this.deadline.Name = "deadline";
            this.deadline.OnHoverBaseColor = System.Drawing.Color.White;
            this.deadline.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.deadline.OnHoverForeColor = System.Drawing.Color.White;
            this.deadline.OnHoverImage = null;
            this.deadline.OnPressedColor = System.Drawing.Color.Black;
            this.deadline.Size = new System.Drawing.Size(448, 48);
            this.deadline.TabIndex = 46;
            this.deadline.Text = "Deadline";
            this.deadline.Click += new System.EventHandler(this.deadline_Click);
            // 
            // quantityTxt
            // 
            this.quantityTxt.AnimationHoverSpeed = 0.07F;
            this.quantityTxt.AnimationSpeed = 0.03F;
            this.quantityTxt.BaseColor = System.Drawing.Color.White;
            this.quantityTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.quantityTxt.Enabled = false;
            this.quantityTxt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxt.ForeColor = System.Drawing.Color.Black;
            this.quantityTxt.Image = null;
            this.quantityTxt.ImageSize = new System.Drawing.Size(20, 20);
            this.quantityTxt.Location = new System.Drawing.Point(214, 462);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.OnHoverBaseColor = System.Drawing.Color.White;
            this.quantityTxt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.quantityTxt.OnHoverForeColor = System.Drawing.Color.Black;
            this.quantityTxt.OnHoverImage = null;
            this.quantityTxt.OnPressedColor = System.Drawing.Color.Black;
            this.quantityTxt.Size = new System.Drawing.Size(160, 62);
            this.quantityTxt.TabIndex = 45;
            this.quantityTxt.Text = "000";
            // 
            // requestTxt
            // 
            this.requestTxt.AnimationHoverSpeed = 0.07F;
            this.requestTxt.AnimationSpeed = 0.03F;
            this.requestTxt.BaseColor = System.Drawing.Color.White;
            this.requestTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.requestTxt.Enabled = false;
            this.requestTxt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestTxt.ForeColor = System.Drawing.Color.Black;
            this.requestTxt.Image = null;
            this.requestTxt.ImageSize = new System.Drawing.Size(20, 20);
            this.requestTxt.Location = new System.Drawing.Point(214, 394);
            this.requestTxt.Name = "requestTxt";
            this.requestTxt.OnHoverBaseColor = System.Drawing.Color.White;
            this.requestTxt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.requestTxt.OnHoverForeColor = System.Drawing.Color.Black;
            this.requestTxt.OnHoverImage = null;
            this.requestTxt.OnPressedColor = System.Drawing.Color.Black;
            this.requestTxt.Size = new System.Drawing.Size(553, 62);
            this.requestTxt.TabIndex = 44;
            this.requestTxt.Text = "Item";
            // 
            // Quantity_label
            // 
            this.Quantity_label.AutoSize = true;
            this.Quantity_label.BackColor = System.Drawing.Color.White;
            this.Quantity_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.Quantity_label.Location = new System.Drawing.Point(51, 476);
            this.Quantity_label.Name = "Quantity_label";
            this.Quantity_label.Size = new System.Drawing.Size(124, 30);
            this.Quantity_label.TabIndex = 43;
            this.Quantity_label.Text = "QUANTITY";
            // 
            // Request_label
            // 
            this.Request_label.AutoSize = true;
            this.Request_label.BackColor = System.Drawing.Color.White;
            this.Request_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Request_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.Request_label.Location = new System.Drawing.Point(51, 412);
            this.Request_label.Name = "Request_label";
            this.Request_label.Size = new System.Drawing.Size(109, 30);
            this.Request_label.TabIndex = 42;
            this.Request_label.Text = "REQUEST";
            // 
            // gunaButton9
            // 
            this.gunaButton9.AnimationHoverSpeed = 0.07F;
            this.gunaButton9.AnimationSpeed = 0.03F;
            this.gunaButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaButton9.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaButton9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaButton9.BorderSize = 3;
            this.gunaButton9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton9.ForeColor = System.Drawing.Color.White;
            this.gunaButton9.Image = null;
            this.gunaButton9.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton9.Location = new System.Drawing.Point(887, 661);
            this.gunaButton9.Name = "gunaButton9";
            this.gunaButton9.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaButton9.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton9.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton9.OnHoverImage = null;
            this.gunaButton9.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaButton9.Radius = 10;
            this.gunaButton9.Size = new System.Drawing.Size(366, 78);
            this.gunaButton9.TabIndex = 41;
            this.gunaButton9.Text = "PICK UP ORDER";
            this.gunaButton9.Click += new System.EventHandler(this.gunaButton9_Click);
            // 
            // Fee
            // 
            this.Fee.AnimationHoverSpeed = 0.07F;
            this.Fee.AnimationSpeed = 0.03F;
            this.Fee.BaseColor = System.Drawing.Color.White;
            this.Fee.BorderColor = System.Drawing.Color.Black;
            this.Fee.Enabled = false;
            this.Fee.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fee.ForeColor = System.Drawing.Color.Black;
            this.Fee.Image = ((System.Drawing.Image)(resources.GetObject("Fee.Image")));
            this.Fee.ImageSize = new System.Drawing.Size(20, 20);
            this.Fee.Location = new System.Drawing.Point(805, 590);
            this.Fee.Name = "Fee";
            this.Fee.OnHoverBaseColor = System.Drawing.Color.White;
            this.Fee.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Fee.OnHoverForeColor = System.Drawing.Color.White;
            this.Fee.OnHoverImage = null;
            this.Fee.OnPressedColor = System.Drawing.Color.Black;
            this.Fee.Size = new System.Drawing.Size(247, 48);
            this.Fee.TabIndex = 39;
            this.Fee.Text = "50";
            // 
            // deliveryTxt
            // 
            this.deliveryTxt.AnimationHoverSpeed = 0.07F;
            this.deliveryTxt.AnimationSpeed = 0.03F;
            this.deliveryTxt.BaseColor = System.Drawing.Color.White;
            this.deliveryTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.deliveryTxt.Enabled = false;
            this.deliveryTxt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryTxt.ForeColor = System.Drawing.Color.Black;
            this.deliveryTxt.Image = null;
            this.deliveryTxt.ImageSize = new System.Drawing.Size(20, 20);
            this.deliveryTxt.Location = new System.Drawing.Point(214, 597);
            this.deliveryTxt.Name = "deliveryTxt";
            this.deliveryTxt.OnHoverBaseColor = System.Drawing.Color.White;
            this.deliveryTxt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deliveryTxt.OnHoverForeColor = System.Drawing.Color.Black;
            this.deliveryTxt.OnHoverImage = null;
            this.deliveryTxt.OnPressedColor = System.Drawing.Color.Black;
            this.deliveryTxt.Size = new System.Drawing.Size(500, 62);
            this.deliveryTxt.TabIndex = 37;
            this.deliveryTxt.Text = "Location2";
            // 
            // pickUpTxt
            // 
            this.pickUpTxt.AnimationHoverSpeed = 0.07F;
            this.pickUpTxt.AnimationSpeed = 0.03F;
            this.pickUpTxt.BaseColor = System.Drawing.Color.White;
            this.pickUpTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.pickUpTxt.Enabled = false;
            this.pickUpTxt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickUpTxt.ForeColor = System.Drawing.Color.Black;
            this.pickUpTxt.Image = null;
            this.pickUpTxt.ImageSize = new System.Drawing.Size(20, 20);
            this.pickUpTxt.Location = new System.Drawing.Point(214, 526);
            this.pickUpTxt.Name = "pickUpTxt";
            this.pickUpTxt.OnHoverBaseColor = System.Drawing.Color.White;
            this.pickUpTxt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.pickUpTxt.OnHoverForeColor = System.Drawing.Color.Black;
            this.pickUpTxt.OnHoverImage = null;
            this.pickUpTxt.OnPressedColor = System.Drawing.Color.Black;
            this.pickUpTxt.Size = new System.Drawing.Size(581, 62);
            this.pickUpTxt.TabIndex = 35;
            this.pickUpTxt.Text = "Location1";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.White;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.gunaLabel4.Location = new System.Drawing.Point(51, 612);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(157, 30);
            this.gunaLabel4.TabIndex = 33;
            this.gunaLabel4.Text = "DESTINATION";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTxt.Location = new System.Drawing.Point(33, 227);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(1216, 107);
            this.descriptionTxt.TabIndex = 30;
            this.descriptionTxt.Text = resources.GetString("descriptionTxt.Text");
            // 
            // Category_label
            // 
            this.Category_label.AutoSize = true;
            this.Category_label.BackColor = System.Drawing.Color.White;
            this.Category_label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_label.Location = new System.Drawing.Point(861, 447);
            this.Category_label.Name = "Category_label";
            this.Category_label.Size = new System.Drawing.Size(128, 38);
            this.Category_label.TabIndex = 20;
            this.Category_label.Text = "Category";
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.White;
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profile.BaseColor = System.Drawing.Color.White;
            this.profile.Image = ((System.Drawing.Image)(resources.GetObject("profile.Image")));
            this.profile.InitialImage = ((System.Drawing.Image)(resources.GetObject("profile.InitialImage")));
            this.profile.Location = new System.Drawing.Point(41, 64);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(100, 100);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile.TabIndex = 0;
            this.profile.TabStop = false;
            this.profile.UseTransfarantBackground = false;
            this.profile.Click += new System.EventHandler(this.viewProfile);
            // 
            // Name_label
            // 
            this.Name_label.AnimationHoverSpeed = 0.07F;
            this.Name_label.AnimationSpeed = 0.03F;
            this.Name_label.BackColor = System.Drawing.Color.Wheat;
            this.Name_label.BaseColor = System.Drawing.Color.White;
            this.Name_label.BorderColor = System.Drawing.Color.Black;
            this.Name_label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.ForeColor = System.Drawing.Color.Black;
            this.Name_label.Image = null;
            this.Name_label.ImageSize = new System.Drawing.Size(20, 20);
            this.Name_label.Location = new System.Drawing.Point(147, 81);
            this.Name_label.Name = "Name_label";
            this.Name_label.OnHoverBaseColor = System.Drawing.Color.White;
            this.Name_label.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Name_label.OnHoverForeColor = System.Drawing.Color.Black;
            this.Name_label.OnHoverImage = null;
            this.Name_label.OnPressedColor = System.Drawing.Color.Black;
            this.Name_label.Size = new System.Drawing.Size(322, 42);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "First Name Last Name";
            this.Name_label.Click += new System.EventHandler(this.viewProfile);
            // 
            // TimeTxt
            // 
            this.TimeTxt.AutoSize = true;
            this.TimeTxt.BackColor = System.Drawing.Color.White;
            this.TimeTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTxt.ForeColor = System.Drawing.Color.Black;
            this.TimeTxt.Location = new System.Drawing.Point(160, 126);
            this.TimeTxt.Name = "TimeTxt";
            this.TimeTxt.Size = new System.Drawing.Size(123, 32);
            this.TimeTxt.TabIndex = 2;
            this.TimeTxt.Text = "03/2/2004";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1195, 34);
            this.label1.TabIndex = 47;
            this.label1.Text = "___________________________________________________________";
            // 
            // FeedNoImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Name = "FeedNoImage";
            this.Size = new System.Drawing.Size(1315, 800);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel MainPanel;
        private Guna.UI.WinForms.GunaLabel Quantity_label;
        private Guna.UI.WinForms.GunaLabel Request_label;
        private Guna.UI.WinForms.GunaLabel Category_label;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaButton gunaButton9;
        private System.Windows.Forms.RichTextBox descriptionTxt;
        private Guna.UI.WinForms.GunaCirclePictureBox profile;
        private Guna.UI.WinForms.GunaButton Name_label;
        private Guna.UI.WinForms.GunaLabel TimeTxt;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton quantityTxt;
        private Guna.UI.WinForms.GunaButton deadline;
        private Guna.UI.WinForms.GunaButton Fee;
        private Guna.UI.WinForms.GunaButton deliveryTxt;
        private Guna.UI.WinForms.GunaButton pickUpTxt;
        private Guna.UI.WinForms.GunaButton requestTxt;
        private Guna.UI.WinForms.GunaPictureBox category;
    }
}
