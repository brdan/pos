using POS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmNewOrder : Form
    {
        public frmNewOrder()
        {
            InitializeComponent();
        }
        Order tempOrder;
        Cart tempCart;
        bool cartColourPattern = true;
        bool cartScrollDirection;
        bool cooling = false;
        int coolValue = 0;
        int selectedItemIndex = -1;

        public void Index()
        {
            Tab.SelectTab(0);

            this.Show();
        }
        public void loadCart(Order o)
        {
            Tab.SelectTab("Cart");

        }
        public void initOrder(Button btn)
        {
            /*
            *  We have three cases here
            *  1 - The order doesn't have any further info - proceed to cart section
            *  2 - The order requires table configuration - proceed to table management
            *  3 - The order is a delivery - proceed to car management thingy
            */

            /*
            *  Order Statuses
            *  1 - Created but empty
            *  2 - Pending/Unpaid
            *  3 - Cancelled
            *  4 - Comlpleted
            */
            tempOrder = new Order();
            tempCart = new Cart();

            int routePath = Convert.ToInt16(btn.AccessibleName);

            tempOrder.OrderStatus = 1;
            tempOrder.OrderDate = DateTime.Today;
            tempOrder.EmployeeID = Collections.CurrentUser.ID;
            tempOrder.TotalPaid = 0.00M;
            tempOrder.OrderType = btn.AccessibleDescription;

            switch (routePath)
            {
                case 1:
                    loadCart(tempOrder);
                    lblTitle.Text = "Creating Order...";
                    btnBack.AccessibleName = "1";
                    break;

                case 2:
                    break;

                case 3:
                    break;

                default:
                    break;
            }

        }
        public void addItem(Product p)
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
            tempCart.Items.Add(newItem);


        }
        public void deselect(Control c)
        {
            flp_cart.Controls[flp_cart.Controls.IndexOf(c)].Controls.OfType<Control>().ToList().ForEach(sc => sc.BackColor = Color.FromArgb(Convert.ToInt32(c.AccessibleDescription)));
            selectedItemIndex = -1;

        }


        private void item_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.Parent.Controls.OfType<Control>().ToList().ForEach(c => c.BackColor = Color.FromArgb(41, 128, 185));

            if (selectedItemIndex != -1) deselect(flp_cart.Controls[selectedItemIndex]);

            if (selectedItemIndex == -1)
            {
                flp_cart.Controls[flp_cart.Controls.IndexOf(lbl.Parent)].Controls.OfType<Control>().ToList().ForEach(c => c.BackColor = Color.FromArgb(41, 128, 185));
                selectedItemIndex = flp_cart.Controls.IndexOf(lbl.Parent);
            }
        }


        private void frmNewOrder_Load(object sender, EventArgs e)
        {
            Functions.GiveBorder(Tab, this, Color.FromArgb(44, 62, 80));
        }
        private void btnOrderType(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            initOrder(btn);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            /*
             1 - Back to Order Menu

             */

            switch (Convert.ToInt16(((PictureBox)sender).AccessibleName))
            {
                case 1:
                    Tab.SelectTab(0);
                    lblTitle.Text = "Order Menu";
                    break;


                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addItem(Collections.Products.First());
        }




        private void timer1_Tick(object sender, EventArgs e)
        {

            //control the thresholds with message box, so u know when to slow them down
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
            label6.Text = flp_cart.VerticalScroll.Value.ToString();
            flp_cart.PerformLayout();
            flp_cart.Refresh();
        }



        private void btnScroll_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            cartScrollDirection = btn.Text == "▲" ? true : false;
            timer1.Start();
        }

        private void btnScroll_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            coolValue = cartScrollDirection ? flp_cart.VerticalScroll.Value - 50 : flp_cart.VerticalScroll.Value + 50;
            cooler.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedItemIndex == -1)
            {
                MessageBox.Show("You must select an item to add this to...");
            }
            else
            {
                //add discountmod
                //
            }
        }

        private void cooler_Tick(object sender, EventArgs e)
        {

            try
            {
                if (cartScrollDirection)
                {

                    label6.Text = "Cool Value: " + coolValue + Environment.NewLine + "Current Value: " + flp_cart.VerticalScroll.Value;



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
                        cooler.Stop();
                    }
                }

                //cool down
                else
                {
                    label6.Text = "Cool Value: " + coolValue + Environment.NewLine + "Current Value: " + flp_cart.VerticalScroll.Value;


                    
                    if ((coolValue - flp_cart.VerticalScroll.Value) >= 30)
                    {
                        flp_cart.VerticalScroll.Value += 5;
                    }
                    else if ((coolValue - flp_cart.VerticalScroll.Value) >8)
                    {
                        flp_cart.VerticalScroll.Value += 2;
                    }
                    else
                    {
                        cooler.Stop();
                    }
                    
                }
            }
            catch (Exception)
            {
             
            }
        }
    }
}
