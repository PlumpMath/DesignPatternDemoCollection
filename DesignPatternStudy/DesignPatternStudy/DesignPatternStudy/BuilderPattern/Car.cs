using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.BuilderPattern
{
    //具体车辆
    public class Car : ICar
    {
        private string engine;
        private string wheel;

        public Car(string engine, string wheel)
        {
            this.engine = engine;
            this.wheel = wheel;
        }

        public string getEngine()
        {
            return engine;
        }

        public string getWheel()
        {
            return wheel;
        }

        public override string ToString()
        {  
            return "车轮子是：" + wheel + "\n车的引擎是：" + engine;
        }
    }
}
