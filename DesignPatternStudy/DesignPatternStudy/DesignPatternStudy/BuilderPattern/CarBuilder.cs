using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.BuilderPattern
{
    //抽象建造者
    public abstract class CarBuilder
    {
        private ICar car;
        //设计蓝图
        private Blueprint bp;

        public Car buildCar()
        {
            return new Car(buildEngine(), buildWheel());
        }

        public void receiveBlueprint(Blueprint bp)
        {
            this.bp = bp;
        }

        protected Blueprint getBlueprint()
        {
            return bp;
        }

        public abstract string buildWheel();
        public abstract string buildEngine();
    }
}
