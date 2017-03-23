using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.FlyweightPattern
{
    public class ConcreteFlyweight1 : Flyweight
    {
        public ConcreteFlyweight1(ExtrinsicState Extrinsic):base(Extrinsic)
        { 
        }

        public override void operate()
        {
            //业务逻辑
        }
    }
}
