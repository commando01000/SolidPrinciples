using SolidPrinciples.OpenClosed.FollowPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosed.FollowPrinciple
{
    public class DatabasePresistence : IInvovicePresistence
    {
        private InVoice _invoice;
        public DatabasePresistence(InVoice invoice)
        {
            _invoice = invoice;
        }
        public void Save(InVoice inVoice)
        {
            Console.WriteLine("Saving invoice to database");
        }
    }
}
