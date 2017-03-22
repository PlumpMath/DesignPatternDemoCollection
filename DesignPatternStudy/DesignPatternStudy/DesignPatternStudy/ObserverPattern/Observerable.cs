using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ObserverPattern
{
    //被观察者接口
    public interface Observerable
    {
        void addObserver(Observer observer);

        void deleteeObserver(Observer observer);

        void notifyObservers(string context);
    }
}
