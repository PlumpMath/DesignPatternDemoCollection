using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.StrategyPattern
{
    //具体策略角色
    public class ConcreteStrategy : Strategy
    {
        public override void doSomething()
        {
            Console.WriteLine("具体策略1的运算法则");
        }
    }
}