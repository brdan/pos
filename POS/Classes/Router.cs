using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace POS.Classes
{
    public static class Router
    {
        static frmLogin rLogin = new frmLogin();
        static frmDashboard rDashboard = new frmDashboard();
        static frmCustomers rCustomers = new frmCustomers();
        static frmStock rStock = new frmStock();
        static frmNewOrder rOrder = new frmNewOrder();

        public static void Login()
        {
            rLogin.Index();
        }
        public static void Dashboard()
        {
            rDashboard.Index();
        }
        public static void Customers()
        {
            rCustomers.Index();
        }

        public static void StockManagement()
        {
            rStock.Index();
        }

        public static void NewOrder()
        {
            rOrder.Index();
        }
    }
}