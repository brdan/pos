using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Classes;

namespace POS.Controls
{
    public partial class CartSystem : UserControl
    {
        bool cartColourPattern = true;
        bool cartScrollDirection;
        int coolValue = 0;
        int selectedItemIndex = -1;

        public CartSystem()
        {
            InitializeComponent();
        }
        Cart TempCart = new Cart();

        public void AddItem(Product p)
        {
            Color pattern = cartColourPattern ? Color.FromArgb(50, 68, 86) : Color.FromArgb(60, 78, 96);
            cartColourPattern = !cartColourPattern;
            Font itemFont = new Font("Segoe UI Light", 13.00f);

            //Item Container
            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.Size = new Size(342, 40);
            flp.Margin = new Padding(0, 0, 0, 0);
            flp.AccessibleName = p.ID.ToString();
            flp.AccessibleDescription = pattern.ToArgb().ToString();

            //Item Name Label
            Label lblName = new Label();
            lblName.Font = itemFont;
            lblName.Text = p.Name;
            lblName.ForeColor = Color.Gainsboro;
            lblName.BackColor = pattern;
            lblName.Margin = new Padding(0, 0, 0, 0);
            lblName.Padding = new Padding(5, 5, 5, 5);
            lblName.Size = new Size(258, 40);
            lblName.Click += item_Click;

            //Item Price Label
            Label lblPrice = new Label();
            lblPrice.Font = itemFont;
            lblPrice.Text = Settings.Setting["currency"] + p.CostPrice;
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblPrice.ForeColor = Color.Gainsboro;
            lblPrice.BackColor = pattern;
            lblPrice.Margin = new Padding(0, 0, 0, 0);
            lblPrice.Padding = new Padding(5, 5, 5, 5);
            lblPrice.Size = new Size(84, 40);
            lblPrice.Click += item_Click;

            flp.Controls.Add(lblName);
            flp.Controls.Add(lblPrice);
            flp_cart.Controls.Add(flp);

            OrderItem newItem = new OrderItem();
            newItem.Description = p.Name;
            newItem.ItemPrice = p.CostPrice;
            TempCart.Items.Add(newItem);


        }
        public void Deselect(Control c)
        {
            flp_cart.Controls[flp_cart.Controls.IndexOf(c)].Controls.OfType<Control>().ToList().ForEach(sc => sc.BackColor = Color.FromArgb(Convert.ToInt32(c.AccessibleDescription)));
            selectedItemIndex = -1;
        }
        public void AddDiscount()
        {
            if (selectedItemIndex == -1)
            {
                MessageBox.Show("You must select an item to add this to...");
            }
            else
            {
                //Adding Discounts & Modifications

                Control selectedItem = flp_cart.Controls[selectedItemIndex];
                MessageBox.Show(selectedItem.GetType().ToString());
                flp_cart.Refresh();
                flp_cart.PerformLayout();

                //If sub-box doesn't exist, quickly create it.
                if (flp_cart.Controls[flp_cart.Controls.IndexOf(selectedItem) + 1].Margin.Left != 27)
                {
                    MessageBox.Show("No box, making one!...");
                    FlowLayoutPanel flp = new FlowLayoutPanel();
                    flp.AutoSize = true;
                    flp.Margin = new Padding(27, 0, 0, 0);
                    flp_cart.Controls.Add(flp);
                    flp_cart.Controls.SetChildIndex(flp, selectedItemIndex + 1);

                }

                Control parent = flp_cart.Controls[selectedItemIndex + 1];
                //the three labels
                Label lblIcon = new Label();
                lblIcon.BackColor = Color.FromArgb(14, 32, 50);
                lblIcon.ForeColor = Color.Gainsboro;
                lblIcon.Font = new Font("Heydings Icons", 15.00f);
                lblIcon.Margin = new Padding(0, 0, 0, 0);
                lblIcon.Padding = new Padding(1, 1, 1, 1);
                lblIcon.Size = new Size(38, 25);
                lblIcon.Text = "t";
                lblIcon.TextAlign = ContentAlignment.MiddleCenter;

                Label lblName = new Label();
                lblName.BackColor = Color.FromArgb(24, 42, 60);
                lblName.ForeColor = Color.Gainsboro;
                lblName.Font = new Font("Segoe UI", 10.00f);
                lblName.Margin = new Padding(0, 0, 0, 0);
                lblName.Padding = new Padding(2, 2, 2, 2);
                lblName.Size = new Size(193, 25);
                lblName.Text = "muuuuki~ :3";

                Label lblPrice = new Label();
                lblPrice.BackColor = Color.FromArgb(24, 42, 60);
                lblPrice.ForeColor = Color.Gainsboro;
                lblPrice.Text = Settings.Setting["currency"] + "1,000,000.00";
                Font font = new Font("Segoe UI", 10.00f);
                if (lblPrice.Text.Length > 7)
                    font = new Font("Segoe UI", 9.00f);
                else if (lblPrice.Text.Length > 9)
                    font = new Font("Segoe UI", 7.00f);
                lblPrice.Font = font;
                lblPrice.TextAlign = ContentAlignment.MiddleLeft;
                lblPrice.Margin = new Padding(0, 0, 0, 0);
                lblPrice.Padding = new Padding(2, 2, 2, 2);
                lblPrice.Size = new Size(84, 25);


                //add controls
                parent.Controls.Add(lblIcon);
                parent.Controls.Add(lblName);
                parent.Controls.Add(lblPrice);
            }
        }


        
        private void item_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.Parent.Controls.OfType<Control>().ToList().ForEach(c => c.BackColor = Color.FromArgb(41, 128, 185));

            if (selectedItemIndex != -1) Deselect(flp_cart.Controls[selectedItemIndex]);

            if (selectedItemIndex == -1)
            {
                flp_cart.Controls[flp_cart.Controls.IndexOf(lbl.Parent)].Controls.OfType<Control>().ToList().ForEach(c => c.BackColor = Color.FromArgb(41, 128, 185));
                selectedItemIndex = flp_cart.Controls.IndexOf(lbl.Parent);
            }
        }




        #region Scrolling Functionality
        private void btnScrollUp_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            cartScrollDirection = btn.Text == "▲" ? true : false;
            tmrScroll.Start();
        }
        private void tmrScroll_Tick(object sender, EventArgs e)
        {
            try
            {
                //up
                if (cartScrollDirection)

                    flp_cart.VerticalScroll.Value -= 10;


                //down
                else if (!cartScrollDirection)
                {
                    flp_cart.VerticalScroll.Value += 10;
                }
            }
            catch (Exception)
            {

            }
            flp_cart.PerformLayout();
            flp_cart.Refresh();
        }
        private void btnScrollDown_MouseUp(object sender, MouseEventArgs e)
        {
            tmrScroll.Stop();
            coolValue = cartScrollDirection ? flp_cart.VerticalScroll.Value - 50 : flp_cart.VerticalScroll.Value + 50;
            tmrCool.Start();
        }
        private void tmrCool_Tick(object sender, EventArgs e)
        {
            try
            {
                if (cartScrollDirection)
                {
                    if ((flp_cart.VerticalScroll.Value - coolValue) >= 30)
                    {
                        flp_cart.VerticalScroll.Value -= 5;
                    }
                    else if ((flp_cart.VerticalScroll.Value - coolValue) > 12)
                    {
                        flp_cart.VerticalScroll.Value -= 2;
                    }
                    else
                    {
                        tmrCool.Stop();
                    }
                }

                //cool down
                else
                {

                    if ((coolValue - flp_cart.VerticalScroll.Value) >= 30)
                    {
                        flp_cart.VerticalScroll.Value += 5;
                    }
                    else if ((coolValue - flp_cart.VerticalScroll.Value) > 8)
                    {
                        flp_cart.VerticalScroll.Value += 2;
                    }
                    else
                    {
                        tmrCool.Stop();
                    }

                }
            }
            catch (Exception)
            {

            }
        }
        #endregion 
    }
}
