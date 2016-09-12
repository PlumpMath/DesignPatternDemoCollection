using System;

namespace DesignPatternStudy.FactoryPattern
{
    public class WhiteHuman : Human
    {
        public void getColor()
        {
            Console.WriteLine("白色人种 皮肤白色");
        }

        public void talk()
        {
            Console.WriteLine("白色人种 说单字节");
        }
    }
}
