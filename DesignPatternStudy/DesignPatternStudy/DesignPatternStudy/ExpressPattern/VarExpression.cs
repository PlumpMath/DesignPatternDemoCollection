using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ExpressPattern
{
    //变量解释器
    public class VarExpression : Expression
    {
        private string key;
        public VarExpression(string key)
        {
            this.key = key;
        }

        public override int interpreter(Dictionary<string, int> var)
        {
            return var[this.key];
        }
    }
}
