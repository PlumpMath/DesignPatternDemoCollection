using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.StatePattern
{
    public class ConcreteState1 : State
    {
        public override void handle1()
        {

        }

        public override void handle2()
        {
            base.context.setCurrentState(Context.STATE2);
            base.context.handle2();
        }
    }
}
