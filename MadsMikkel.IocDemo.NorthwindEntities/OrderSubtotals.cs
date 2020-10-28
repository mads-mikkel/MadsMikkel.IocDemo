using System;
using System.Collections.Generic;

namespace MadsMikkel.IocDemo.NorthwindEntities
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
