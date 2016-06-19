﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace POS.Classes
{
    public class Order
    {
        //customer_id,order_type, amount_of_guests,visit_date,order_status,employee_id,table_id,total_price,total_paid
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string OrderType { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderStatus { get; set; }
        public int EmployeeID { get; set; }
        public int TableID { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalPaid { get; set; }
        public string Notes { get; set; }
        public Dictionary<string,string> Discounts { get; set; }
    }

    public class OrderItem
    {
        public int ID { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; }
        public Dictionary<string, string> Modifiers = new Dictionary<string, string>();
        public Dictionary<string, string> Discounts = new Dictionary<string, string>();
        public decimal ItemPrice { get; set; }

    }

    public class Cart
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public List<OrderItem> Items;
    }
}