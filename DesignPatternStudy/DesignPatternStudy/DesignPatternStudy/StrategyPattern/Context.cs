using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.StrategyPattern
{
    //封装角色
   public  class Context
    {
        private Strategy strategy = null;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void doAnything()
        {
            this.strategy.doSomething();
        }
    }
}
