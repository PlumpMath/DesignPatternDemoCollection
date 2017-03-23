using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.BuilderPattern
{
    //生产蓝图
    public class Blueprint
    {
        private string wheel;
        private string engine;

        public string getWheel()
        {
            return wheel;
        }

        public void setWheel(string wheel)
        {
            this.wheel = wheel;
        }

        public string getEngine()
        {
            return engine;
        }

        public void setEngine(string engine)
        {
            this.engine = engine;
        }
    }
}
