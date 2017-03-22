using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.VisitorPattern
{
    //抽象元素
    public abstract class Element
    {
        public virtual void doSomething()
        {
        }

        public virtual void accept(IVisitor visitor)
        {
        }
    }
}
