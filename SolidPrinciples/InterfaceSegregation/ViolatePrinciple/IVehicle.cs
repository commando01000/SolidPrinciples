using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation.ViolatePrinciple
{
    public interface IVehicle
    {
        public void StartEngine();
        public void StopEngine();
        public void Drive();
        public void Fly();
    }
}
