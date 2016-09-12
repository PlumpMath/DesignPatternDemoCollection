using System;

namespace DesignPatternStudy.FactoryPattern
{
    public class BlackHuman : Human
    {
        public void getColor()
        {
            Console.WriteLine("黑色人种 皮肤黑色");
        }

        public void talk()
        {
            Console.WriteLine("黑色人种 说的听不懂");
        }
    }
}
