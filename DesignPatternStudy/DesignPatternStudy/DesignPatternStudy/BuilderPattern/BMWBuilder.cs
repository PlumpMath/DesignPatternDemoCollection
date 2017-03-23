using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.BuilderPattern
{
    //宝马车建造车间
    public class BMWBuilder : CarBuilder
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
