using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ObserverPattern
{
    public abstract class Observer
    {
        public virtual void update(string context)
        {
            Console.WriteLine("this=" + this + ",context=" + context);
        }
    }
}