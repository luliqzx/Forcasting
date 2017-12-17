using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forcasting.Entity
{
    public class OrderDetail
    {
        public string OrderID { get; set; }
        public int Line { get; set; }
        public string Product { get; set; }
        public string ProductName { get; set; }
        public decimal Qty { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
