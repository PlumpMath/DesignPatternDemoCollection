using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.VisitorPattern
{
    public class ConcreteElement1 : Element
    {
        public override void doSomething()
        {
            Console.WriteLine("ConcreteElement1 做自己的事情");
        }

        public override void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}