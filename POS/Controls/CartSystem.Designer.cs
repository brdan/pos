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
            this.label56 = new System.Windows.Forms.Label();
            this.btnScrollDown = new System.Windows.Forms.Button();
            this.btnScrollUp = new System.Windows.Forms.Button();
            this.tmrScroll = new System.Windows.Forms.Timer(this.components);
            this.tmrCool = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.flp_cart.Size = new System.Drawing.Size(360, 510);
            this.flp_cart.TabIndex = 1;
            // 
            // label56
            // 
            this.label56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label56.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label56.ForeColor = System.Drawing.Color.Gainsboro;
            this.label56.Location = new System.Drawing.Point(340, 0);
            this.label56.Margin = new System.Windows.Forms.Padding(0);
            this.label56.Name = "label56";
            this.label56.Padding = new System.Windows.Forms.Padding(5);
            this.label56.Size = new System.Drawing.Size(20, 510);
            this.label56.TabIndex = 31;
            // 
            // btnScrollDown
            // 
            this.btnScrollDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnScrollDown.Location = new System.Drawing.Point(396, 225);
            this.btnScrollDown.Name = "btnScrollDown";
            this.btnScrollDown.Size = new System.Drawing.Size(77, 49);
            this.btnScrollDown.TabIndex = 33;
            this.btnScrollDown.Text = "▼";
            this.btnScrollDown.UseVisualStyleBackColor = true;
            this.btnScrollDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnScrollUp_MouseDown);
            this.btnScrollDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnScrollDown_MouseUp);
            // 
            // btnScrollUp
            // 
            this.btnScrollUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnScrollUp.Location = new System.Drawing.Point(396, 170);
            this.btnScrollUp.Name = "btnScrollUp";
            this.btnScrollUp.Size = new System.Drawing.Size(77, 49);
            this.btnScrollUp.TabIndex = 32;
            this.btnScrollUp.Text = "▲";
            this.btnScrollUp.UseVisualStyleBackColor = true;
            this.btnScrollUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnScrollUp_MouseDown);
            this.btnScrollUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnScrollDown_MouseUp);
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
            this.panel1.Location = new System.Drawing.Point(0, 509);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 100);
            this.panel1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "SUB-TOTAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "DISCOUNT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(8, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "VAT";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblVAT.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblVAT.Location = new System.Drawing.Point(84, 41);
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
            this.lblDiscount.Location = new System.Drawing.Point(84, 65);
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
            this.lblSubTotal.Location = new System.Drawing.Point(84, 17);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(33, 19);
            this.lblSubTotal.TabIndex = 40;
            this.lblSubTotal.Text = "0.00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(175, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 100);
            this.panel2.TabIndex = 43;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalPrice.Location = new System.Drawing.Point(24, 33);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 37);
            this.lblTotalPrice.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(28, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "TOTAL";
            // 
            // CartSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnScrollDown);
            this.Controls.Add(this.btnScrollUp);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.flp_cart);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CartSystem";
            this.Size = new System.Drawing.Size(533, 638);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_cart;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button btnScrollDown;
        private System.Windows.Forms.Button btnScrollUp;
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
    }
}
