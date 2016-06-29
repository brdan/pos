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
        bool pnlOptionsVisible = false;
        bool cartScrollDirection;
        int coolValue = 0;
        int selectedItemIndex = -1;
        decimal _totalPrice = 0.00M;
        decimal totalPrice
        {
            get { return _totalPrice; }
            set
            {
                _totalPrice = value;
                lblTotalPrice.Text = Settings.Setting["currency"] + _totalPrice.ToString();
            }
        }

        Cart TempCart = new Cart();
        public CartSystem()
        {
            InitializeComponent();
        }

        public void Deselect(Control c)
        {
            flp_cart.Controls[flp_cart.Controls.IndexOf(c)].Controls.OfType<Control>().ToList().ForEach(sc => sc.BackColor = Color.FromArgb(Convert.ToInt32(c.AccessibleDescription)));
            selectedItemIndex = -1;
        }

        public void AddItem(Product p)
        {
            Color pattern = cartColourPattern ? Color.FromArgb(50, 68, 86) : Color.FromArgb(60, 78, 96);
            cartColourPattern = !cartColourPattern;
            Font itemFont = new Font("Segoe UI", 10.00f);

            //Item Container
            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.Size = new Size(268, 60);
            flp.AutoSize = true;
            flp.Margin = new Padding(0, 0, 0, 0);
            flp.AccessibleName = p.ID.ToString();
            flp.AccessibleDescription = pattern.ToArgb().ToString();

            //Item Qty Label
            Label lblQty = new Label();
            lblQty.Font = itemFont;
            lblQty.Text = "1";
            lblQty.ForeColor = Color.Gainsboro;
            lblQty.BackColor = pattern;
            lblQty.Margin = new Padding(0, 0, 0, 0);
            lblQty.Padding = new Padding(5, 5, 5, 5);
            lblQty.AutoSize = true;
            lblQty.TextAlign = ContentAlignment.MiddleCenter;
            lblQty.MinimumSize = new Size(32, 60);
            lblQty.MaximumSize = new Size(32, 0);
            lblQty.Dock = DockStyle.Left;
            lblQty.Click += item_Click;

            //Item Name Label
            Label lblName = new Label();
            lblName.Font = itemFont;
            lblName.Text = p.Name;
            lblName.ForeColor = Color.Gainsboro;
            lblName.BackColor = pattern;
            lblName.Margin = new Padding(0, 0, 0, 0);
            lblName.Padding = new Padding(5, 5, 5, 5);
            lblName.AutoSize = true;
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            lblName.MinimumSize = new Size(172, 60);
            lblName.MaximumSize = new Size(172, 0);
            lblName.Click += item_Click;

            //Item Price Label
            Label lblPrice = new Label();
            lblPrice.Font = new Font("Segoe UI", 10.00f, FontStyle.Bold);
            lblPrice.Text = Settings.Setting["currency"] + p.CostPrice;
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblPrice.ForeColor = Color.Gainsboro;
            lblPrice.BackColor = pattern;
            lblPrice.Margin = new Padding(0, 0, 0, 0);
            lblPrice.Padding = new Padding(5, 5, 5, 5);
            lblPrice.AutoSize = true;
            lblPrice.MinimumSize = new Size(64, 60);
            lblPrice.MaximumSize = new Size(64, 0);
            lblPrice.Dock = DockStyle.Right;
            lblPrice.Click += item_Click;

            flp.Controls.Add(lblQty);
            flp.Controls.Add(lblName);
            flp.Controls.Add(lblPrice);
            flp_cart.Controls.Add(flp);

            OrderItem newItem = new OrderItem();
            newItem.Description = p.Name;
            newItem.ItemPrice = p.CostPrice;
            TempCart.Items.Add(newItem);

            //Update Prices
            totalPrice += newItem.ItemPrice;


        }
        private void item_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            int lastSelectedIndex = -1;
            //If something is already selected, clear all selection
            if (selectedItemIndex != -1)
            {
                lastSelectedIndex = selectedItemIndex;
                Deselect(flp_cart.Controls[selectedItemIndex]);
            }

            //If nothing is selected (after clearing)
            if (selectedItemIndex == -1)
            {
                if (flp_cart.Controls.IndexOf(lbl.Parent) != lastSelectedIndex)
                {
                    //flp_cart.Controls[flp_cart.Controls.IndexOf(lbl.Parent)].Controls.OfType<Control>().ToList().ForEach(c => c.BackColor = Color.FromArgb(41, 128, 185));
                    selectedItemIndex = flp_cart.Controls.IndexOf(lbl.Parent);
                    lbl.Parent.Controls.OfType<Control>().ToList().ForEach(c => c.BackColor = Color.FromArgb(41, 128, 185));
                    pnlOptionsVisible = false;
                    tmrOptions.Start();

                }
                else
                {
                    lastSelectedIndex = -1;
                    pnlOptionsVisible = true;
                    tmrOptions.Start();
                }
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedItemIndex != -1)
            {
                Control selectedItem = flp_cart.Controls[selectedItemIndex];
                int thisItem = flp_cart.Controls.IndexOf(selectedItem);
                try
                {
                    //Remove sub-items
                    if (flp_cart.Controls[selectedItemIndex + 1].Margin.Left == 20)
                    {
                        flp_cart.Controls.Remove(flp_cart.Controls[selectedItemIndex + 1]);
                    }
                }
                catch (Exception)
                {
                }

                //Deduct price
                decimal price = Convert.ToDecimal(selectedItem.Controls[2].Text.Substring(1));
                totalPrice -= price;

                //Deselect Logically
                Deselect(selectedItem);

                //Visually Remove
                flp_cart.Controls.Remove(selectedItem);

                //Selecting the subsequent product; if none exists, options slide down.
                if (flp_cart.Controls.Count > 0)
                {
                    if (thisItem != flp_cart.Controls.Count)
                    {
                        selectedItemIndex = thisItem;
                    }
                    else
                    {
                        selectedItemIndex = thisItem - 1;
                    }

                    flp_cart.Controls[selectedItemIndex].Controls.OfType<Control>().ToList().ForEach(c => c.BackColor = Color.FromArgb(41, 128, 185));
                }
                else
                {
                    pnlOptionsVisible = true;
                    tmrOptions.Start();
                }
            }
        }
        public void AddSubItem(bool DiscountOrModifier, string textString, string priceString)
        {
            if (selectedItemIndex == -1)
            {
                MessageBox.Show("You must select an item to add this to...", "No item selected");
            }
            else
            {
                //Adding Discounts & Modifications

                Control selectedItem = flp_cart.Controls[selectedItemIndex];
                flp_cart.Refresh();
                flp_cart.PerformLayout();

                //If sub-box doesn't exist, quickly create it.
                #region Creates Sub-Box if it's non-existent
                try
                {
                    if (flp_cart.Controls[selectedItemIndex + 1].Margin.Left != 20)
                    {
                        FlowLayoutPanel flp = new FlowLayoutPanel();
                        flp.AutoSize = true;
                        flp.Margin = new Padding(20, 0, 0, 0);
                        flp_cart.Controls.Add(flp);
                        flp_cart.Controls.SetChildIndex(flp, selectedItemIndex + 1);

                    }
                }
                catch (Exception)
                {
                    FlowLayoutPanel flp = new FlowLayoutPanel();
                    flp.AutoSize = true;
                    flp.Margin = new Padding(20, 0, 0, 0);
                    flp_cart.Controls.Add(flp);
                    flp_cart.Controls.SetChildIndex(flp, selectedItemIndex + 1);
                }
                #endregion

                #region Designs the three labels based on parameters, then adds it to the Sub-Box
                Control parent = flp_cart.Controls[selectedItemIndex + 1];
                //the three labels
                Label lblIcon = new Label();
                lblIcon.BackColor = Color.FromArgb(14, 32, 50);
                lblIcon.ForeColor = Color.Gainsboro;
                lblIcon.Font = new Font("Heydings Icons", 13.00f);
                lblIcon.Margin = new Padding(0, 0, 0, 0);
                lblIcon.Padding = new Padding(1, 1, 1, 1);
                lblIcon.Size = new Size(30, 25);
                lblIcon.Dock = DockStyle.Left;
                lblIcon.Text = DiscountOrModifier ? "t" : "a";
                lblIcon.TextAlign = ContentAlignment.MiddleCenter;
                lblIcon.Click += subItem_Click;

                Label lblName = new Label();
                lblName.BackColor = Color.FromArgb(24, 42, 60);
                lblName.ForeColor = Color.Gainsboro;
                lblName.Font = new Font("Segoe UI", 9.00f);
                lblName.Margin = new Padding(0, 0, 0, 0);
                lblName.Padding = new Padding(2, 2, 2, 2);
                lblName.Text = textString;
                lblName.TextAlign = ContentAlignment.MiddleLeft;
                lblName.AutoSize = true;
                lblName.Dock = DockStyle.Left;
                lblName.MaximumSize = new Size(160, 0);
                lblName.MinimumSize = new Size(160, 25);
                lblName.Click += subItem_Click;

                Label lblPrice = new Label();
                lblPrice.BackColor = Color.FromArgb(34, 52, 70);
                lblPrice.ForeColor = DiscountOrModifier ? Color.FromArgb(231, 76, 60) : Color.FromArgb(46, 204, 113);
                string str = DiscountOrModifier ? "-" : "+";
                lblPrice.Text = str + Settings.Setting["currency"] + priceString;
                Font font = new Font("Segoe UI", 10.00f);
                if (lblPrice.Text.Length > 5)
                    font = new Font("Segoe UI", 9.00f);
                else if (lblPrice.Text.Length > 7)
                    font = new Font("Segoe UI", 5.00f);
                lblPrice.Font = font;
                lblPrice.Dock = DockStyle.Left;
                lblPrice.TextAlign = ContentAlignment.MiddleLeft;
                lblPrice.Margin = new Padding(0, 0, 0, 0);
                lblPrice.BackColor = Color.FromArgb(24, 42, 60);
                lblPrice.Padding = new Padding(2, 2, 2, 2);
                lblPrice.MaximumSize = new Size(63, 0);
                lblPrice.MinimumSize = new Size(63, 25);
                lblPrice.AutoSize = true;
                lblPrice.Click += subItem_Click;


                //add controls
                parent.Controls.Add(lblIcon);
                parent.Controls.Add(lblName);
                parent.Controls.Add(lblPrice);
                #endregion

                #region Price Updating
                // The above code checks if the selected item has a "sub-item's box" - if it does, it adds the sub-item accordingly; if not, it creates it, then adds the item.
                decimal newParentItemPrice = 0.00M;
                //Updating prices according to the added/deducted price on the item, also will need to update the item's `Price` field accordingly
                if (DiscountOrModifier)
                {
                    //deduct
                    decimal parentItemPrice = Convert.ToDecimal(selectedItem.Controls[2].Text.Substring(1));
                    newParentItemPrice = parentItemPrice - Convert.ToDecimal(priceString);
                    if (newParentItemPrice < 0.00M)
                        newParentItemPrice = 0.00M;

                    totalPrice -= (parentItemPrice - newParentItemPrice); //this way no negative value issues
                }
                else
                {
                    decimal parentItemPrice = Convert.ToDecimal(selectedItem.Controls[2].Text.Substring(1));
                    newParentItemPrice = Convert.ToDecimal(priceString) + parentItemPrice;
                    totalPrice += Convert.ToDecimal(priceString);
                }

                //updating prices
                flp_cart.Controls[selectedItemIndex].Controls[2].Text = Settings.Setting["currency"] + newParentItemPrice;
                #endregion

                #region Changing the colour to indicate price influence
                flp_cart.Controls[selectedItemIndex].Controls[2].ForeColor = Color.FromArgb(232, 126, 4);
                #endregion 
            }
        }
        private void subItem_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            MessageBox.Show("You've clicked on a sub-item");
        }


        #region Options animation and Control load
        private void tmrOptions_Tick(object sender, EventArgs e)
        {
            if (!pnlOptionsVisible)
                if (pnlOptions.Height < 122)
                    pnlOptions.Height += 2;
                else
                {
                    tmrOptions.Stop();
                    pnlOptions.Visible = true;
                }
            else if (pnlOptionsVisible)
                if (pnlOptions.Height > 0)
                    pnlOptions.Height -= 2;
                else
                {
                    tmrOptions.Stop();
                    pnlOptionsVisible = false;
                }
        }
        #endregion
        #region Scrolling Functionality
        private void btnScroll_MouseDown(object sender, MouseEventArgs e)
        {
            Label btn = (Label)sender;
            cartScrollDirection = btn.Text == "▲" ? true : false;
            tmrScroll.Start();
        }
        private void btnScroll_MouseUp(object sender, MouseEventArgs e)
        {
            tmrScroll.Stop();
            coolValue = cartScrollDirection ? flp_cart.VerticalScroll.Value - 50 : flp_cart.VerticalScroll.Value + 50;
            tmrCool.Start();
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
