﻿using POS.Classes;
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

        // Public Functions
        public frmNewOrder Index()
        {
            Tab.SelectTab(0);
            this.Show();
            lblCartTitle.Location = new Point(315, 13);
            return this;
        }
        public void loadCart(Order o)
        {
            Tab.SelectTab("Cart");
            MsgGlobal.Tell("There's no back button here. If you want to return, save the order, or void it.");
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
                    //When the order type goes straight to the cart, like for Bar
                    loadCart(tempOrder);
                    lblTitle.Hide();
                    btnBack.Hide();
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
        public void setCustomer(int ID)
        {
            tempOrder.CustomerID = ID;
        }


        // Private Functions
        /*First and Second are named so because it can contain both Categories & Subcategories
        Whereas the third page can only ever contain products, hence the naming convention*/
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
            List<Category> categories = Collections.Categories.OrderBy(x => x.SortDisplay).ToList();
            List<Product> products = Collections.Products.Where(pr => pr.CategoryID == 0).OrderBy(pr => pr.SortDisplay).ToList();
            List<Subcategory> subcategories = Collections.Subcategories.Where(sc => sc.CategoryID == 0).OrderBy(sc => sc.SortDisplay).ToList();
            if (itemViewMode == 0)
            {
                //The following items belong on the front page of the Item Browser
                #region Category Header + Generation
                foreach (Category c in categories)
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
                    btn.Click += btnFirstPageItems_Click;

                    flp_products.Controls.Add(btn);
                }
                #endregion
                #region Category-less Sub-Category Header + Generation
                foreach (Subcategory sc in subcategories)
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
                    btn.Click += btnFirstPageItems_Click;

                    flp_products.Controls.Add(btn);
                }
                #endregion
                #region Category-and-sub-category-less Product Header + Generation
                foreach (Product pr in products)
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
                    btn.Click += btnProduct_Click;

                    flp_products.Controls.Add(btn);
                }
                #endregion
            }
            else if (itemViewMode == 1)
            {
                #region Category Header + Generation
                //This is list mode, so I need to generate a header, category first!
                #region The header
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
                #endregion

                foreach (Category c in categories)
                {
                    List<IStock> catsChildren = Functions.GetChildren(c);

                    FlowLayoutPanel pnl = new FlowLayoutPanel();
                    pnl.Size = new Size(670, 40);
                    pnl.Margin = new Padding(0, 0, 0, 0);
                    pnl.BackColor = c.Colour;
                    pnl.AutoSize = true;

                    Label lblName = new Label();
                    lblName.Text = c.Name;
                    lblName.Font = new Font("Segoe UI", 10.00f);
                    lblName.ForeColor = Color.Gainsboro;
                    lblName.AccessibleName = c.ID.ToString();
                    lblName.AccessibleDescription = "C";
                    lblName.TextAlign = ContentAlignment.MiddleLeft;
                    lblName.Margin = new Padding(0, 0, 0, 0);
                    lblName.Location = new Point(0, 0);
                    lblName.AutoSize = true;
                    lblName.MinimumSize = new Size(440, 40);
                    lblName.MaximumSize = new Size(440, 0);
                    lblName.Click += btnFirstPageItems_Click;

                    Label lblProd = new Label();
                    lblProd.Font = new Font("Segoe UI", 10.00f);
                    lblProd.ForeColor = Color.Gainsboro;
                    lblProd.Text = catsChildren.OfType<Product>().ToList().Count.ToString();
                    lblProd.TextAlign = ContentAlignment.MiddleCenter;
                    lblProd.Margin = new Padding(0, 0, 0, 0);
                    lblProd.AccessibleName = c.ID.ToString();
                    lblProd.AutoSize = true;
                    lblProd.MinimumSize = new Size(115, 40);
                    lblProd.MaximumSize = new Size(115, 0);
                    lblProd.AccessibleDescription = "C";
                    lblProd.Location = new Point(440, 0);
                    lblProd.Click += btnFirstPageItems_Click;

                    Label lblSc = new Label();
                    lblSc.Font = new Font("Segoe UI", 10.00f);
                    lblSc.ForeColor = Color.Gainsboro;
                    lblSc.Margin = new Padding(0, 0, 0, 0);
                    lblSc.Text = catsChildren.OfType<Subcategory>().ToList().Count.ToString();
                    lblSc.TextAlign = ContentAlignment.MiddleCenter;
                    lblSc.AccessibleName = c.ID.ToString();
                    lblSc.AccessibleDescription = "C";
                    lblSc.Location = new Point(555, 0);
                    lblSc.AutoSize = true;
                    lblSc.MinimumSize = new Size(115, 40);
                    lblSc.MaximumSize = new Size(115, 0);
                    lblSc.Click += btnFirstPageItems_Click;

                    pnl.Controls.Add(lblName);
                    pnl.Controls.Add(lblSc);
                    pnl.Controls.Add(lblProd);

                    flp_products.Controls.Add(pnl);
                }
                #endregion
                #region Category-less Sub-Category Header + Generation

                #region header
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
                #endregion

                foreach (Subcategory sc in subcategories)
                {
                    List<Product> subcatsChildren = Collections.Products.Where(pr => pr.SubcategoryID == sc.ID).ToList();

                    FlowLayoutPanel pnl = new FlowLayoutPanel();
                    pnl.Size = new Size(670, 40);
                    pnl.Margin = new Padding(0, 0, 0, 0);
                    pnl.BackColor = sc.Colour;
                    pnl.AutoSize = true;

                    Label lblName = new Label();
                    lblName.Text = sc.Name;
                    lblName.Font = new Font("Segoe UI", 10.00f);
                    lblName.ForeColor = Color.Gainsboro;
                    lblName.TextAlign = ContentAlignment.MiddleLeft;
                    lblName.AccessibleName = sc.ID.ToString();
                    lblName.AccessibleDescription = "S";
                    lblName.Location = new Point(0, 0);
                    lblName.AutoSize = true;
                    lblName.MinimumSize = new Size(440, 40);
                    lblName.MaximumSize = new Size(440, 0);
                    lblName.Click += btnFirstPageItems_Click;

                    Label lblProd = new Label();
                    lblProd.Font = new Font("Segoe UI", 10.00f);
                    lblProd.ForeColor = Color.Gainsboro;
                    lblProd.Text = subcatsChildren.Count.ToString();
                    lblProd.TextAlign = ContentAlignment.MiddleCenter;
                    lblProd.AccessibleName = sc.ID.ToString();
                    lblProd.AccessibleDescription = "S";
                    lblProd.Location = new Point(440, 0);
                    lblProd.AutoSize = true;
                    lblProd.MinimumSize = new Size(115, 40);
                    lblProd.MaximumSize = new Size(115, 0);
                    lblProd.Click += btnFirstPageItems_Click;

                    Label lblPrice = new Label();
                    lblPrice.Font = new Font("Segoe UI", 10.00f);
                    lblPrice.ForeColor = Color.Gainsboro;
                    lblPrice.Text = sc.CostPrice.ToString();
                    lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                    lblPrice.AccessibleName = sc.ID.ToString();
                    lblPrice.AccessibleDescription = "S";
                    lblPrice.Location = new Point(555, 0);
                    lblPrice.AutoSize = true;
                    lblPrice.MinimumSize = new Size(115, 40);
                    lblPrice.MaximumSize = new Size(115, 0);
                    lblPrice.Click += btnFirstPageItems_Click;

                    pnl.Controls.Add(lblName);
                    pnl.Controls.Add(lblProd);
                    pnl.Controls.Add(lblPrice);

                    flp_products.Controls.Add(pnl);
                }
                #endregion
                #region Category-and-sub-category-less Product Header + Generation
                #region header
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
                #endregion
                foreach (Product pr in products)
                {

                    FlowLayoutPanel pnl = new FlowLayoutPanel();
                    pnl.Size = new Size(670, 40);
                    pnl.Margin = new Padding(0, 0, 0, 0);
                    pnl.BackColor = pr.Colour;
                    pnl.AutoSize = true;

                    Label lblName = new Label();
                    lblName.Text = pr.Name;
                    lblName.Font = new Font("Segoe UI", 10.00f);
                    lblName.ForeColor = Color.Gainsboro;
                    lblName.TextAlign = ContentAlignment.MiddleLeft;
                    lblName.AccessibleName = pr.ID.ToString();
                    lblName.AccessibleDescription = "P";
                    lblName.Location = new Point(0, 0);
                    lblName.AutoSize = true;
                    lblName.MinimumSize = new Size(440, 40);
                    lblName.MaximumSize = new Size(440, 0);

                    lblName.Click += btnProduct_Click;

                    Label lblProd = new Label();
                    lblProd.Font = new Font("Segoe UI", 10.00f);
                    lblProd.ForeColor = Color.Gainsboro;
                    lblProd.Text = pr.InStockQty > 0 ? "Yes" : "No";
                    lblProd.TextAlign = ContentAlignment.MiddleCenter;
                    lblProd.AccessibleName = pr.ID.ToString();
                    lblProd.AccessibleDescription = "P";
                    lblProd.Location = new Point(440, 0);
                    lblProd.AutoSize = true;
                    lblProd.MinimumSize = new Size(115, 40);
                    lblProd.MaximumSize = new Size(115, 0);
                    lblProd.Click += btnProduct_Click;

                    Label lblPrice = new Label();
                    lblPrice.Font = new Font("Segoe UI", 10.00f);
                    lblPrice.ForeColor = Color.Gainsboro;
                    lblPrice.Text = pr.CostPrice.ToString();
                    lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                    lblPrice.AccessibleName = pr.ID.ToString();
                    lblPrice.AccessibleDescription = "P";
                    lblPrice.Location = new Point(555, 0);
                    lblPrice.AutoSize = true;
                    lblPrice.MinimumSize = new Size(115, 40);
                    lblPrice.MaximumSize = new Size(115, 0);
                    lblPrice.Click += btnProduct_Click;

                    pnl.Controls.Add(lblName);
                    pnl.Controls.Add(lblProd);
                    pnl.Controls.Add(lblPrice);

                    flp_products.Controls.Add(pnl);
                }
                #endregion
            }
        }
        void generateSecondPageItems(int parent_id, string type)
        {
            //if P if C if S - add directly, get childs, get childs//..........................................................................................
            switch (type)
            {
                case "C":
                    List<IStock> catChildren = new List<IStock>();
                    Collections.Subcategories.Where(sc => sc.CategoryID == parent_id).ToList().ForEach(sc => catChildren.Add(sc));
                    Collections.Products.Where(pr => pr.CategoryID == parent_id && pr.SubcategoryID == 0).ToList().ForEach(pr => catChildren.Add(pr));

                    flp_products.Controls.Clear();
                    if (itemViewMode == 0)
                    {
                        //The following items belong on the second page of the Item Browser
                        #region Sub-categories belonging to this category
                        foreach (Subcategory sc in catChildren.OfType<Subcategory>().ToList().OrderBy(x => x.SortDisplay))
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
                            btn.Click += btnSecondPageItems_Click;

                            flp_products.Controls.Add(btn);
                        }
                        #endregion
                        #region Products with no Sub-Category, but have this Category assigned to them
                        foreach (Product pr in catChildren.OfType<Product>().ToList().OrderBy(x => x.SortDisplay))
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
                            btn.Click += btnProduct_Click;

                            flp_products.Controls.Add(btn);
                        }
                        #endregion
                    }
                    else if (itemViewMode == 1)
                    {
                        #region Sub-category Header + Generation
                        #region header
                        Panel header = new Panel();
                        header.Margin = new Padding(0, 0, 0, 0);
                        header.Size = new Size(670, 29);

                        Label lblHName = new Label();
                        lblHName.Text = "Sub-Category Name";
                        lblHName.Font = new Font("Segoe UI", 10.00f);
                        lblHName.ForeColor = Color.Gainsboro;
                        lblHName.BackColor = Color.FromArgb(14, 32, 50);
                        lblHName.Size = new Size(440, 29);
                        lblHName.TextAlign = ContentAlignment.MiddleLeft;

                        //subcat count
                        Label lblHProdCount = new Label();
                        lblHProdCount.Text = "Products";
                        lblHProdCount.Font = new Font("Segoe UI", 10.00f);
                        lblHProdCount.ForeColor = Color.Gainsboro;
                        lblHProdCount.BackColor = Color.FromArgb(14, 32, 50);
                        lblHProdCount.Size = new Size(115, 29);
                        lblHProdCount.Location = new Point(440, 0);
                        lblHProdCount.TextAlign = ContentAlignment.MiddleCenter;
                        lblHProdCount.Margin = new Padding(0, 0, 0, 0);

                        //prod count
                        Label lblHPrice = new Label();
                        lblHPrice.Text = "Price (" + Settings.Setting["currency"] + ")";
                        lblHPrice.Font = new Font("Segoe UI", 10.00f);
                        lblHPrice.ForeColor = Color.Gainsboro;
                        lblHPrice.BackColor = Color.FromArgb(14, 32, 50);
                        lblHPrice.Size = new Size(115, 29);
                        lblHPrice.TextAlign = ContentAlignment.MiddleCenter;
                        lblHPrice.Location = new Point(555, 0);
                        lblHPrice.Margin = new Padding(0, 0, 0, 0);

                        header.Controls.Add(lblHName);
                        header.Controls.Add(lblHProdCount);
                        header.Controls.Add(lblHPrice);

                        flp_products.Controls.Add(header);
                        #endregion

                        foreach (Subcategory sc in catChildren.OfType<Subcategory>().ToList().OrderBy(x => x.SortDisplay))
                        {

                            FlowLayoutPanel pnl = new FlowLayoutPanel();
                            pnl.Size = new Size(670, 40);
                            pnl.Margin = new Padding(0, 0, 0, 0);
                            pnl.BackColor = sc.Colour;
                            pnl.AutoSize = true;

                            Label lblName = new Label();
                            lblName.Text = sc.Name;
                            lblName.Font = new Font("Segoe UI", 10.00f);
                            lblName.ForeColor = Color.Gainsboro;
                            lblName.TextAlign = ContentAlignment.MiddleLeft;
                            lblName.AccessibleName = sc.ID.ToString();
                            lblName.AccessibleDescription = "S";
                            lblName.Location = new Point(0, 0);
                            lblName.AutoSize = true;
                            lblName.MinimumSize = new Size(440, 40);
                            lblName.MaximumSize = new Size(440, 0);
                            lblName.Click += btnSecondPageItems_Click;

                            Label lblProd = new Label();
                            lblProd.Font = new Font("Segoe UI", 10.00f);
                            lblProd.ForeColor = Color.Gainsboro;
                            lblProd.Text = Collections.Products.Where(p => p.SubcategoryID == sc.ID).ToList().Count.ToString();
                            lblProd.TextAlign = ContentAlignment.MiddleCenter;
                            lblProd.AccessibleName = sc.ID.ToString();
                            lblProd.AccessibleDescription = "S";
                            lblProd.Location = new Point(440, 0);
                            lblProd.AutoSize = true;
                            lblProd.MinimumSize = new Size(115, 40);
                            lblProd.MaximumSize = new Size(115, 0);
                            lblProd.Click += btnSecondPageItems_Click;

                            Label lblPrice = new Label();
                            lblPrice.Font = new Font("Segoe UI", 10.00f);
                            lblPrice.ForeColor = Color.Gainsboro;
                            lblPrice.Text = sc.CostPrice.ToString();
                            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                            lblPrice.AccessibleName = sc.ID.ToString();
                            lblPrice.AccessibleDescription = "S";
                            lblPrice.Location = new Point(555, 0);
                            lblPrice.AutoSize = true;
                            lblPrice.MinimumSize = new Size(115, 40);
                            lblPrice.MaximumSize = new Size(115, 0);
                            lblPrice.Click += btnSecondPageItems_Click;

                            pnl.Controls.Add(lblName);
                            pnl.Controls.Add(lblProd);
                            pnl.Controls.Add(lblPrice);

                            flp_products.Controls.Add(pnl);
                        }
                        #endregion
                        #region Sub-category-less Product Header + Generation
                        #region header
                        Panel header2 = new Panel();
                        header2.Margin = new Padding(0, 50, 0, 0);
                        header2.Size = new Size(670, 29);

                        Label lblH2Name = new Label();
                        lblH2Name.Text = "Product Name";
                        lblH2Name.Font = new Font("Segoe UI", 10.00f);
                        lblH2Name.ForeColor = Color.Gainsboro;
                        lblH2Name.BackColor = Color.FromArgb(14, 32, 50);
                        lblH2Name.Size = new Size(440, 29);
                        lblH2Name.TextAlign = ContentAlignment.MiddleLeft;

                        //subcat count
                        Label lblH2ProdCount = new Label();
                        lblH2ProdCount.Text = "In Stock";
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
                        #endregion

                        foreach (Product pr in catChildren.OfType<Product>().ToList().OrderBy(x => x.SortDisplay))
                        {

                            FlowLayoutPanel pnl = new FlowLayoutPanel();
                            pnl.Size = new Size(670, 40);
                            pnl.Margin = new Padding(0, 0, 0, 0);
                            pnl.BackColor = pr.Colour;
                            pnl.AutoSize = true;

                            Label lblName = new Label();
                            lblName.Text = pr.Name;
                            lblName.Font = new Font("Segoe UI", 10.00f);
                            lblName.ForeColor = Color.Gainsboro;
                            lblName.TextAlign = ContentAlignment.MiddleLeft;
                            lblName.AccessibleName = pr.ID.ToString();
                            lblName.AccessibleDescription = "P";
                            lblName.Location = new Point(0, 0);
                            lblName.AutoSize = true;
                            lblName.MinimumSize = new Size(440, 40);
                            lblName.MaximumSize = new Size(440, 0);
                            lblName.Click += btnProduct_Click;

                            Label lblProd = new Label();
                            lblProd.Font = new Font("Segoe UI", 10.00f);
                            lblProd.ForeColor = Color.Gainsboro;
                            lblProd.Text = pr.InStockQty > 0 ? "Yes" : "No";
                            lblProd.TextAlign = ContentAlignment.MiddleCenter;
                            lblProd.AccessibleName = pr.ID.ToString();
                            lblProd.AccessibleDescription = "P";
                            lblProd.Location = new Point(440, 0);
                            lblProd.AutoSize = true;
                            lblProd.MinimumSize = new Size(115, 40);
                            lblProd.MaximumSize = new Size(115, 0);
                            lblProd.Click += btnProduct_Click;

                            Label lblPrice = new Label();
                            lblPrice.Font = new Font("Segoe UI", 10.00f);
                            lblPrice.ForeColor = Color.Gainsboro;
                            lblPrice.Text = pr.CostPrice.ToString();
                            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                            lblPrice.AccessibleName = pr.ID.ToString();
                            lblPrice.AccessibleDescription = "P";
                            lblPrice.Location = new Point(555, 0);
                            lblPrice.AutoSize = true;
                            lblPrice.MinimumSize = new Size(115, 40);
                            lblPrice.MaximumSize = new Size(115, 0);
                            lblPrice.Click += btnProduct_Click;

                            pnl.Controls.Add(lblName);
                            pnl.Controls.Add(lblProd);
                            pnl.Controls.Add(lblPrice);

                            flp_products.Controls.Add(pnl);
                        }
                        #endregion
                    }

                    break;

                case "S":
                    List<Product> subcatChildren = Collections.Products.Where(pr => pr.SubcategoryID == parent_id).OrderBy(x => x.SortDisplay).ToList();

                    flp_products.Controls.Clear();
                    if (itemViewMode == 0)
                    {
                        //The following items belong on the second page of the Item Browser
                        #region Products of this Sub-category
                        foreach (Product pr in subcatChildren)
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
                            btn.Click += btnFirstPageItems_Click;

                            flp_products.Controls.Add(btn);
                        }
                        #endregion
                    }
                    else if (itemViewMode == 1)
                    {
                        #region Product Header + Generation
                        #region header
                        Panel header2 = new Panel();
                        header2.Margin = new Padding(0, 0, 0, 0);
                        header2.Size = new Size(670, 29);

                        Label lblH2Name = new Label();
                        lblH2Name.Text = "Product Name";
                        lblH2Name.Font = new Font("Segoe UI", 10.00f);
                        lblH2Name.ForeColor = Color.Gainsboro;
                        lblH2Name.BackColor = Color.FromArgb(14, 32, 50);
                        lblH2Name.Size = new Size(440, 29);
                        lblH2Name.TextAlign = ContentAlignment.MiddleLeft;

                        //subcat count
                        Label lblH2ProdCount = new Label();
                        lblH2ProdCount.Text = "In Stock";
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
                        #endregion

                        foreach (Product pr in subcatChildren)
                        {

                            FlowLayoutPanel pnl = new FlowLayoutPanel();
                            pnl.Size = new Size(670, 40);
                            pnl.Margin = new Padding(0, 0, 0, 0);
                            pnl.BackColor = pr.Colour;
                            pnl.AutoSize = true;


                            Label lblName = new Label();
                            lblName.Text = pr.Name;
                            lblName.Font = new Font("Segoe UI", 10.00f);
                            lblName.ForeColor = Color.Gainsboro;
                            lblName.TextAlign = ContentAlignment.MiddleLeft;
                            lblName.AccessibleName = pr.ID.ToString();
                            lblName.AccessibleDescription = "P";
                            lblName.Location = new Point(0, 0);
                            lblName.AutoSize = true;
                            lblName.MinimumSize = new Size(440, 40);
                            lblName.MaximumSize = new Size(440, 0);
                            lblName.Click += btnProduct_Click;

                            Label lblProd = new Label();
                            lblProd.Font = new Font("Segoe UI", 10.00f);
                            lblProd.ForeColor = Color.Gainsboro;
                            lblProd.Text = pr.InStockQty > 0 ? "Yes" : "No";
                            lblProd.TextAlign = ContentAlignment.MiddleCenter;
                            lblProd.AccessibleName = pr.ID.ToString();
                            lblProd.AccessibleDescription = "P";
                            lblProd.Location = new Point(440, 0);
                            lblProd.AutoSize = true;
                            lblProd.MinimumSize = new Size(115, 40);
                            lblProd.MaximumSize = new Size(115, 0);
                            lblProd.Click += btnProduct_Click;

                            Label lblPrice = new Label();
                            lblPrice.Font = new Font("Segoe UI", 10.00f);
                            lblPrice.ForeColor = Color.Gainsboro;
                            lblPrice.Text = pr.CostPrice.ToString();
                            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                            lblPrice.AccessibleName = pr.ID.ToString();
                            lblPrice.AccessibleDescription = "P";
                            lblPrice.Location = new Point(555, 0);
                            lblPrice.AutoSize = true;
                            lblPrice.MinimumSize = new Size(115, 40);
                            lblPrice.MaximumSize = new Size(115, 0);
                            lblPrice.Click += btnProduct_Click;

                            pnl.Controls.Add(lblName);
                            pnl.Controls.Add(lblProd);
                            pnl.Controls.Add(lblPrice);

                            flp_products.Controls.Add(pnl);
                        }
                        #endregion
                    }

                    break;
                default:
                    break;
            }

        }
        void generateProducts(int subcat_id)
        {
            //these can only be products
            flp_products.Controls.Clear();
            List<Product> products = Collections.Products.Where(x => x.SubcategoryID == subcat_id).OrderBy(x => x.SortDisplay).ToList();

            if (itemViewMode == 0)
            {
                #region Products
                foreach (Product pr in products)
                {
                    Button btn = new Button();

                    btn.Size = new Size(153, 57);
                    btn.Text = pr.Name;
                    btn.UseMnemonic = false;
                    btn.AccessibleName = pr.ID.ToString();
                    btn.Font = new Font("Segoe UI Light", 10.00f);
                    btn.ForeColor = Color.LightGray;
                    btn.BackColor = pr.Colour;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Click += btnProduct_Click;

                    flp_products.Controls.Add(btn);
                }
                #endregion
            }
            else if (itemViewMode == 1)
            {
                #region Product Generation
                #region header

                Panel header = new Panel();
                header.Margin = new Padding(0, 0, 0, 0);
                header.Size = new Size(670, 29);

                Label lblHName = new Label();
                lblHName.Text = "Product Name";
                lblHName.Font = new Font("Segoe UI", 10.00f);
                lblHName.ForeColor = Color.Gainsboro;
                lblHName.BackColor = Color.FromArgb(14, 32, 50);
                lblHName.Size = new Size(440, 29);
                lblHName.TextAlign = ContentAlignment.MiddleLeft;

                //subcat count
                Label lblHProdCount = new Label();
                lblHProdCount.Text = "In Stock";
                lblHProdCount.Font = new Font("Segoe UI", 10.00f);
                lblHProdCount.ForeColor = Color.Gainsboro;
                lblHProdCount.BackColor = Color.FromArgb(14, 32, 50);
                lblHProdCount.Size = new Size(115, 29);
                lblHProdCount.Location = new Point(440, 0);
                lblHProdCount.TextAlign = ContentAlignment.MiddleCenter;
                lblHProdCount.Margin = new Padding(0, 0, 0, 0);

                //prod count
                Label lblHPrice = new Label();
                lblHPrice.Text = "Price (" + Settings.Setting["currency"] + ")";
                lblHPrice.Font = new Font("Segoe UI", 10.00f);
                lblHPrice.ForeColor = Color.Gainsboro;
                lblHPrice.BackColor = Color.FromArgb(14, 32, 50);
                lblHPrice.Size = new Size(115, 29);
                lblHPrice.TextAlign = ContentAlignment.MiddleCenter;
                lblHPrice.Location = new Point(555, 0);
                lblHPrice.Margin = new Padding(0, 0, 0, 0);

                header.Controls.Add(lblHName);
                header.Controls.Add(lblHProdCount);
                header.Controls.Add(lblHPrice);

                flp_products.Controls.Add(header);
                #endregion
                foreach (Product pr in products)
                {

                    FlowLayoutPanel pnl = new FlowLayoutPanel();
                    pnl.Size = new Size(670, 40);
                    pnl.Margin = new Padding(0, 0, 0, 0);
                    pnl.BackColor = pr.Colour;
                    pnl.AutoSize = true;

                    Label lblName = new Label();
                    lblName.Text = pr.Name;
                    lblName.Font = new Font("Segoe UI", 10.00f);
                    lblName.ForeColor = Color.Gainsboro;
                    lblName.TextAlign = ContentAlignment.MiddleLeft;
                    lblName.AccessibleName = pr.ID.ToString();
                    lblName.Location = new Point(0, 0);
                    lblName.AutoSize = true;
                    lblName.MinimumSize = new Size(440, 40);
                    lblName.MaximumSize = new Size(440, 0);
                    lblName.Click += btnProduct_Click;

                    Label lblProd = new Label();
                    lblProd.Font = new Font("Segoe UI", 10.00f);
                    lblProd.ForeColor = Color.Gainsboro;
                    lblProd.Text = pr.InStockQty > 0 ? "Yes" : "No";
                    lblProd.TextAlign = ContentAlignment.MiddleCenter;
                    lblProd.AccessibleName = pr.ID.ToString();
                    lblProd.Location = new Point(440, 0);
                    lblProd.AutoSize = true;
                    lblProd.MinimumSize = new Size(115, 40);
                    lblProd.MaximumSize = new Size(115, 0);
                    lblProd.Click += btnProduct_Click;

                    Label lblPrice = new Label();
                    lblPrice.Font = new Font("Segoe UI", 10.00f);
                    lblPrice.ForeColor = Color.Gainsboro;
                    lblPrice.Text = pr.CostPrice.ToString();
                    lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                    lblPrice.AccessibleName = pr.ID.ToString();
                    lblPrice.Location = new Point(555, 0);
                    lblPrice.AutoSize = true;
                    lblPrice.MinimumSize = new Size(115, 40);
                    lblPrice.MaximumSize = new Size(115, 0);
                    lblPrice.Click += btnProduct_Click;

                    pnl.Controls.Add(lblName);
                    pnl.Controls.Add(lblProd);
                    pnl.Controls.Add(lblPrice);

                    flp_products.Controls.Add(pnl);
                }
                #endregion
            }

        }
        
        // Event handlers
        void btnFirstPageItems_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            generateSecondPageItems(Convert.ToInt32(c.AccessibleName), c.AccessibleDescription);
        }
        void btnSecondPageItems_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            generateProducts(Convert.ToInt32(c.AccessibleName));
        }
        void btnProduct_Click(object sender, EventArgs e)
        {
            CartSystem.AddItem(Collections.Products.Where(pr => pr.ID == Convert.ToInt64(((Control)sender).AccessibleName)).First());
        }
        void frmNewOrder_Load(object sender, EventArgs e)
        {
            Functions.GiveBorder(Tab, Wrapper, Color.FromArgb(44, 62, 80));
            Functions.GiveBorder(OrderTab, Cart, Color.FromArgb(44, 62, 80));
        }
        void btnOrderType(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            initOrder(btn);
        }
        void btnMenu_Click(object sender, EventArgs e)
        {
            try
            {

                switch (((Button)sender).AccessibleName)
                {
                    case "Products":
                        generateFirstPageItems();
                        break;

                    default:
                        break;
                }
                OrderTab.SelectTab(((Button)sender).AccessibleName);
                lblCartTitle.Text = ((Button)sender).AccessibleName.ToUpper();
            }
            catch (Exception)
            {

                throw;
            }
        }
        void button1_Click(object sender, EventArgs e)
        {
            OrderTab.SelectTab(0);
        }
        void productViewMode_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            lblViewMode0.BackColor = Color.FromArgb(24, 42, 60);
            lblViewMode1.BackColor = Color.FromArgb(24, 42, 60);
            lblViewMode2.BackColor = Color.FromArgb(24, 42, 60);

            lbl.BackColor = Color.FromArgb(14, 32, 50);
            itemViewMode = Convert.ToInt16(lbl.AccessibleName);
            generateFirstPageItems();
        }
        void button7_Click(object sender, EventArgs e)
        {
            CartSystem.AddItem(Collections.Products.First());
        }
        void button8_Click(object sender, EventArgs e)
        {
            CartSystem.AddSubItem(false, "Extra Chilli", "00.20");
        }
        void button9_Click(object sender, EventArgs e)
        {
            CartSystem.AddSubItem(true, "Student Discount", "1.00");
        }

        void CartSystem_ItemEdit(object sender, EventArgs e)
        {
            OrderTab.SelectTab("Edit");
            lblCartTitle.Text = "EDIT ITEM";

            //Loading data into edit page
            lblEditQty.Text = CartSystem.GetSelectedItem().Qty;
            txtEditDescription.Text = CartSystem.GetSelectedItem().Description;
            txtEditPrice.Text = CartSystem.GetSelectedItem().Price;

        }
        void CartSystem_ItemDiscount(object sender, EventArgs e)
        {
            lblDiscountIsPercent.Text = "( % )";
            txtDiscountAmount.Parent.Show();
            txtDiscountAmount.Text = "0.00";
            txtDiscountName.Clear();
            OrderTab.SelectTab("Discount");
            lblCartTitle.Text = "DISCOUNT ITEM";
        }
        void CartSystem_ItemModify(object sender, EventArgs e)
        {
            lblModifierIsPercent.Text = "( % )";
            txtModifierAmount.Parent.Show();
            txtModifierAmount.Text = "0.00";
            txtModifierName.Clear();
            OrderTab.SelectTab("Modifier");


            lblCartTitle.Text = "ADD MODIFIER";
        }

        void edit_Qty(object sender, EventArgs e)
        {
            int qty = ((Button)sender).Name.Contains("Down") ? Convert.ToInt16(lblEditQty.Text) - 1 : Convert.ToInt16(lblEditQty.Text) + 1;

            if (qty > 0) //and less than max-qty
            {
                lblEditQty.Text = qty.ToString();
                txtEditPrice.Text = Convert.ToDecimal((Convert.ToInt16(lblEditQty.Text) * Convert.ToDecimal(CartSystem.GetSelectedItem().Price))).ToString(".##");
            }
        }
        void btnEditSave_Click(object sender, EventArgs e)
        {
            CartSystem.EditItem(lblEditQty.Text, txtEditDescription.Text, txtEditPrice.Text);
        }

        void txtDiscountAmount_Click(object sender, EventArgs e)
        {
            lblDiscountIsPercent.Text = lblDiscountIsPercent.Text.Contains("%") ? "( " + Settings.Setting["currency"] + " )" : "( % )";
        }
        void txtModifierAmount_Click(object sender, EventArgs e)
        {
            lblModifierIsPercent.Text = lblModifierIsPercent.Text.Contains("%") ? "( " + Settings.Setting["currency"] + " )" : "( % )";

        }


        void btnDiscountApply_Click(object sender, EventArgs e)
        {
            string name = txtDiscountName.TextLength > 0 ? txtDiscountName.Text : "Unnamed Discount";
            decimal price = txtDiscountAmount.TextLength > 0 ? Convert.ToDecimal(txtDiscountAmount.Text) + 0.00M : 0.00M;

            if (txtDiscountAmount.TextLength == 0)
            {
                Functions.HighlightTextBox(txtDiscountAmount);
            }
            else
            {
                bool isPercent = lblDiscountIsPercent.Text.Contains("%") ? true : false;

                CartSystem.AddSubItem(true, name, price.ToString(), isPercent);
            }
        }

        void btnModifierApply_Click(object sender, EventArgs e)
        {
            string name = txtModifierName.TextLength > 0 ? txtModifierName.Text : "Unnamed Modifier";
            decimal price = txtModifierAmount.TextLength > 0 ? Convert.ToDecimal(txtModifierAmount.Text) : 0.00M;

            if (txtModifierAmount.TextLength == 0)
            {
                Functions.HighlightTextBox(txtModifierAmount);
            }
            else
            {
                bool isPercent = lblModifierIsPercent.Text.Contains("%") ? true : false;

                CartSystem.AddSubItem(false, name, price.ToString(), isPercent);
            }
        }

        void btnBack_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(lblTitle.AccessibleName))
            {
                case 0:
                    Router.Dashboard();
                    System.Threading.Thread.Sleep(50);
                    this.Hide();
                    break;

                case 1:
                    //Back To Order menu 
                    Tab.SelectTab("OrderType");
                    lblTitle.Text = "Dashboard";
                    lblTitle.AccessibleName = "0";
                    Index();
                    break;

                case 2:
                    //Back to Cart Menu
                    Tab.SelectTab("Cart");
                    lblTitle.Hide();
                    btnBack.Hide();

                    break;

                default:
                    MessageBox.Show("All I know is ... that this is supposed to go back somewhere :p");
                    break;
            }
        }

        private void btnSaveQuit_Click(object sender, EventArgs e)
        {
            //just make a huge window that says "Exit to Menu" and "Continue Order"

            if (MessageBox.Show("This order has been saved. Would you like to continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Change tab and show back button
                Tab.SelectTab("Customer");

                btnBack.Show();
                lblTitle.AccessibleName = "2";
                lblTitle.Text = "Cart";
                lblTitle.Show();
            }

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Router.frmCustFromOrder = true;
            Router.Customers();
            
        }
    }
}