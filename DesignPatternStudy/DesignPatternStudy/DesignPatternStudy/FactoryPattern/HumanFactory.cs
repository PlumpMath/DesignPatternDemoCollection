using System;
 

namespace DesignPatternStudy.FactoryPattern
{
    //工厂方法模式
    public class HumanFactory : AbstractHumanFactory
    {
        public override T createHuman<T>( )
        {
            Human human = null;
            try
            {
                human = (Human)Activator.CreateInstance(typeof(T));
            }
            catch (Exception e)
            {
                Console.WriteLine("excep=" + e.ToString());
            }
            return (T)human;
        }
    }
}
