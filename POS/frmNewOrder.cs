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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            CartSystem.AddItem(Collections.Products.First());
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            CartSystem.AddDiscount();
        }
    }
}
