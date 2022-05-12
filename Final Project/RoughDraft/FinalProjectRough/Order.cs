using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectRough
{
    public class Order
    {
        public double TotalDue { get; set; }
        public double TotalPaid { get; set; }
        public bool IsPaid { get; set; }
        public bool PaymentInProgress { get; set; }
        public bool CouponApplied { get; set; }
    }
}
