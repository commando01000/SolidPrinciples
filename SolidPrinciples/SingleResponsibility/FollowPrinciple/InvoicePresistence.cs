using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibility.FollowPrinciple
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
    }
}
