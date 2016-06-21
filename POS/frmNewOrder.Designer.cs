namespace POS
{
    partial class frmNewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewOrder));
            this.lblTitle = new System.Windows.Forms.Label();
            this.Tab = new System.Windows.Forms.TabControl();
            this.OrderType = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.btnDriveThru = new System.Windows.Forms.Button();
            this.brnDineIn = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnWebOrder = new System.Windows.Forms.Button();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tables = new System.Windows.Forms.TabPage();
            this.btnCatSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nudCatSortDisplay = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cart = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.Tab.SuspendLayout();
            this.OrderType.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Tables.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCatSortDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Cart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AccessibleName = "0";
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(82, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(116, 28);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Order Menu";
            // 
            // Tab
            // 
            this.Tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tab.Controls.Add(this.OrderType);
            this.Tab.Controls.Add(this.Tables);
            this.Tab.Controls.Add(this.Cart);
            this.Tab.Controls.Add(this.Payment);
            this.Tab.Location = new System.Drawing.Point(0, 63);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1024, 705);
            this.Tab.TabIndex = 10;
            // 
            // OrderType
            // 
            this.OrderType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.OrderType.Controls.Add(this.flowLayoutPanel1);
            this.OrderType.Controls.Add(this.label2);
            this.OrderType.Location = new System.Drawing.Point(4, 22);
            this.OrderType.Name = "OrderType";
            this.OrderType.Padding = new System.Windows.Forms.Padding(3);
            this.OrderType.Size = new System.Drawing.Size(1016, 679);
            this.OrderType.TabIndex = 0;
            this.OrderType.Text = "Select Order Type";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDelivery);
            this.flowLayoutPanel1.Controls.Add(this.btnBar);
            this.flowLayoutPanel1.Controls.Add(this.btnDriveThru);
            this.flowLayoutPanel1.Controls.Add(this.brnDineIn);
            this.flowLayoutPanel1.Controls.Add(this.btnReservation);
            this.flowLayoutPanel1.Controls.Add(this.btnWebOrder);
            this.flowLayoutPanel1.Controls.Add(this.btnTakeAway);
            this.flowLayoutPanel1.Controls.Add(this.btnOther);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 113);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(980, 448);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnDelivery
            // 
            this.btnDelivery.AccessibleDescription = "Delivery";
            this.btnDelivery.AccessibleName = "3";
            this.btnDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.btnDelivery.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelivery.Location = new System.Drawing.Point(3, 3);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(239, 218);
            this.btnDelivery.TabIndex = 10;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnOrderType);
            // 
            // btnBar
            // 
            this.btnBar.AccessibleDescription = "Bar";
            this.btnBar.AccessibleName = "1";
            this.btnBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btnBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBar.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.btnBar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBar.Location = new System.Drawing.Point(248, 3);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(239, 218);
            this.btnBar.TabIndex = 12;
            this.btnBar.Text = "Bar";
            this.btnBar.UseVisualStyleBackColor = false;
            this.btnBar.Click += new System.EventHandler(this.btnOrderType);
            // 
            // btnDriveThru
            // 
            this.btnDriveThru.AccessibleDescription = "Drive-Thru";
            this.btnDriveThru.AccessibleName = "1";
            this.btnDriveThru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btnDriveThru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriveThru.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.btnDriveThru.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDriveThru.Location = new System.Drawing.Point(493, 3);
            this.btnDriveThru.Name = "btnDriveThru";
            this.btnDriveThru.Size = new System.Drawing.Size(239, 218);
            this.btnDriveThru.TabIndex = 13;
            this.btnDriveThru.Text = "Drive-Thru";
            this.btnDriveThru.UseVisualStyleBackColor = false;
            this.btnDriveThru.Click += new System.EventHandler(this.btnOrderType);
            // 
            // brnDineIn
            // 
            this.brnDineIn.AccessibleDescription = "Dine-in";
            this.brnDineIn.AccessibleName = "2";
            this.brnDineIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.brnDineIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnDineIn.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.brnDineIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.brnDineIn.Location = new System.Drawing.Point(738, 3);
            this.brnDineIn.Name = "brnDineIn";
            this.brnDineIn.Size = new System.Drawing.Size(239, 218);
            this.brnDineIn.TabIndex = 14;
            this.brnDineIn.Text = "Dine-in";
            this.brnDineIn.UseVisualStyleBackColor = false;
            this.brnDineIn.Click += new System.EventHandler(this.btnOrderType);
            // 
            // btnReservation
            // 
            this.btnReservation.AccessibleDescription = "Reservation";
            this.btnReservation.AccessibleName = "2";
            this.btnReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.btnReservation.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReservation.Location = new System.Drawing.Point(3, 227);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(239, 218);
            this.btnReservation.TabIndex = 15;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnOrderType);
            // 
            // btnWebOrder
            // 
            this.btnWebOrder.AccessibleDescription = "Web Order";
            this.btnWebOrder.AccessibleName = "1";
            this.btnWebOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btnWebOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebOrder.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.btnWebOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWebOrder.Location = new System.Drawing.Point(248, 227);
            this.btnWebOrder.Name = "btnWebOrder";
            this.btnWebOrder.Size = new System.Drawing.Size(239, 218);
            this.btnWebOrder.TabIndex = 16;
            this.btnWebOrder.Text = "Web Order";
            this.btnWebOrder.UseVisualStyleBackColor = false;
            this.btnWebOrder.Click += new System.EventHandler(this.btnOrderType);
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.AccessibleDescription = "Takeaway";
            this.btnTakeAway.AccessibleName = "1";
            this.btnTakeAway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAway.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.btnTakeAway.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTakeAway.Location = new System.Drawing.Point(493, 227);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(239, 218);
            this.btnTakeAway.TabIndex = 17;
            this.btnTakeAway.Text = "Takeaway";
            this.btnTakeAway.UseVisualStyleBackColor = false;
            this.btnTakeAway.Click += new System.EventHandler(this.btnOrderType);
            // 
            // btnOther
            // 
            this.btnOther.AccessibleDescription = "Other";
            this.btnOther.AccessibleName = "1";
            this.btnOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOther.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.btnOther.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOther.Location = new System.Drawing.Point(738, 227);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(239, 218);
            this.btnOther.TabIndex = 18;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = false;
            this.btnOther.Click += new System.EventHandler(this.btnOrderType);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Order Type";
            // 
            // Tables
            // 
            this.Tables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.Tables.Controls.Add(this.btnCatSubmit);
            this.Tables.Controls.Add(this.label1);
            this.Tables.Controls.Add(this.panel3);
            this.Tables.Controls.Add(this.panel1);
            this.Tables.Controls.Add(this.label3);
            this.Tables.Location = new System.Drawing.Point(4, 22);
            this.Tables.Name = "Tables";
            this.Tables.Padding = new System.Windows.Forms.Padding(3);
            this.Tables.Size = new System.Drawing.Size(1016, 679);
            this.Tables.TabIndex = 1;
            this.Tables.Text = "Table Management";
            // 
            // btnCatSubmit
            // 
            this.btnCatSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnCatSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCatSubmit.ForeColor = System.Drawing.Color.Snow;
            this.btnCatSubmit.Location = new System.Drawing.Point(870, 59);
            this.btnCatSubmit.Name = "btnCatSubmit";
            this.btnCatSubmit.Size = new System.Drawing.Size(132, 49);
            this.btnCatSubmit.TabIndex = 55;
            this.btnCatSubmit.Text = "ADD TABLE";
            this.btnCatSubmit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(720, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 54;
            this.label1.Text = "Capacity";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.nudCatSortDisplay);
            this.panel3.Location = new System.Drawing.Point(724, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 43);
            this.panel3.TabIndex = 53;
            // 
            // nudCatSortDisplay
            // 
            this.nudCatSortDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.nudCatSortDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCatSortDisplay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCatSortDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nudCatSortDisplay.Location = new System.Drawing.Point(10, 7);
            this.nudCatSortDisplay.Name = "nudCatSortDisplay";
            this.nudCatSortDisplay.Size = new System.Drawing.Size(115, 29);
            this.nudCatSortDisplay.TabIndex = 56;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::POS.Properties.Resources.table_bg;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 530);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(905, 475);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(156, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Table";
            // 
            // Cart
            // 
            this.Cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.Cart.Controls.Add(this.flowLayoutPanel2);
            this.Cart.Controls.Add(this.label4);
            this.Cart.Location = new System.Drawing.Point(4, 22);
            this.Cart.Name = "Cart";
            this.Cart.Padding = new System.Windows.Forms.Padding(3);
            this.Cart.Size = new System.Drawing.Size(1016, 679);
            this.Cart.TabIndex = 2;
            this.Cart.Text = "Order Cart";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cart";
            // 
            // Payment
            // 
            this.Payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.Payment.Location = new System.Drawing.Point(4, 22);
            this.Payment.Name = "Payment";
            this.Payment.Padding = new System.Windows.Forms.Padding(3);
            this.Payment.Size = new System.Drawing.Size(1016, 679);
            this.Payment.TabIndex = 3;
            this.Payment.Text = "Payment";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 45);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 9;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(86)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(228, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(2);
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = " - 1.99";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(86)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(41, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(2);
            this.label10.Size = new System.Drawing.Size(187, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = " Student Discount";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(86)))));
            this.label11.Font = new System.Drawing.Font("Heydings Icons", 15F);
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(3, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(1);
            this.label11.Size = new System.Drawing.Size(38, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "a";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(86)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(228, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(2);
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = " - 1999.99";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(86)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(41, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(2);
            this.label7.Size = new System.Drawing.Size(187, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = " Student Discount";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(86)))));
            this.label6.Font = new System.Drawing.Font("Heydings Icons", 15F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(1);
            this.label6.Size = new System.Drawing.Size(38, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = " t";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(16, 49);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(342, 509);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(342, 36);
            this.label5.TabIndex = 22;
            this.label5.Text = "label5";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(30, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 56);
            this.panel2.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(86)))));
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(0, 92);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(5);
            this.label13.Size = new System.Drawing.Size(342, 36);
            this.label13.TabIndex = 29;
            this.label13.Text = "label13";
            // 
            // frmNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNewOrder_Load);
            this.Tab.ResumeLayout(false);
            this.OrderType.ResumeLayout(false);
            this.OrderType.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Tables.ResumeLayout(false);
            this.Tables.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCatSortDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Cart.ResumeLayout(false);
            this.Cart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage OrderType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Button btnDriveThru;
        private System.Windows.Forms.Button brnDineIn;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnWebOrder;
        private System.Windows.Forms.Button btnTakeAway;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Tables;
        private System.Windows.Forms.TabPage Cart;
        private System.Windows.Forms.TabPage Payment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCatSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nudCatSortDisplay;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
    }
}