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
        int itemViewMode = 0; //0 - Rectangles, 1 - List, 2 - Information Boxes

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
                    //lblTitle.Text = "Creating Order...";
                    // btnBack.AccessibleName = "1";
                    break;

                case 2:
                    break;

                case 3:
                    break;

                default:
                    break;
            }

        }
        void generateFirstPageItems()
        {
            #region Notes
            /* 
             * All of the generated items will be linked to the same click event handler, because they're all first page items
             * and it's better for performance if they're distinguished later on, instead of having 3 separate event handlers
             * their AccessibleDescription properties determine the appropriate response required
             * C - Category (further nesting)
             * S - Sub-Category (further nesting)
             * P - Product (insta-add)
             */
            #endregion

            flp_products.Controls.Clear();
            if (itemViewMode == 0)
            {
                //The following items belong on the front page of the Item Browser
                #region All categories
                foreach (Category c in Collections.Categories.OrderBy(x => x.SortDisplay))
                {
                    Button btn = new Button();

                    btn.Size = new Size(153, 57);
                    btn.Text = c.Name;
                    btn.UseMnemonic = false;
                    btn.AccessibleName = c.ID.ToString();
                    btn.AccessibleDescription = "C";
                    btn.Font = new Font("Segoe UI Light", 10.00f);
                    btn.ForeColor = Color.LightGray;
                    btn.BackColor = c.Colour;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Click += btnCategory_Click;

                    flp_products.Controls.Add(btn);
                }
                #endregion
                #region Sub-categories that do not have any categories (in other words, a category with behaviour)
                foreach (Subcategory sc in Collections.Subcategories.Where(sc => sc.CategoryID == 0).OrderBy(sc => sc.SortDisplay))
                {

                    Button btn = new Button();

                    btn.Size = new Size(153, 57);
                    btn.Text = sc.Name;
                    btn.UseMnemonic = false;
                    btn.AccessibleName = sc.ID.ToString();
                    btn.AccessibleDescription = "S";
                    btn.Font = new Font("Segoe UI Light", 10.00f);
                    btn.ForeColor = Color.LightGray;
                    btn.BackColor = sc.Colour;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Click += btnCategory_Click;

                    flp_products.Controls.Add(btn);
                }
                #endregion
                #region Products with neither categories nor sub-categories (direct add too cart)
                foreach (Product pr in Collections.Products.Where(pr => pr.CategoryID == 0).OrderBy(pr => pr.SortDisplay))
                {
                    Button btn = new Button();

                    btn.Size = new Size(153, 57);
                    btn.Text = pr.Name;
                    btn.UseMnemonic = false;
                    btn.AccessibleName = pr.ID.ToString();
                    btn.AccessibleDescription = "P";
                    btn.Font = new Font("Segoe UI Light", 10.00f);
                    btn.ForeColor = Color.LightGray;
                    btn.BackColor = pr.Colour;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Click += btnCategory_Click;

                    flp_products.Controls.Add(btn);
                }
                #endregion
            }
            else if (itemViewMode == 1)
            {
                #region Category Header + Generation
                //This is list mode, so I need to generate a header, category first!
                Panel header = new Panel();
                header.Margin = new Padding(0, 0, 0, 0);
                header.Size = new Size(670, 29);

                //name
                Label lblHName = new Label();
                lblHName.Text = "Category Name";
                lblHName.Font = new Font("Segoe UI", 10.00f);
                lblHName.ForeColor = Color.Gainsboro;
                lblHName.BackColor = Color.FromArgb(14, 32, 50);
                lblHName.Size = new Size(440, 29);
                lblHName.TextAlign = ContentAlignment.MiddleLeft;
                lblHName.Location = new Point(0, 0);

                //prod count
                Label lblHProdCount = new Label();
                lblHProdCount.Text = "Products";
                lblHProdCount.Font = new Font("Segoe UI", 10.00f);
                lblHProdCount.ForeColor = Color.Gainsboro;
                lblHProdCount.BackColor = Color.FromArgb(14, 32, 50);
                lblHProdCount.Size = new Size(115, 29);
                lblHProdCount.TextAlign = ContentAlignment.MiddleCenter;
                lblHProdCount.Location = new Point(440, 0);
                lblHProdCount.Margin = new Padding(0, 0, 0, 0);

                //subcat count
                Label lblHSubCount = new Label();
                lblHSubCount.Text = "Sub-categories";
                lblHSubCount.Font = new Font("Segoe UI", 10.00f);
                lblHSubCount.ForeColor = Color.Gainsboro;
                lblHSubCount.BackColor = Color.FromArgb(14, 32, 50);
                lblHSubCount.Size = new Size(115, 29);
                lblHSubCount.TextAlign = ContentAlignment.MiddleLeft;
                lblHSubCount.Location = new Point(555, 0);
                lblHSubCount.Margin = new Padding(0, 0, 0, 0);

                header.Controls.Add(lblHName);
                header.Controls.Add(lblHProdCount);
                header.Controls.Add(lblHSubCount);

                flp_products.Controls.Add(header);

                foreach (Category c in Collections.Categories.OrderBy(x => x.SortDisplay))
                {
                    List<IStock> catsChildren = Functions.GetChildren(c);
                    int subCats = 0; int prods = 0;
                    foreach (IStock child in catsChildren)
                    {
                        if (child is Subcategory)
                            subCats++;
                        else if (child is Product)
                            prods++;
                    }

                    Panel pnl = new Panel();
                    pnl.Size = new Size(670, 40);
                    pnl.Margin = new Padding(0, 0, 0, 0);
                    pnl.BackColor = c.Colour;

                    Label lblName = new Label();
                    lblName.Text = c.Name;
                    lblName.Font = new Font("Segoe UI", 10.00f);
                    lblName.ForeColor = Color.Gainsboro;
                    lblName.TextAlign = ContentAlignment.MiddleLeft;
                    lblName.AccessibleName = c.ID.ToString();
                    lblName.AccessibleDescription = "S";
                    lblName.Location = new Point(0, 0);
                    lblName.MinimumSize = new Size(440, 40);
                    lblName.MaximumSize = new Size(440, 0);
                    lblName.AutoSize = false;
                    lblName.Click += btnCategory_Click;

                    Label lblProd = new Label();
                    lblProd.Font = new Font("Segoe UI", 10.00f);
                    lblProd.ForeColor = Color.Gainsboro;
                    lblProd.Text = prods.ToString();
                    lblProd.TextAlign = ContentAlignment.MiddleCenter;
                    lblProd.AccessibleName = c.ID.ToString();
                    lblProd.AccessibleDescription = "S";
                    lblProd.Location = new Point(440, 0);
                    lblProd.Size = new Size(115, 40);
                    lblProd.Click += btnCategory_Click;

                    Label lblSc = new Label();
                    lblSc.Font = new Font("Segoe UI", 10.00f);
                    lblSc.ForeColor = Color.Gainsboro;
                    lblSc.Text = subCats.ToString();
                    lblSc.TextAlign = ContentAlignment.MiddleCenter;
                    lblSc.AccessibleName = c.ID.ToString();
                    lblSc.Location = new Point(555, 0);
                    lblSc.Size = new Size(115, 40);
                    lblSc.Click += btnCategory_Click;

                    pnl.Controls.Add(lblName);
                    pnl.Controls.Add(lblSc);
                    pnl.Controls.Add(lblProd);

                    flp_products.Controls.Add(pnl);
                }
                #endregion
                #region Category-less Sub-Category Header + Generation
                Panel header2 = new Panel();
                header2.Margin = new Padding(0, 50, 0, 0);
                header2.Size = new Size(670, 29);

                Label lblH2Name = new Label();
                lblH2Name.Text = "Sub-Category Name";
                lblH2Name.Font = new Font("Segoe UI", 10.00f);
                lblH2Name.ForeColor = Color.Gainsboro;
                lblH2Name.BackColor = Color.FromArgb(14, 32, 50);
                lblH2Name.Size = new Size(440, 29);
                lblH2Name.TextAlign = ContentAlignment.MiddleLeft;

                //subcat count
                Label lblH2ProdCount = new Label();
                lblH2ProdCount.Text = "Products";
                lblH2ProdCount.Font = new Font("Segoe UI", 10.00f);
                lblH2ProdCount.ForeColor = Color.Gainsboro;
                lblH2ProdCount.BackColor = Color.FromArgb(14, 32, 50);
                lblH2ProdCount.Size = new Size(115, 29);
                lblH2ProdCount.Location = new Point(440, 0);
                lblH2ProdCount.TextAlign = ContentAlignment.MiddleCenter;
                lblH2ProdCount.Margin = new Padding(0, 0, 0, 0);

                //prod count
                Label lblH2Price = new Label();
                lblH2Price.Text = "Price (" + Settings.Setting["currency"] + ")";
                lblH2Price.Font = new Font("Segoe UI", 10.00f);
                lblH2Price.ForeColor = Color.Gainsboro;
                lblH2Price.BackColor = Color.FromArgb(14, 32, 50);
                lblH2Price.Size = new Size(115, 29);
                lblH2Price.TextAlign = ContentAlignment.MiddleCenter;
                lblH2Price.Location = new Point(555, 0);
                lblH2Price.Margin = new Padding(0, 0, 0, 0);

                header2.Controls.Add(lblH2Name);
                header2.Controls.Add(lblH2ProdCount);
                header2.Controls.Add(lblH2Price);

                flp_products.Controls.Add(header2);

                foreach (Subcategory sc in Collections.Subcategories.Where(sc => sc.CategoryID == 0).OrderBy(x => x.SortDisplay))
                {
                    List<Product> subcatsChildren = Collections.Products.Where(pr => pr.SubcategoryID == sc.ID).ToList();

                    Panel pnl = new Panel();
                    pnl.Size = new Size(670, 40);
                    pnl.Margin = new Padding(0, 0, 0, 0);
                    pnl.BackColor = sc.Colour;

                    Label lblName = new Label();
                    lblName.Text = sc.Name;
                    lblName.Font = new Font("Segoe UI", 10.00f);
                    lblName.ForeColor = Color.Gainsboro;
                    lblName.TextAlign = ContentAlignment.MiddleLeft;
                    lblName.AccessibleName = sc.ID.ToString();
                    lblName.AccessibleDescription = "S";
                    lblName.Location = new Point(0, 0);
                    lblName.MinimumSize = new Size(440, 40);
                    lblName.MaximumSize = new Size(440, 0);
                    lblName.AutoSize = false;
                    lblName.Click += btnCategory_Click;

                    Label lblProd = new Label();
                    lblProd.Font = new Font("Segoe UI", 10.00f);
                    lblProd.ForeColor = Color.Gainsboro;
                    lblProd.Text = subcatsChildren.Count.ToString();
                    lblProd.TextAlign = ContentAlignment.MiddleCenter;
                    lblProd.AccessibleName = sc.ID.ToString();
                    lblProd.AccessibleDescription = "S";
                    lblProd.Location = new Point(440, 0);
                    lblProd.Size = new Size(115, 40);
                    lblProd.Click += btnCategory_Click;

                    Label lblPrice = new Label();
                    lblPrice.Font = new Font("Segoe UI", 10.00f);
                    lblPrice.ForeColor = Color.Gainsboro;
                    lblPrice.Text = sc.CostPrice.ToString();
                    lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                    lblPrice.AccessibleName = sc.ID.ToString();
                    lblPrice.AccessibleDescription = "S";
                    lblPrice.Location = new Point(555, 0);
                    lblPrice.Size = new Size(115, 40);
                    lblPrice.Click += btnCategory_Click;

                    pnl.Controls.Add(lblName);
                    pnl.Controls.Add(lblProd);
                    pnl.Controls.Add(lblPrice);

                    flp_products.Controls.Add(pnl);
                }
                #endregion
                #region Category-and-sub-category-less Product Header + Generation
                Panel header3 = new Panel();
                header3.Margin = new Padding(0, 50, 0, 0);
                header3.Size = new Size(670, 29);

                Label lblH3Name = new Label();
                lblH3Name.Text = "Product Name";
                lblH3Name.Font = new Font("Segoe UI", 10.00f);
                lblH3Name.ForeColor = Color.Gainsboro;
                lblH3Name.BackColor = Color.FromArgb(14, 32, 50);
                lblH3Name.Size = new Size(440, 29);
                lblH3Name.TextAlign = ContentAlignment.MiddleLeft;

                //subcat count
                Label lblH3ProdCount = new Label();
                lblH3ProdCount.Text = "In Stock";
                lblH3ProdCount.Font = new Font("Segoe UI", 10.00f);
                lblH3ProdCount.ForeColor = Color.Gainsboro;
                lblH3ProdCount.BackColor = Color.FromArgb(14, 32, 50);
                lblH3ProdCount.Size = new Size(115, 29);
                lblH3ProdCount.Location = new Point(440, 0);
                lblH3ProdCount.TextAlign = ContentAlignment.MiddleCenter;
                lblH3ProdCount.Margin = new Padding(0, 0, 0, 0);

                //prod count
                Label lblH3Price = new Label();
                lblH3Price.Text = "Price (" + Settings.Setting["currency"] + ")";
                lblH3Price.Font = new Font("Segoe UI", 10.00f);
                lblH3Price.ForeColor = Color.Gainsboro;
                lblH3Price.BackColor = Color.FromArgb(14, 32, 50);
                lblH3Price.Size = new Size(115, 29);
                lblH3Price.TextAlign = ContentAlignment.MiddleCenter;
                lblH3Price.Location = new Point(555, 0);
                lblH3Price.Margin = new Padding(0, 0, 0, 0);

                header3.Controls.Add(lblH3Name);
                header3.Controls.Add(lblH3ProdCount);
                header3.Controls.Add(lblH3Price);

                flp_products.Controls.Add(header3);

                foreach (Product pr in Collections.Products.Where(pr => pr.CategoryID == 0).OrderBy(x => x.SortDisplay))
                {

                    Panel pnl = new Panel();
                    pnl.Size = new Size(670, 40);
                    pnl.Margin = new Padding(0, 0, 0, 0);
                    pnl.BackColor = pr.Colour;

                    Label lblName = new Label();
                    lblName.Text = pr.Name;
                    lblName.Font = new Font("Segoe UI", 10.00f);
                    lblName.ForeColor = Color.Gainsboro;
                    lblName.TextAlign = ContentAlignment.MiddleLeft;
                    lblName.AccessibleName = pr.ID.ToString();
                    lblName.AccessibleDescription = "P";
                    lblName.Location = new Point(0, 0);
                    lblName.MinimumSize = new Size(440, 40);
                    lblName.MaximumSize = new Size(440, 0);
                    lblName.AutoSize = false;
                    lblName.Click += btnCategory_Click;

                    Label lblProd = new Label();
                    lblProd.Font = new Font("Segoe UI", 10.00f);
                    lblProd.ForeColor = Color.Gainsboro;
                    lblProd.Text = pr.InStockQty > 0 ? "Yes" : "No";
                    lblProd.TextAlign = ContentAlignment.MiddleCenter;
                    lblProd.AccessibleName = pr.ID.ToString();
                    lblProd.AccessibleDescription = "P";
                    lblProd.Location = new Point(440, 0);
                    lblProd.Size = new Size(115, 40);
                    lblProd.Click += btnCategory_Click;

                    Label lblPrice = new Label();
                    lblPrice.Font = new Font("Segoe UI", 10.00f);
                    lblPrice.ForeColor = Color.Gainsboro;
                    lblPrice.Text = pr.CostPrice.ToString();
                    lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                    lblPrice.AccessibleName = pr.ID.ToString();
                    lblPrice.AccessibleDescription = "P";
                    lblPrice.Location = new Point(555, 0);
                    lblPrice.Size = new Size(115, 40);
                    lblPrice.Click += btnCategory_Click;

                    pnl.Controls.Add(lblName);
                    pnl.Controls.Add(lblProd);
                    pnl.Controls.Add(lblPrice);

                    flp_products.Controls.Add(pnl);
                }
                #endregion
            }
        }
        void generateCategoryDescendants(int category_id, string type)
        {
            //if P if C if S - add directly, get childs, get childs//..........................................................................................
            List<IStock> children = new List<IStock>();
            Collections.Subcategories.Where(sc => sc.CategoryID == category_id).ToList().ForEach(sc => children.Add(sc));
            Collections.Products.Where(pr => pr.CategoryID == category_id && pr.SubcategoryID == 0).ToList().ForEach(pr => children.Add(pr));
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            generateCategoryDescendants(Convert.ToInt32(c.AccessibleName), c.AccessibleDescription);
        }


        private void frmNewOrder_Load(object sender, EventArgs e)
        {
            Functions.GiveBorder(Tab, this, Color.FromArgb(44, 62, 80));
            Functions.GiveBorder(OrderTab, Cart, Color.FromArgb(44, 62, 80));
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
                    //lblTitle.Text = "Order Menu";
                    break;


                default:
                    break;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).AccessibleName)
            {
                case "Product":
                    generateFirstPageItems();
                    break;

                default:
                    break;
            }
            OrderTab.SelectTab(((Button)sender).AccessibleName);
            lblCartTitle.Text = ((Button)sender).AccessibleName.ToUpper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderTab.SelectTab(0);
        }

        private void productViewMode_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            lblViewMode0.BackColor = Color.FromArgb(24, 42, 60);
            lblViewMode1.BackColor = Color.FromArgb(24, 42, 60);
            lblViewMode2.BackColor = Color.FromArgb(24, 42, 60);

            lbl.BackColor = Color.FromArgb(14, 32, 50);
            itemViewMode = Convert.ToInt16(lbl.AccessibleName);
            generateFirstPageItems();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}