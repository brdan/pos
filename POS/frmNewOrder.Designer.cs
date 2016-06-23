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
            this.components = new System.ComponentModel.Container();
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
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label56 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.btnScrollDown = new System.Windows.Forms.Button();
            this.btnScrollUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flp_cart = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cooler = new System.Windows.Forms.Timer(this.components);
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
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
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
            this.Cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Cart.Controls.Add(this.label6);
            this.Cart.Controls.Add(this.button2);
            this.Cart.Controls.Add(this.label56);
            this.Cart.Controls.Add(this.flowLayoutPanel5);
            this.Cart.Controls.Add(this.btnScrollDown);
            this.Cart.Controls.Add(this.btnScrollUp);
            this.Cart.Controls.Add(this.button1);
            this.Cart.Controls.Add(this.flp_cart);
            this.Cart.Controls.Add(this.label4);
            this.Cart.Location = new System.Drawing.Point(4, 22);
            this.Cart.Name = "Cart";
            this.Cart.Padding = new System.Windows.Forms.Padding(3);
            this.Cart.Size = new System.Drawing.Size(1016, 679);
            this.Cart.TabIndex = 2;
            this.Cart.Text = "Order Cart";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(392, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cart";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 84);
            this.button2.TabIndex = 31;
            this.button2.Text = "add discount";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label56
            // 
            this.label56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label56.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label56.ForeColor = System.Drawing.Color.Gainsboro;
            this.label56.Location = new System.Drawing.Point(358, 49);
            this.label56.Margin = new System.Windows.Forms.Padding(0);
            this.label56.Name = "label56";
            this.label56.Padding = new System.Windows.Forms.Padding(5);
            this.label56.Size = new System.Drawing.Size(18, 510);
            this.label56.TabIndex = 30;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel11);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(603, 133);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(360, 509);
            this.flowLayoutPanel5.TabIndex = 15;
            this.flowLayoutPanel5.Visible = false;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label5);
            this.flowLayoutPanel8.Controls.Add(this.label22);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(360, 40);
            this.flowLayoutPanel8.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(86)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(276, 40);
            this.label5.TabIndex = 29;
            this.label5.Text = "label5";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(86)))));
            this.label22.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label22.ForeColor = System.Drawing.Color.Gainsboro;
            this.label22.Location = new System.Drawing.Point(276, 0);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.Padding = new System.Windows.Forms.Padding(5);
            this.label22.Size = new System.Drawing.Size(84, 40);
            this.label22.TabIndex = 36;
            this.label22.Text = "£1,000,000.00";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.label23);
            this.flowLayoutPanel9.Controls.Add(this.label24);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(360, 40);
            this.flowLayoutPanel9.TabIndex = 37;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.label23.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label23.ForeColor = System.Drawing.Color.Gainsboro;
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Margin = new System.Windows.Forms.Padding(0);
            this.label23.Name = "label23";
            this.label23.Padding = new System.Windows.Forms.Padding(5);
            this.label23.Size = new System.Drawing.Size(276, 40);
            this.label23.TabIndex = 29;
            this.label23.Text = "label23";
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.label24.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label24.ForeColor = System.Drawing.Color.Gainsboro;
            this.label24.Location = new System.Drawing.Point(276, 0);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Padding = new System.Windows.Forms.Padding(5);
            this.label24.Size = new System.Drawing.Size(84, 40);
            this.label24.TabIndex = 36;
            this.label24.Text = "£29.00";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.AutoSize = true;
            this.flowLayoutPanel11.Controls.Add(this.label34);
            this.flowLayoutPanel11.Controls.Add(this.label35);
            this.flowLayoutPanel11.Controls.Add(this.label36);
            this.flowLayoutPanel11.Controls.Add(this.label37);
            this.flowLayoutPanel11.Controls.Add(this.label38);
            this.flowLayoutPanel11.Controls.Add(this.label39);
            this.flowLayoutPanel11.Controls.Add(this.label40);
            this.flowLayoutPanel11.Controls.Add(this.label41);
            this.flowLayoutPanel11.Controls.Add(this.label42);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(45, 80);
            this.flowLayoutPanel11.Margin = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(315, 75);
            this.flowLayoutPanel11.TabIndex = 30;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label34.Font = new System.Drawing.Font("Heydings Icons", 15F);
            this.label34.ForeColor = System.Drawing.Color.Gainsboro;
            this.label34.Location = new System.Drawing.Point(0, 0);
            this.label34.Margin = new System.Windows.Forms.Padding(0);
            this.label34.Name = "label34";
            this.label34.Padding = new System.Windows.Forms.Padding(1);
            this.label34.Size = new System.Drawing.Size(38, 25);
            this.label34.TabIndex = 21;
            this.label34.Text = " t";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.label35.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label35.ForeColor = System.Drawing.Color.Gainsboro;
            this.label35.Location = new System.Drawing.Point(38, 0);
            this.label35.Margin = new System.Windows.Forms.Padding(0);
            this.label35.Name = "label35";
            this.label35.Padding = new System.Windows.Forms.Padding(2);
            this.label35.Size = new System.Drawing.Size(193, 25);
            this.label35.TabIndex = 22;
            this.label35.Text = " Student Discount";
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.label36.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label36.ForeColor = System.Drawing.Color.Gainsboro;
            this.label36.Location = new System.Drawing.Point(231, 0);
            this.label36.Margin = new System.Windows.Forms.Padding(0);
            this.label36.Name = "label36";
            this.label36.Padding = new System.Windows.Forms.Padding(2);
            this.label36.Size = new System.Drawing.Size(84, 25);
            this.label36.TabIndex = 26;
            this.label36.Text = " - 1.99";
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label37.Font = new System.Drawing.Font("Heydings Icons", 15F);
            this.label37.ForeColor = System.Drawing.Color.Gainsboro;
            this.label37.Location = new System.Drawing.Point(0, 25);
            this.label37.Margin = new System.Windows.Forms.Padding(0);
            this.label37.Name = "label37";
            this.label37.Padding = new System.Windows.Forms.Padding(1);
            this.label37.Size = new System.Drawing.Size(38, 25);
            this.label37.TabIndex = 24;
            this.label37.Text = "a";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.label38.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label38.ForeColor = System.Drawing.Color.Gainsboro;
            this.label38.Location = new System.Drawing.Point(38, 25);
            this.label38.Margin = new System.Windows.Forms.Padding(0);
            this.label38.Name = "label38";
            this.label38.Padding = new System.Windows.Forms.Padding(2);
            this.label38.Size = new System.Drawing.Size(193, 25);
            this.label38.TabIndex = 25;
            this.label38.Text = " Student Discount";
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.label39.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label39.ForeColor = System.Drawing.Color.Gainsboro;
            this.label39.Location = new System.Drawing.Point(231, 25);
            this.label39.Margin = new System.Windows.Forms.Padding(0);
            this.label39.Name = "label39";
            this.label39.Padding = new System.Windows.Forms.Padding(2);
            this.label39.Size = new System.Drawing.Size(84, 25);
            this.label39.TabIndex = 23;
            this.label39.Text = " - 1999.99";
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label40.Font = new System.Drawing.Font("Heydings Icons", 15F);
            this.label40.ForeColor = System.Drawing.Color.Gainsboro;
            this.label40.Location = new System.Drawing.Point(0, 50);
            this.label40.Margin = new System.Windows.Forms.Padding(0);
            this.label40.Name = "label40";
            this.label40.Padding = new System.Windows.Forms.Padding(1);
            this.label40.Size = new System.Drawing.Size(38, 25);
            this.label40.TabIndex = 28;
            this.label40.Text = "a";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.label41.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label41.ForeColor = System.Drawing.Color.Gainsboro;
            this.label41.Location = new System.Drawing.Point(38, 50);
            this.label41.Margin = new System.Windows.Forms.Padding(0);
            this.label41.Name = "label41";
            this.label41.Padding = new System.Windows.Forms.Padding(2);
            this.label41.Size = new System.Drawing.Size(193, 25);
            this.label41.TabIndex = 29;
            this.label41.Text = " Student Discount";
            // 
            // label42
            // 
            this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.label42.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label42.ForeColor = System.Drawing.Color.Gainsboro;
            this.label42.Location = new System.Drawing.Point(231, 50);
            this.label42.Margin = new System.Windows.Forms.Padding(0);
            this.label42.Name = "label42";
            this.label42.Padding = new System.Windows.Forms.Padding(2);
            this.label42.Size = new System.Drawing.Size(84, 25);
            this.label42.TabIndex = 27;
            this.label42.Text = " - 1999.99";
            // 
            // btnScrollDown
            // 
            this.btnScrollDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnScrollDown.Location = new System.Drawing.Point(397, 106);
            this.btnScrollDown.Name = "btnScrollDown";
            this.btnScrollDown.Size = new System.Drawing.Size(77, 49);
            this.btnScrollDown.TabIndex = 14;
            this.btnScrollDown.Text = "▼";
            this.btnScrollDown.UseVisualStyleBackColor = true;
            this.btnScrollDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnScroll_MouseDown);
            this.btnScrollDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnScroll_MouseUp);
            // 
            // btnScrollUp
            // 
            this.btnScrollUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnScrollUp.Location = new System.Drawing.Point(397, 51);
            this.btnScrollUp.Name = "btnScrollUp";
            this.btnScrollUp.Size = new System.Drawing.Size(77, 49);
            this.btnScrollUp.TabIndex = 13;
            this.btnScrollUp.Text = "▲";
            this.btnScrollUp.UseVisualStyleBackColor = true;
            this.btnScrollUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnScroll_MouseDown);
            this.btnScrollUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnScroll_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 84);
            this.button1.TabIndex = 12;
            this.button1.Text = "add item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flp_cart
            // 
            this.flp_cart.AutoScroll = true;
            this.flp_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.flp_cart.Location = new System.Drawing.Point(16, 49);
            this.flp_cart.Margin = new System.Windows.Forms.Padding(0);
            this.flp_cart.Name = "flp_cart";
            this.flp_cart.Size = new System.Drawing.Size(360, 510);
            this.flp_cart.TabIndex = 0;
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
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            // 
            // cooler
            // 
            this.cooler.Interval = 10;
            this.cooler.Tick += new System.EventHandler(this.cooler_Tick);
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
            this.DoubleBuffered = true;
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
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flp_cart;
        private System.Windows.Forms.Button btnScrollDown;
        private System.Windows.Forms.Button btnScrollUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer cooler;
    }
}