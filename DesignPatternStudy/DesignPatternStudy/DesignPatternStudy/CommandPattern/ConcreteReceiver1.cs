using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.CommandPattern
{
    public class ConcreteReceiver1 : Receiver
    {
        public override void doSomething()
        {
            Console.WriteLine("ConcreteReceiver1 doSomethinig");
        }
    }
}