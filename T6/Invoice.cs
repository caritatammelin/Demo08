using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Invoice
    {
        public string Customer { get; set; }
        public List<InvoiceItem> Items { get; }

        public Invoice()
        {
            Items = new List<InvoiceItem>();
        }

        public void AddItem(InvoiceItem item)
        {
            Items.Add(item);
        }

        public override string ToString()
        {
            string sInvoice = "Customer " + Customer + "'s Invoice\n";
            foreach (InvoiceItem item in Items)
            {
                sInvoice += item.ToString() + "\n";
            }
            return sInvoice;
        }

        public void PrintInvoice()
        {
            Console.WriteLine("Invoice: ");
            foreach (InvoiceItem item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}
