using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace POS.Classes
{
    public static class Functions
    {
        //Graphics 
        public static async void HighlightTextBox(TextBox txt)
        {
            SolidBrush myBrush = new SolidBrush(Color.Red);
            Graphics formGraphics;
            formGraphics = txt.Parent.Parent.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(txt.Parent.Location.X - 1, txt.Parent.Location.Y - 1, txt.Parent.Width + 2, txt.Parent.Height + 2));
            await Task.Delay(3000);
            txt.Parent.Parent.Invalidate();

        }
        public static void GiveBorder(TabControl p, Control c, Color f)
        {
            //Left
            Color rgb = f;
            Panel pnlLeft = new Panel();
            pnlLeft.BackColor = rgb;
            pnlLeft.Size = new Size(5, p.Height);
            pnlLeft.Location = new Point(p.Location.X, p.Location.Y);
            c.Controls.Add(pnlLeft);
            pnlLeft.BringToFront();

            //Top
            Panel pnlTop = new Panel();
            pnlTop.BackColor = rgb;
            pnlTop.Size = new Size(p.Width, 22);
            pnlTop.Location = new Point(p.Location.X, p.Location.Y);
            c.Controls.Add(pnlTop);
            pnlTop.BringToFront();

            //Right
            Panel pnlRight = new Panel();
            pnlRight.BackColor = rgb;
            pnlRight.Size = new Size(5, p.Height);
            pnlRight.Location = new Point(p.Location.X + p.Width - 5, p.Location.Y);
            c.Controls.Add(pnlRight);
            pnlRight.BringToFront();

            //Bottom
            Panel pnlBottom = new Panel();
            pnlBottom.BackColor = rgb;
            pnlBottom.Size = new Size(p.Width, 5);
            pnlBottom.Location = new Point(p.Location.X, p.Location.Y + p.Height - 5);
            c.Controls.Add(pnlBottom);
            pnlBottom.BringToFront();
        }
        public static void RoundifyPBX(ref PictureBox p)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, p.Width - 3, p.Height - 3);
            Region rg = new Region(gp);
            p.Region = rg;
        }
        public static byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public static void DisableTextBox(TextBox txt)
        {
        
        }

        // Utilities
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
        public static void MouseEnter_Effect(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (!(c is Panel))
                c = c.Parent;
            c.BackColor = Color.FromArgb(14, 32, 50);
        }
        public static void MouseLeave_Effect(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (!(c is Panel))
                c = c.Parent;
            c.BackColor = Color.FromArgb(24, 42, 60);
        }
        public static IStock GetParent(IStock stock, bool deep = false)
        {
            IStock toReturn = null;
            if (stock.GetType() == typeof(Product) || stock.GetType() == typeof(Subcategory))
            {
                if (stock.GetType() == typeof(Subcategory))
                {
                    toReturn = Collections.Categories.Where(c => c.ID.ToString() == GetPropValue(stock, "CategoryID").ToString()).ToList().Count > 0 ? Collections.Categories.First(c => c.ID.ToString() == GetPropValue(stock, "CategoryID").ToString()) : null;
                }
                else if (stock.GetType() == typeof(Product))
                {
                    if (deep)
                    {
                        toReturn = Collections.Categories.Where(c => c.ID.ToString() == GetPropValue(stock, "CategoryID").ToString()).ToList().Count > 0 ? Collections.Categories.First(c => c.ID.ToString() == GetPropValue(stock, "CategoryID").ToString()) : null;
                    }
                    else
                    {
                        toReturn = Collections.Subcategories.Where(sc => sc.ID.ToString() == GetPropValue(stock, "SubCategoryID").ToString()).ToList().Count > 0 ? Collections.Subcategories.First(sc => sc.ID.ToString() == GetPropValue(stock, "SubcategoryID").ToString()) : null;
                    }
                }
            }
           
            return toReturn;
        }
        public static List<IStock> GetChildren(IStock c)
        {
            List<IStock> children = new List<IStock>();
            if (c is Category)
            {
                foreach (Subcategory sc in Collections.Subcategories.Where(x => x.CategoryID == c.ID))
                    children.Add(sc);

                foreach (Product pr in Collections.Products.Where(x => x.CategoryID == c.ID))
                    children.Add(pr);
        
            }
            else if (c is Subcategory)
            {
                foreach (Product pr in Collections.Products.Where(x => x.SubcategoryID == c.ID))
                    children.Add(pr);
            }
            return children;
        }
        public static string Price(decimal p)
        {

            return Math.Round(p, 2).ToString("00.00");
        }

        //Verifiers 
        public static bool VerifyUserUPass(string Username, string Password)
        {
            
            return true;
        }
        public static bool VerifyUserCard(string CardString)
        {

            return true;
        }
        public static User VerifyUserPIN(int pin)
        {
            User user = new User();
            try
            {
                user = Collections.Users.First(u => u.PIN == pin);
            }
            catch (Exception)
            {
                //MessageBox.Show("User not verified properly."); doing this on the view-level
            }
            return user;
        }
        public static void Hi()
        {

        }

        //String Modifiers
        public static string VerifyEmpty(string str)
        {
            if (str.Length <= 0)
                return "N/A";
            else
                return str;
        }
        public static Dictionary<string,string> ToList(string str)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            string[] modifiers = str.Split('^');
            foreach(string modifierPair in modifiers)
            {
                string key = modifierPair.Substring(0, modifierPair.IndexOf('@'));
                string value = modifierPair.Substring(key.Length + 1, modifierPair.Length - (key.Length + 1));
                dict.Add(key, value);
            }
            return dict;
        }


    }
}
