using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ObserverPattern
{
  public  class ObserverDemo
    {
        public static void main()
        {
            //一个观察者
            Observer lisi = new Lisi();

            //被观察者
            HanFeiZi hanFeiZi = new HanFeiZi();
            hanFeiZi.addObserver(lisi);

            hanFeiZi.haveBreakfast();
        }
    }
}
