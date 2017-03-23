using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.BuilderPattern
{
    //奔驰车建造车间
    public class BenzBuilder : CarBuilder
    {
        public override string buildEngine()
        {
            return base.getBlueprint().getEngine();
        }

        public override string buildWheel()
        {
            return base.getBlueprint().getWheel();
        }
    }
}
