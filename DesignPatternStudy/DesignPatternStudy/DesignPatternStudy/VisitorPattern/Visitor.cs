using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.VisitorPattern
{
    public class Visitor : IVisitor
    {
        public void visit(ConcreteElement1 el1)
        {
            Console.WriteLine("观察第一个");
            el1.doSomething();
        }

        public void visit(ConcreteElement2 el2)
        {
            Console.WriteLine("观察第二个");
            el2.doSomething();
        }
    }
}
