using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.BridgePattern
{
    //现实化角色
    public interface Implementer
    {
        void doSomething();
        void doAnything();
    }
}
