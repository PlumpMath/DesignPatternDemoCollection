using DesignPatternStudy.FactoryPattern;
using DesignPatternStudy.FactoryPattern.FactoryMulti;
using DesignPatternStudy.ProductGroup;
using System;

namespace DesignPatternStudy
{
    public  class Program
    {
        static void Main(string[] args)
        {
            //抽象工厂
            // CreateHumanTest();

            //简单抽线工厂
            //CreateHumanSimple();

            //多个工厂模式
            // CreateMultiFactory();

            //工厂实现单例
            //SingletonFactory.getSingleton() .doSomeThing();

            //工厂用作缓存对象
            FactoryCacheTest();

            //Console.WriteLine("time=" + DateTime.Now.Ticks);
            //Creator creator = new ConcreteCreator();
            //Product product = creator.createProduct< ConcreteProduct1>();
            //product.method2();

            //Console.WriteLine("time=" + DateTime.Now.Ticks);

            Console.ReadLine();
        }

        private static void FactoryCacheTest()
        {
            Product p1 = ProductFactoryDelay.createProduct(typeof(ConcreteProduct1).Name);
            Product p2 = ProductFactoryDelay.createProduct(typeof(ConcreteProduct2).Name);
            p1.method2();
            p2.method2();
            Product p3 = ProductFactoryDelay.createProduct(typeof(ConcreteProduct2).Name);
            p3.method2();
        }

        private static void CreateMultiFactory()
        {
            Human yellow1 = (new HumanYellowFactory()).createHuman();
            yellow1.talk();

            Human black = (new BlackHumanFactory()).createHuman();
            black.talk();
        }

        private static void CreateHumanSimple()
        {
            Human human = HumanFactorySimple.createHuman<WhiteHuman>();
            human.talk();
        }

        private static void CreateHumanTest()
        {
            AbstractHumanFactory yinyanglu = new HumanFactory();
            Human whiteHuman = yinyanglu.createHuman<WhiteHuman>();
            whiteHuman.getColor();
            whiteHuman.talk();

            Human blackHuman = yinyanglu.createHuman<BlackHuman>();
            blackHuman.getColor();
            blackHuman.talk();

            Human yellowHuman = yinyanglu.createHuman<YellowHuman>();
            yellowHuman.getColor();
            yellowHuman.talk();
             
            //注意：yinyanglu已经限制为人Human及子类型，TestDeleteClass普通类实例化会报错
            //yinyanglu.createHuman<TestDeleteClass>();
        }
    }
}
