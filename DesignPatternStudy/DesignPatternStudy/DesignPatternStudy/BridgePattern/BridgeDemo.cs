using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.BridgePattern
{
    public class BridgeDemo
    {
        public static void main()
        {
            //实现化角色
            Implementer imp = new ConcreteImplementer1();
            //抽象化角色
            Abstraction abs = new RefinedAbstraction(imp);
            abs.request();
        }
    }
}
