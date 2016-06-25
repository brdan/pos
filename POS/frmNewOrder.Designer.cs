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
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCatSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nudCatSortDisplay = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cart = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CartSystem = new POS.Controls.CartSystem();
            this.label4 = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
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
            this.Payment.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tab.Controls.Add(this.OrderType);
            this.Tab.Controls.Add(this.Tables);
            this.Tab.Controls.Add(this.Cart);
            this.Tab.Controls.Add(this.Payment);
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1024, 768);
            this.Tab.TabIndex = 10;
            // 
            // OrderType
            // 
            this.OrderType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.OrderType.Controls.Add(this.flowLayoutPanel1);
            this.OrderType.Controls.Add(this.label2);
            this.OrderType.Location = new System.Drawing.Point(4, 22);
            this.OrderType.Name = "OrderType";
            this.OrderType.Size = new System.Drawing.Size(1016, 742);
            this.OrderType.TabIndex = 0;
            this.OrderType.Text = "Select Order Type";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.flowLayoutPanel1.Controls.Add(this.btnDelivery);
            this.flowLayoutPanel1.Controls.Add(this.btnBar);
            this.flowLayoutPanel1.Controls.Add(this.btnDriveThru);
            this.flowLayoutPanel1.Controls.Add(this.brnDineIn);
            this.flowLayoutPanel1.Controls.Add(this.btnReservation);
            this.flowLayoutPanel1.Controls.Add(this.btnWebOrder);
            this.flowLayoutPanel1.Controls.Add(this.btnTakeAway);
            this.flowLayoutPanel1.Controls.Add(this.btnOther);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 110);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(983, 609);
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
            this.btnDelivery.Location = new System.Drawing.Point(53, 53);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(435, 124);
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
            this.btnBar.Location = new System.Drawing.Point(494, 53);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(435, 124);
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
            this.btnDriveThru.Location = new System.Drawing.Point(53, 183);
            this.btnDriveThru.Name = "btnDriveThru";
            this.btnDriveThru.Size = new System.Drawing.Size(435, 124);
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
            this.brnDineIn.Location = new System.Drawing.Point(494, 183);
            this.brnDineIn.Name = "brnDineIn";
            this.brnDineIn.Size = new System.Drawing.Size(435, 124);
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
            this.btnReservation.Location = new System.Drawing.Point(53, 313);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(435, 124);
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
            this.btnWebOrder.Location = new System.Drawing.Point(494, 313);
            this.btnWebOrder.Name = "btnWebOrder";
            this.btnWebOrder.Size = new System.Drawing.Size(435, 124);
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
            this.btnTakeAway.Location = new System.Drawing.Point(53, 443);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(435, 124);
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
            this.btnOther.Location = new System.Drawing.Point(494, 443);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(435, 124);
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
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Order Type";
            // 
            // Tables
            // 
            this.Tables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.Tables.Controls.Add(this.label12);
            this.Tables.Controls.Add(this.label10);
            this.Tables.Controls.Add(this.label7);
            this.Tables.Controls.Add(this.label5);
            this.Tables.Controls.Add(this.btnCatSubmit);
            this.Tables.Controls.Add(this.label1);
            this.Tables.Controls.Add(this.panel3);
            this.Tables.Controls.Add(this.panel1);
            this.Tables.Controls.Add(this.label3);
            this.Tables.Location = new System.Drawing.Point(4, 22);
            this.Tables.Margin = new System.Windows.Forms.Padding(0);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(1016, 742);
            this.Tables.TabIndex = 1;
            this.Tables.Text = "Table Management";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(-4109, -3305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 25);
            this.label12.TabIndex = 59;
            this.label12.Text = "Select Order Type";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(-4933, -3909);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 25);
            this.label10.TabIndex = 58;
            this.label10.Text = "Select Order Type";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(-5345, -4211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "Select Table";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(-5757, -4513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 56;
            this.label5.Text = "Select Table";
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
            this.label1.Location = new System.Drawing.Point(-5460, -4787);
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
            this.panel3.Location = new System.Drawing.Point(-5456, -4763);
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
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 605);
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
            this.label3.Location = new System.Drawing.Point(-6169, -4815);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Table";
            // 
            // Cart
            // 
            this.Cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Cart.Controls.Add(this.button1);
            this.Cart.Controls.Add(this.label14);
            this.Cart.Controls.Add(this.label11);
            this.Cart.Controls.Add(this.label8);
            this.Cart.Controls.Add(this.label6);
            this.Cart.Controls.Add(this.CartSystem);
            this.Cart.Controls.Add(this.label4);
            this.Cart.Location = new System.Drawing.Point(4, 22);
            this.Cart.Name = "Cart";
            this.Cart.Padding = new System.Windows.Forms.Padding(3);
            this.Cart.Size = new System.Drawing.Size(1016, 742);
            this.Cart.TabIndex = 2;
            this.Cart.Text = "Order Cart";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(-3640, -3331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 25);
            this.label14.TabIndex = 61;
            this.label14.Text = "Categories";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(-4933, -3935);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Your Cart";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(-5345, -4237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 58;
            this.label8.Text = "Your Cart";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(-5757, -4534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "Your Cart";
            // 
            // CartSystem
            // 
            this.CartSystem.AutoSize = true;
            this.CartSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.CartSystem.Dock = System.Windows.Forms.DockStyle.Left;
            this.CartSystem.Location = new System.Drawing.Point(3, 3);
            this.CartSystem.Margin = new System.Windows.Forms.Padding(0);
            this.CartSystem.Name = "CartSystem";
            this.CartSystem.Size = new System.Drawing.Size(302, 736);
            this.CartSystem.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(-6169, -4841);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cart";
            // 
            // Payment
            // 
            this.Payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.Payment.Controls.Add(this.label9);
            this.Payment.Location = new System.Drawing.Point(4, 22);
            this.Payment.Name = "Payment";
            this.Payment.Padding = new System.Windows.Forms.Padding(3);
            this.Payment.Size = new System.Drawing.Size(1016, 742);
            this.Payment.TabIndex = 3;
            this.Payment.Text = "Payment";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(-5345, -4237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Payment";
            // 
            // frmNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.Tab);
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
            this.Payment.ResumeLayout(false);
            this.Payment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.TabPage Payment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCatSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nudCatSortDisplay;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage Cart;
        private Controls.CartSystem CartSystem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
    }
}