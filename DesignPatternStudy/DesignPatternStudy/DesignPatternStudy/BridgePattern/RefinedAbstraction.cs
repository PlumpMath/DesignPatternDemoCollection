using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.BridgePattern
{
    //具体抽象化角色
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementer imp):base(imp)
        {
        }

        public override void request()
        {
            base.request();
            base.getImp().doAnything();
        }
    }
}
