using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        public void display()
        {
            throw new NotImplementedException();
        }

        public void update(float temperature, float humidity, float pressure)
        {
            throw new NotImplementedException();
        }
    }
}
