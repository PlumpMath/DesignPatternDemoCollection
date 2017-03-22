using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.VisitorPattern
{
    //结构对象
    public class ObjectStructure
    {
        public static Element createElement()
        {
            Random random = new Random(100);
            if (random.Next() > 50)
                return new ConcreteElement1();
            else
                return new ConcreteElement2();
        }
    }
}
