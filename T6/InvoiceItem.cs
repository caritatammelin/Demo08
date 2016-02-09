using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class InvoiceItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double Total()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Name + "  " + Price + "e  " + Quantity + "  ";
        }
    }
}
