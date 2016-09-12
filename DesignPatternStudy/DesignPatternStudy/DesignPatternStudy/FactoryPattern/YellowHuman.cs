using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.FactoryPattern
{
    public class YellowHumancs : Human
    {
        public void getColor()
        {
            Console.WriteLine("黄色人种 皮肤黄色");
        }

        public void talk()
        {
            Console.WriteLine("黄色人种 说双字节");
        }
    }
}