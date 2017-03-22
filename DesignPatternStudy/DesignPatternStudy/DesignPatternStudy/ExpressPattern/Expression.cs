using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ExpressPattern
{
    //抽象表达式类
    public abstract class Expression
    {
        //解析公式和数值，其中var中的key值是公式中的参数，value值是具体数字
        public virtual int interpreter(Dictionary<string, int> var)
        {
            return 0;
        }
    }
}
