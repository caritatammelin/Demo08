using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice { Customer = "Kirsi Kernell" };
            InvoiceItem milk = new InvoiceItem { Name = "Milk", Price = 2.50, Quantity = 2 };
            InvoiceItem bread = new InvoiceItem { Name = "Bread", Price = 1.90, Quantity = 1 };
            InvoiceItem eggs = new InvoiceItem { Name = "Eggs", Price = 1.50, Quantity = 2 };
            InvoiceItem spices = new InvoiceItem { Name = "Spices", Price = 4.50, Quantity = 1 };
            InvoiceItem butter = new InvoiceItem { Name = "Butter", Price = 2.20, Quantity = 2 };

            invoice.AddItem(milk);
            invoice.AddItem(bread);
            invoice.AddItem(eggs);
            invoice.AddItem(spices);
            invoice.AddItem(butter);

            Console.WriteLine(invoice.ToString());

        }
    }
}
