using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ExpressPattern
{
    //解释器封装类
public class Calculator
    {
        private Expression expression;
        public Calculator(string expStr)
        {
            Stack<Expression> stack = new Stack<Expression>();
            char[] charArray = expStr.ToCharArray();
            Expression left = null;
            Expression right = null;
            for(int index=0;index<charArray.Length;index++)
            {
                switch(charArray[index])
                {
                    case '+':
                        left = stack.Pop();
                        right = new VarExpression("" + charArray[++index]);
                        stack.Push(new AddExpression(left, right));
                        break;
                    case '-':
                        left = stack.Pop();
                        right = new VarExpression("" + charArray[++index]);
                        stack.Push(new SubExpression(left, right));
                        break;
                    default:
                        stack.Push(new VarExpression("" + charArray[index]));
                        break;
                }
            }
            this.expression = stack.Pop();
        }

        public int run(Dictionary<string,int> var)
        {
            return this.expression.interpreter(var);
        }
    }
}
