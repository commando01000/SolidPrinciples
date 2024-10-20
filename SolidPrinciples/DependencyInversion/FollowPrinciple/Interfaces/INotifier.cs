using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion.FollowPrinciple.Interfaces
{
    public interface INotifier
    {
        void AlertWeatherConditions(string weatherCondition);

    }
}
