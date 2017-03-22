using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.StrategyPattern
{
    public class ConcreteStrategy2 : Strategy
    {
        public override void doSomething()
        {
            Console.WriteLine("具体策略2的运算法则");
        }
    }
}