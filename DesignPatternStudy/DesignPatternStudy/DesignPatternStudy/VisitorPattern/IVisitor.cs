using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.VisitorPattern
{
    public interface IVisitor
    {
        void visit(ConcreteElement1 ele1);
        void visit(ConcreteElement2 ele1);
    }
}
