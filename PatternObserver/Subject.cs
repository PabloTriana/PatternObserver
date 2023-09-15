using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver
{
    public interface Subject
    {
        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notifyObserver();
    }
    public interface Observer
    {
        void update(float temperature, float humidity, float pressure);
    }

    public interface DisplayElement
    {
         void display();
    }
}
