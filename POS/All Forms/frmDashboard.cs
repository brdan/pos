using POS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        //What's with all the e-commerce, delivery stuff? lel
        public void Index()
        {

            this.Show();
        }


        private void btns_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "LOGOUT":
                    break;
                default:
                    typeof(Router).GetMethod(btn.AccessibleName).Invoke(typeof(Router).GetMethod(btn.AccessibleName), null);
                    Thread.Sleep(50);
                    this.Hide();
                    break;
            }
        }
    }
}
