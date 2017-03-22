using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ChainofResponsbilityPattern
{
  public  class ConcreteHandler1 : Handler
    {
        //定义自己的处理逻辑
        protected override Response echo(Request1 request)
        {
            Console.WriteLine("ConcreteHandler1 处理的request=" + request.testStr+",它的level="+request.getRequestLevel().levelNumber);
            return null;
        }

        //设置自己处理级别
        protected override Level getHandlerLevel()
        {
            Level level = new Level();
            level.levelNumber = 1;
            return level;
        }
    }
}
