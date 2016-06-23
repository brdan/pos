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
            this.label56.Location = new System.Drawing.Point(342, 0);
            this.label56.Margin = new System.Windows.Forms.Padding(0);
            this.label56.Name = "label56";
            this.label56.Padding = new System.Windows.Forms.Padding(5);
            this.label56.Size = new System.Drawing.Size(18, 510);
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
            // CartSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.btnScrollDown);
            this.Controls.Add(this.btnScrollUp);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.flp_cart);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CartSystem";
            this.Size = new System.Drawing.Size(533, 510);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_cart;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button btnScrollDown;
        private System.Windows.Forms.Button btnScrollUp;
        private System.Windows.Forms.Timer tmrScroll;
        private System.Windows.Forms.Timer tmrCool;
    }
}
