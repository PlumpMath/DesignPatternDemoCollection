using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.StrategyPattern
{
    public class StrategyDemo
    {
        public static void main()
        {
            //声明具体策略
            Strategy strategy = new ConcreteStrategy();

            //声明上下文对象
            Context context = new Context(strategy);

            context.doAnything();
        }
    }
}
