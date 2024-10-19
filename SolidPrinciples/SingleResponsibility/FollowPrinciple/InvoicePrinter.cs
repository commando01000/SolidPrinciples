using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibility.FollowPrinciple
{
    public class InvoicePrinter
    {
        private static InVoice _invoice;

        public InvoicePrinter(InVoice invoice)
        {
            _invoice = invoice;
        }

        public void PrintInvoice()
        {
            Console.WriteLine("Title: " + _invoice.Book.Title);
            Console.WriteLine("Author: " + _invoice.Book.Author);
            Console.WriteLine("Description: " + _invoice.Book.Description);
            Console.WriteLine("Price: " + _invoice.Book.Price);
            Console.WriteLine("Quantity: " + _invoice.Quantity);
            Console.WriteLine("Discount: " + _invoice.Discount);
            Console.WriteLine("Tax Rate: " + _invoice.TaxRate);
            Console.WriteLine("Total: " + _invoice.Total);
        }
    }
}
