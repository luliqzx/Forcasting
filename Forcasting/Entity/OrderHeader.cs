using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forcasting.Entity
{
    public class OrderHeader
    {
        public string OrderID { get; set; }
        public string OrderDate { get; set; }
        public string CustID { get; set; }
        public string CustName { get; set; }
        public decimal NetValue { get; set; }
    }
}
