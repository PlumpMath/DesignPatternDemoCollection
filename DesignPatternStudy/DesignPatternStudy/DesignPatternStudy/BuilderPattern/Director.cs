using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.BuilderPattern
{
public     class Director
    {
        private CarBuilder benzBuilder = new BenzBuilder();
        private CarBuilder bmwBuilder = new BMWBuilder();

        public ICar createVBenzSuv()
        {
            return createCar(benzBuilder, "BMW的引擎", "BMW的轮胎");
        }

        //宝马SUV
        public ICar createBMWVan()
        {
            return createCar(benzBuilder, "BMW的引擎", "BMW的轮胎");
        }

        //生产混合车型：注意：如果是基本工厂的话，这一块是做不到的
        public ICar createComplexCar()
        {
            return createCar(bmwBuilder, "BMW的引擎", "benz的轮胎");
        }

        //生产车辆
        private ICar createCar(CarBuilder carBuilder,string engine,string wheel)
        {
            Blueprint bp = new Blueprint();
            bp.setEngine(engine);
            bp.setWheel(wheel);
            Console.WriteLine("获得生产蓝图");
            carBuilder.receiveBlueprint(bp);
            return carBuilder.buildCar();
        }
    }
}
