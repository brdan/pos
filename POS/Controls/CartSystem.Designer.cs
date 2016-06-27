namespace POS.Controls
{
    partial class CartSystem
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
            this.components = new System.ComponentModel.Container();
            this.flp_cart = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrScroll = new System.Windows.Forms.Timer(this.components);
            this.tmrCool = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.su = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_cart
            // 
            this.flp_cart.AutoScroll = true;
            this.flp_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.flp_cart.Location = new System.Drawing.Point(0, 0);
            this.flp_cart.Margin = new System.Windows.Forms.Padding(0);
            this.flp_cart.Name = "flp_cart";
            this.flp_cart.Size = new System.Drawing.Size(290, 623);
            this.flp_cart.TabIndex = 1;
            // 
            // tmrScroll
            // 
            this.tmrScroll.Interval = 10;
            this.tmrScroll.Tick += new System.EventHandler(this.tmrScroll_Tick);
            // 
            // tmrCool
            // 
            this.tmrCool.Interval = 10;
            this.tmrCool.Tick += new System.EventHandler(this.tmrCool_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblVAT);
            this.panel1.Controls.Add(this.lblDiscount);
            this.panel1.Controls.Add(this.lblSubTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 623);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 119);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(138, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 119);
            this.panel2.TabIndex = 43;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(7, 44);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 25);
            this.lblTotalPrice.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "TOTAL";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblVAT.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblVAT.Location = new System.Drawing.Point(89, 45);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(33, 19);
            this.lblVAT.TabIndex = 42;
            this.lblVAT.Text = "0.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblDiscount.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDiscount.Location = new System.Drawing.Point(89, 69);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(33, 19);
            this.lblDiscount.TabIndex = 41;
            this.lblDiscount.Text = "0.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblSubTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubTotal.Location = new System.Drawing.Point(89, 21);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(33, 19);
            this.lblSubTotal.TabIndex = 40;
            this.lblSubTotal.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(13, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "VAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "DISCOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "SUB-TOTAL";
            // 
            // su
            // 
            this.su.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.su.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.su.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.su.Location = new System.Drawing.Point(267, 371);
            this.su.Margin = new System.Windows.Forms.Padding(0);
            this.su.Name = "su";
            this.su.Size = new System.Drawing.Size(35, 371);
            this.su.TabIndex = 39;
            this.su.Text = "▼";
            this.su.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.su.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnScroll_MouseDown);
            this.su.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnScroll_MouseUp);
            // 
            // sd
            // 
            this.sd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.sd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.sd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.sd.Location = new System.Drawing.Point(267, 0);
            this.sd.Margin = new System.Windows.Forms.Padding(0);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(35, 371);
            this.sd.TabIndex = 40;
            this.sd.Text = "▲";
            this.sd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnScroll_MouseDown);
            this.sd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnScroll_MouseUp);
            // 
            // CartSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.sd);
            this.Controls.Add(this.su);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flp_cart);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CartSystem";
            this.Size = new System.Drawing.Size(302, 742);
            this.Load += new System.EventHandler(this.CartSystem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_cart;
        private System.Windows.Forms.Timer tmrScroll;
        private System.Windows.Forms.Timer tmrCool;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label su;
        private System.Windows.Forms.Label sd;
    }
}
