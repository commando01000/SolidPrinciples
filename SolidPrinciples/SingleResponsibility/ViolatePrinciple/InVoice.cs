using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibility.ViolatePrinciple
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
    }
}
