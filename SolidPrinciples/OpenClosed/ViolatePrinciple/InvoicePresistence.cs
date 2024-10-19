using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosed.ViolatePrinciple
{
    public class InvoicePresistence
    {
        private InVoice _invoice;
        public InvoicePresistence(InVoice invoice)
        {
            _invoice = invoice;
        }

        public void SaveToFile(string FileName)
        {
            Console.WriteLine("Saving invoice to file: " + FileName);
        }
        public void SaveToDatabase(string DBName)
        {
            Console.WriteLine("Saving invoice to DB: " + DBName);
        }
    }
}
