using SolidPrinciples.DependencyInversion.FollowPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion.FollowPrinciple
{
    public class Emailer : INotifier
    {
        public void AlertWeatherConditions(string weatherCondition)
        {
            throw new NotImplementedException();
        }
    }
}
