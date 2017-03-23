using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.BuilderPattern
{
    public class BuilderDemo
    {
        public static void main()
        {
            Director director = new Director();
            Console.WriteLine("准备生产奔驰SUV");
            ICar benzSuv = director.createVBenzSuv();
            Console.WriteLine(benzSuv.ToString());

            //生产宝马
            Console.WriteLine("\n准备生产宝马商务");
            ICar bmwVan = director.createBMWVan();
            Console.WriteLine(bmwVan.ToString());

            //生产混合车型
            Console.WriteLine("\n准备生产混合车");
            ICar complexCar = director.createComplexCar();
            Console.WriteLine(complexCar.ToString());
        }
    }
}
