using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.CommandPattern
{
    public class ConcreteReceiver2 : Receiver
    {
        public override void doSomething()
        {
            Console.WriteLine("ConcreteReceiver2 doSomethinig");
        }
    }
}
