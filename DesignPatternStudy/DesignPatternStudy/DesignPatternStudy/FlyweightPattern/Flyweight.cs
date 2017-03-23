using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.FlyweightPattern
{
    //抽象享元角色
    public abstract class Flyweight
    {
        private string intrinsic;

        protected readonly ExtrinsicState Extrinsic;//外部状态只能被写一次

        public Flyweight(ExtrinsicState Extrinsic)
        {
            this.Extrinsic = Extrinsic;
        }

        public abstract void operate();

        public string getIntrinsic ()
        {
            return intrinsic;
        }

        public void setIntrinsic(string str)
        {
            this.intrinsic = str;
        }
    }
}
