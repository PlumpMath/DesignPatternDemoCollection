using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.BridgePattern
{
    public class Abstraction
    {
        private Implementer imp;
        public Abstraction(Implementer imp)
        {
            this.imp = imp;
        }

        //自身行为和属性
        public virtual void request()
        {
            this.imp.doSomething();
        }

        //获得现实化角色
        public Implementer getImp()
        {
            return imp;
        }
    }
}