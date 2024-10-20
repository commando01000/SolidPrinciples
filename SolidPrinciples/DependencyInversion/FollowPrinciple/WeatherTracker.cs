using SolidPrinciples.DependencyInversion.FollowPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion.FollowPrinciple
{
    public class WeatherTracker
    {
        string CurrentCondition;
        INotifier NotifierType;
        public WeatherTracker(INotifier notifier)
        {
            NotifierType = notifier;
        }
        public void SetCurrentCondition(string Condition)
        {
            this.CurrentCondition = Condition;
            if (this.CurrentCondition == "Rainy")
            {
                Console.WriteLine("Raining");
            }
        }
    }
}
