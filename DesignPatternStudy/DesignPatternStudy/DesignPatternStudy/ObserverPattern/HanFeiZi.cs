using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ObserverPattern
{
    public class HanFeiZi : Observer, IHanFeiZi
    {
        private List<Observer> observerList = new List<Observer>();

        public void addObserver(Observer observer)
        {
            this.observerList.Add(observer);
        }

        public void deleteObserver(Observer observer)
        {
            this.observerList.Remove(observer);
        }

        public void notifyObservers(string context)
        {
            foreach(Observer observer in observerList)
            {
                observer.update(context);
            }
        }

        public void haveBreakfast()
        {
            Console.WriteLine("吃饭了");
            this.notifyObservers("韩非子吃饭");
        }

        public void haveFun()
        {
            Console.WriteLine("娱乐了");
            this.notifyObservers("韩非子娱乐");
        }
    }
}
