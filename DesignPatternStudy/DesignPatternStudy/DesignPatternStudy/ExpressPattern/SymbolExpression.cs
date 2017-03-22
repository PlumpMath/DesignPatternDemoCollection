using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ExpressPattern
{
    //抽象运算符号解释器
    public class SymbolExpression:Expression
    {
        protected Expression left;
        protected Expression right;

        public SymbolExpression(Expression left,Expression right)
        {
            this.left = left;
            this.right = right;
        }
    }
}
