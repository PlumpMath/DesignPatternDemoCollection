using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ExpressPattern
{
    //加法解释器
    public class AddExpression:SymbolExpression
    {
        public AddExpression(Expression left,Expression right):base(left,right)
        {
        }

        public override int interpreter(Dictionary<string,int> var)
        {
            return base.left.interpreter(var) + base.right.interpreter(var);
        }
    }
}
