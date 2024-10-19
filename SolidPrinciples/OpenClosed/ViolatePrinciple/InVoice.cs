using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosed.ViolatePrinciple
{
    public class InVoice
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public double TaxRate { get; set; }

        public double Total
        {
            get
            {
                return Book.Price * Quantity * (1 - Discount) * (1 + TaxRate);
            }
        }
        public void PrintInvoice()
        {
            Console.WriteLine("Title: " + Book.Title);
            Console.WriteLine("Author: " + Book.Author);
            Console.WriteLine("Description: " + Book.Description);
            Console.WriteLine("Price: " + Book.Price);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Discount: " + Discount);
            Console.WriteLine("Tax Rate: " + TaxRate);
            Console.WriteLine("Total: " + Total);
        }

        public void SaveToFile(string FileName)
        {
            Console.WriteLine("Saving invoice to file: " + FileName);
        }
    }
}
