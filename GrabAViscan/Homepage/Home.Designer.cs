namespace GrabAViscan
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.filterBox = new Guna.UI.WinForms.GunaTextBox();
            this.Minimize_btn = new Guna.UI.WinForms.GunaButton();
            this.Close_btn = new Guna.UI.WinForms.GunaButton();
            this.Filter_btn = new Guna.UI.WinForms.GunaButton();
            this.LeftWing = new System.Windows.Forms.Panel();
            this.logOut_btn = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.deliverCtr = new Guna.UI.WinForms.GunaButton();
            this.reqCtr = new Guna.UI.WinForms.GunaButton();
            this.settings_btn = new Guna.UI.WinForms.GunaButton();
            this.history_btn = new Guna.UI.WinForms.GunaButton();
            this.toDeliver_btn = new Guna.UI.WinForms.GunaButton();
            this.myRequest_btn = new Guna.UI.WinForms.GunaButton();
            this.home_btn = new Guna.UI.WinForms.GunaButton();
            this.flow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RightWing = new Guna.UI.WinForms.GunaPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.LeftWing.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LeftWing, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flow1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RightWing, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.012366F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.98763F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2560, 1600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Controls.Add(this.filterBox);
            this.panel1.Controls.Add(this.Minimize_btn);
            this.panel1.Controls.Add(this.Close_btn);
            this.panel1.Controls.Add(this.Filter_btn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2560, 96);
            this.panel1.TabIndex = 0;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(259, 96);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 17;
            this.gunaPictureBox1.TabStop = false;
            // 
            // filterBox
            // 
            this.filterBox.BaseColor = System.Drawing.Color.White;
            this.filterBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.filterBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filterBox.FocusedBaseColor = System.Drawing.Color.White;
            this.filterBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.filterBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.filterBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBox.Location = new System.Drawing.Point(351, 20);
            this.filterBox.Name = "filterBox";
            this.filterBox.PasswordChar = '\0';
            this.filterBox.Radius = 15;
            this.filterBox.Size = new System.Drawing.Size(420, 60);
            this.filterBox.TabIndex = 16;
            this.filterBox.Click += new System.EventHandler(this.gunaTextBox1_Click);
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.AnimationHoverSpeed = 0.07F;
            this.Minimize_btn.AnimationSpeed = 0.03F;
            this.Minimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimize_btn.BaseColor = System.Drawing.Color.Transparent;
            this.Minimize_btn.BorderColor = System.Drawing.Color.Black;
            this.Minimize_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Minimize_btn.ForeColor = System.Drawing.Color.White;
            this.Minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("Minimize_btn.Image")));
            this.Minimize_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Minimize_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.Minimize_btn.Location = new System.Drawing.Point(2420, 12);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.Minimize_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Minimize_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Minimize_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("Minimize_btn.OnHoverImage")));
            this.Minimize_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Minimize_btn.Size = new System.Drawing.Size(50, 50);
            this.Minimize_btn.TabIndex = 14;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.AnimationHoverSpeed = 0.07F;
            this.Close_btn.AnimationSpeed = 0.03F;
            this.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close_btn.BaseColor = System.Drawing.Color.Transparent;
            this.Close_btn.BorderColor = System.Drawing.Color.Black;
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Image = ((System.Drawing.Image)(resources.GetObject("Close_btn.Image")));
            this.Close_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Close_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.Close_btn.Location = new System.Drawing.Point(2494, 12);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.Close_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Close_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Close_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("Close_btn.OnHoverImage")));
            this.Close_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Close_btn.Size = new System.Drawing.Size(50, 50);
            this.Close_btn.TabIndex = 13;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Filter_btn
            // 
            this.Filter_btn.AnimationHoverSpeed = 0.07F;
            this.Filter_btn.AnimationSpeed = 0.03F;
            this.Filter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Filter_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.Filter_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.Filter_btn.BorderSize = 3;
            this.Filter_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_btn.ForeColor = System.Drawing.Color.White;
            this.Filter_btn.Image = ((System.Drawing.Image)(resources.GetObject("Filter_btn.Image")));
            this.Filter_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.Filter_btn.Location = new System.Drawing.Point(775, 20);
            this.Filter_btn.Name = "Filter_btn";
            this.Filter_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.Filter_btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.Filter_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Filter_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("Filter_btn.OnHoverImage")));
            this.Filter_btn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.Filter_btn.Radius = 10;
            this.Filter_btn.Size = new System.Drawing.Size(160, 59);
            this.Filter_btn.TabIndex = 12;
            this.Filter_btn.Text = "Filter";
            this.Filter_btn.Click += new System.EventHandler(this.Filter_btn_Click);
            // 
            // LeftWing
            // 
            this.LeftWing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.LeftWing.Controls.Add(this.logOut_btn);
            this.LeftWing.Controls.Add(this.gunaPanel1);
            this.LeftWing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftWing.Location = new System.Drawing.Point(0, 96);
            this.LeftWing.Margin = new System.Windows.Forms.Padding(0);
            this.LeftWing.Name = "LeftWing";
            this.LeftWing.Size = new System.Drawing.Size(563, 1504);
            this.LeftWing.TabIndex = 1;
            this.LeftWing.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftWing_Paint);
            // 
            // logOut_btn
            // 
            this.logOut_btn.AnimationHoverSpeed = 0.07F;
            this.logOut_btn.AnimationSpeed = 0.03F;
            this.logOut_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.logOut_btn.BorderColor = System.Drawing.Color.Black;
            this.logOut_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_btn.ForeColor = System.Drawing.Color.Black;
            this.logOut_btn.Image = ((System.Drawing.Image)(resources.GetObject("logOut_btn.Image")));
            this.logOut_btn.ImageOffsetX = 20;
            this.logOut_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.logOut_btn.Location = new System.Drawing.Point(12, 1353);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.logOut_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logOut_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.logOut_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("logOut_btn.OnHoverImage")));
            this.logOut_btn.OnPressedColor = System.Drawing.Color.Black;
            this.logOut_btn.Radius = 15;
            this.logOut_btn.Size = new System.Drawing.Size(524, 70);
            this.logOut_btn.TabIndex = 6;
            this.logOut_btn.Text = "Log out";
            this.logOut_btn.TextOffsetX = 30;
            this.logOut_btn.Click += new System.EventHandler(this.logOut_click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.deliverCtr);
            this.gunaPanel1.Controls.Add(this.reqCtr);
            this.gunaPanel1.Controls.Add(this.settings_btn);
            this.gunaPanel1.Controls.Add(this.history_btn);
            this.gunaPanel1.Controls.Add(this.toDeliver_btn);
            this.gunaPanel1.Controls.Add(this.myRequest_btn);
            this.gunaPanel1.Controls.Add(this.home_btn);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(563, 487);
            this.gunaPanel1.TabIndex = 2;
            // 
            // deliverCtr
            // 
            this.deliverCtr.AnimationHoverSpeed = 0.07F;
            this.deliverCtr.AnimationSpeed = 0.03F;
            this.deliverCtr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.deliverCtr.BaseColor = System.Drawing.Color.Transparent;
            this.deliverCtr.BorderColor = System.Drawing.Color.Black;
            this.deliverCtr.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliverCtr.ForeColor = System.Drawing.Color.Firebrick;
            this.deliverCtr.Image = null;
            this.deliverCtr.ImageSize = new System.Drawing.Size(20, 20);
            this.deliverCtr.Location = new System.Drawing.Point(436, 264);
            this.deliverCtr.Name = "deliverCtr";
            this.deliverCtr.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.deliverCtr.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deliverCtr.OnHoverForeColor = System.Drawing.Color.Firebrick;
            this.deliverCtr.OnHoverImage = null;
            this.deliverCtr.OnPressedColor = System.Drawing.Color.Black;
            this.deliverCtr.Radius = 10;
            this.deliverCtr.Size = new System.Drawing.Size(67, 30);
            this.deliverCtr.TabIndex = 9;
            this.deliverCtr.Text = "0";
            this.deliverCtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deliverCtr.Click += new System.EventHandler(this.deliverCtr_Click);
            // 
            // reqCtr
            // 
            this.reqCtr.AnimationHoverSpeed = 0.07F;
            this.reqCtr.AnimationSpeed = 0.03F;
            this.reqCtr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.reqCtr.BaseColor = System.Drawing.Color.Transparent;
            this.reqCtr.BorderColor = System.Drawing.Color.Black;
            this.reqCtr.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqCtr.ForeColor = System.Drawing.Color.Firebrick;
            this.reqCtr.Image = null;
            this.reqCtr.ImageSize = new System.Drawing.Size(20, 20);
            this.reqCtr.Location = new System.Drawing.Point(436, 173);
            this.reqCtr.Name = "reqCtr";
            this.reqCtr.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.reqCtr.OnHoverBorderColor = System.Drawing.Color.Black;
            this.reqCtr.OnHoverForeColor = System.Drawing.Color.Firebrick;
            this.reqCtr.OnHoverImage = null;
            this.reqCtr.OnPressedColor = System.Drawing.Color.Black;
            this.reqCtr.Radius = 10;
            this.reqCtr.Size = new System.Drawing.Size(67, 30);
            this.reqCtr.TabIndex = 8;
            this.reqCtr.Text = "0";
            this.reqCtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reqCtr.Click += new System.EventHandler(this.reqCtr_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.AnimationHoverSpeed = 0.07F;
            this.settings_btn.AnimationSpeed = 0.03F;
            this.settings_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.settings_btn.BorderColor = System.Drawing.Color.Black;
            this.settings_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_btn.ForeColor = System.Drawing.Color.Black;
            this.settings_btn.Image = ((System.Drawing.Image)(resources.GetObject("settings_btn.Image")));
            this.settings_btn.ImageOffsetX = 20;
            this.settings_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.settings_btn.Location = new System.Drawing.Point(0, 404);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.settings_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.settings_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.settings_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("settings_btn.OnHoverImage")));
            this.settings_btn.OnPressedColor = System.Drawing.Color.Black;
            this.settings_btn.Radius = 15;
            this.settings_btn.Size = new System.Drawing.Size(524, 70);
            this.settings_btn.TabIndex = 5;
            this.settings_btn.Text = "Settings";
            this.settings_btn.TextOffsetX = 30;
            this.settings_btn.Click += new System.EventHandler(this.settings_click);
            // 
            // history_btn
            // 
            this.history_btn.AnimationHoverSpeed = 0.07F;
            this.history_btn.AnimationSpeed = 0.03F;
            this.history_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.history_btn.BorderColor = System.Drawing.Color.Black;
            this.history_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_btn.ForeColor = System.Drawing.Color.Black;
            this.history_btn.Image = ((System.Drawing.Image)(resources.GetObject("history_btn.Image")));
            this.history_btn.ImageOffsetX = 20;
            this.history_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.history_btn.Location = new System.Drawing.Point(0, 328);
            this.history_btn.Name = "history_btn";
            this.history_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.history_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.history_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.history_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("history_btn.OnHoverImage")));
            this.history_btn.OnPressedColor = System.Drawing.Color.Black;
            this.history_btn.Radius = 15;
            this.history_btn.Size = new System.Drawing.Size(524, 70);
            this.history_btn.TabIndex = 4;
            this.history_btn.Text = "History";
            this.history_btn.TextOffsetX = 30;
            this.history_btn.Click += new System.EventHandler(this.History_click);
            // 
            // toDeliver_btn
            // 
            this.toDeliver_btn.AnimationHoverSpeed = 0.07F;
            this.toDeliver_btn.AnimationSpeed = 0.03F;
            this.toDeliver_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.toDeliver_btn.BorderColor = System.Drawing.Color.Black;
            this.toDeliver_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDeliver_btn.ForeColor = System.Drawing.Color.Black;
            this.toDeliver_btn.Image = ((System.Drawing.Image)(resources.GetObject("toDeliver_btn.Image")));
            this.toDeliver_btn.ImageOffsetX = 20;
            this.toDeliver_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.toDeliver_btn.Location = new System.Drawing.Point(0, 243);
            this.toDeliver_btn.Name = "toDeliver_btn";
            this.toDeliver_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.toDeliver_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.toDeliver_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.toDeliver_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("toDeliver_btn.OnHoverImage")));
            this.toDeliver_btn.OnPressedColor = System.Drawing.Color.Black;
            this.toDeliver_btn.Radius = 15;
            this.toDeliver_btn.Size = new System.Drawing.Size(524, 70);
            this.toDeliver_btn.TabIndex = 3;
            this.toDeliver_btn.Text = "To Deliver";
            this.toDeliver_btn.TextOffsetX = 30;
            this.toDeliver_btn.Click += new System.EventHandler(this.To_deliver_click);
            this.toDeliver_btn.MouseLeave += new System.EventHandler(this.gunaButton4_MouseLeave);
            this.toDeliver_btn.MouseHover += new System.EventHandler(this.gunaButton4_MouseHover);
            // 
            // myRequest_btn
            // 
            this.myRequest_btn.AnimationHoverSpeed = 0.07F;
            this.myRequest_btn.AnimationSpeed = 0.03F;
            this.myRequest_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.myRequest_btn.BorderColor = System.Drawing.Color.Black;
            this.myRequest_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myRequest_btn.ForeColor = System.Drawing.Color.Black;
            this.myRequest_btn.Image = ((System.Drawing.Image)(resources.GetObject("myRequest_btn.Image")));
            this.myRequest_btn.ImageOffsetX = 20;
            this.myRequest_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.myRequest_btn.Location = new System.Drawing.Point(0, 157);
            this.myRequest_btn.Name = "myRequest_btn";
            this.myRequest_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.myRequest_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.myRequest_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.myRequest_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("myRequest_btn.OnHoverImage")));
            this.myRequest_btn.OnPressedColor = System.Drawing.Color.Black;
            this.myRequest_btn.Radius = 15;
            this.myRequest_btn.Size = new System.Drawing.Size(524, 70);
            this.myRequest_btn.TabIndex = 2;
            this.myRequest_btn.Text = "My Request";
            this.myRequest_btn.TextOffsetX = 30;
            this.myRequest_btn.Click += new System.EventHandler(this.My_Request_click);
            this.myRequest_btn.MouseLeave += new System.EventHandler(this.mouseleave);
            this.myRequest_btn.MouseHover += new System.EventHandler(this.hover);
            // 
            // home_btn
            // 
            this.home_btn.AnimationHoverSpeed = 0.07F;
            this.home_btn.AnimationSpeed = 0.03F;
            this.home_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.home_btn.BorderColor = System.Drawing.Color.Black;
            this.home_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.Color.Black;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.ImageOffsetX = 20;
            this.home_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.home_btn.Location = new System.Drawing.Point(0, 71);
            this.home_btn.Name = "home_btn";
            this.home_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.home_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.home_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.home_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("home_btn.OnHoverImage")));
            this.home_btn.OnPressedColor = System.Drawing.Color.Black;
            this.home_btn.Radius = 15;
            this.home_btn.Size = new System.Drawing.Size(524, 70);
            this.home_btn.TabIndex = 1;
            this.home_btn.Text = "Home";
            this.home_btn.TextOffsetX = 30;
            this.home_btn.Click += new System.EventHandler(this.homeclick);
            // 
            // flow1
            // 
            this.flow1.AutoScroll = true;
            this.flow1.AutoSize = true;
            this.flow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.flow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow1.Location = new System.Drawing.Point(566, 99);
            this.flow1.Name = "flow1";
            this.flow1.Size = new System.Drawing.Size(1350, 1498);
            this.flow1.TabIndex = 2;
            this.flow1.Paint += new System.Windows.Forms.PaintEventHandler(this.flow1_Paint);
            // 
            // RightWing
            // 
            this.RightWing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.RightWing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightWing.Location = new System.Drawing.Point(1922, 99);
            this.RightWing.Name = "RightWing";
            this.RightWing.Size = new System.Drawing.Size(635, 1498);
            this.RightWing.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2560, 1600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.LeftWing.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI.WinForms.GunaButton Filter_btn;
        private System.Windows.Forms.FlowLayoutPanel flow1;
        private Guna.UI.WinForms.GunaPanel RightWing;
        private System.Windows.Forms.Panel LeftWing;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton home_btn;
        private Guna.UI.WinForms.GunaButton Close_btn;
        private Guna.UI.WinForms.GunaButton Minimize_btn;
        private Guna.UI.WinForms.GunaButton history_btn;
        private Guna.UI.WinForms.GunaButton toDeliver_btn;
        private Guna.UI.WinForms.GunaButton myRequest_btn;
        private Guna.UI.WinForms.GunaButton settings_btn;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton logOut_btn;
        public Guna.UI.WinForms.GunaTextBox filterBox;
        private Guna.UI.WinForms.GunaButton deliverCtr;
        private Guna.UI.WinForms.GunaButton reqCtr;
    }
}