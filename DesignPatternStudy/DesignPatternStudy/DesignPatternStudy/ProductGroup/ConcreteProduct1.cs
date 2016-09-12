using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ProductGroup
{
    public class ConcreteProduct1 : Product
    {
        public override void method2()
        {
            Console.WriteLine("ConcreteProduct1的method2");
        }
    }
}
