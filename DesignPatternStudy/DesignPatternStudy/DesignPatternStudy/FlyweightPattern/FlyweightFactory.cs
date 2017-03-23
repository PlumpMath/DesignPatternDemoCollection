using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.FlyweightPattern
{
    public class FlyweightFactory
    {
        private  static Dictionary<ExtrinsicState, Flyweight> pool = new Dictionary<ExtrinsicState, Flyweight>();

        public static Flyweight getSignInfo(ExtrinsicState key)
        {
            Flyweight flyweight = null;
            foreach(KeyValuePair<ExtrinsicState,Flyweight> pair in pool)
            { 
                if (pair.Key.hashCode() == key.hashCode() && pair.Key.equals(key))
                {
                    flyweight = pool[pair.Key];
                }
            }
            if(flyweight==null)
            {
                flyweight = new ConcreteFlyweight1(key);
                pool[key] = flyweight;
            }
            return flyweight;
        }

        //进化版本，优化索引问题
        public static Flyweight getSignInfobyString(string key)
        {
            Flyweight flyweight = null;
            foreach (KeyValuePair<ExtrinsicState, Flyweight> pair in pool)
            {
                if (pair.Key.hashCode() == key.GetHashCode() && pair.Key.getLocation()== key)
                {
                    flyweight = pool[pair.Key];
                }
            }
            if (flyweight == null)
            {
                ExtrinsicState newState = new ExtrinsicState();
                newState.setSubject(key.Split('.')[0]);
                newState.setLocaltion(key.Split('.')[1]);
                flyweight = new ConcreteFlyweight1(newState);
                pool[newState] = flyweight;
            }
            return flyweight;
        }
    }
}
