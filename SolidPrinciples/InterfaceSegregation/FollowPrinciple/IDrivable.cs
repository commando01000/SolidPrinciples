using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation.FollowPrinciple
{
    public interface IDrivable
    {
        public void StartEngine();
        public void StopEngine();
        public void Drive();
    }
}
