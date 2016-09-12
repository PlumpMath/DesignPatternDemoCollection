using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.FactoryPattern
{
    //简单工厂模式！
    public class HumanFactorySimple
    {
        //不用实例工厂，直接用static
        public static T createHuman<T>()
        {
            Human human = null;
            try
            {
                human = (Human)Activator.CreateInstance<T>();
            }
            catch (Exception e)
            {
                Console.WriteLine("e=" + e.ToString());
            }
            return (T)human;
        }
    }
}