using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion.ViolatePrinciple
{
    public class WeatherTracker
    {
        string currentCondition;
        Emailer emailer;
        public WeatherTracker()
        {
            emailer = new Emailer();
        }
        public void SetCurrentCondition(string condition)
        {
            currentCondition = condition;
            if (currentCondition == "cold")
            {
                emailer.SendEmail("It's cold outside");
            }
        }
        public string GetCurrentCondition()
        {
            return "";
        }
    }
}
