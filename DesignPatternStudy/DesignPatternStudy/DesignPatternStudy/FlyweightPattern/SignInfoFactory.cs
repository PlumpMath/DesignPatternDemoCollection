using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.FlyweightPattern
{
    public class SignInfoFactory
    {
        private static Dictionary<string, Flyweight> pool = new Dictionary<string, Flyweight>();

        //进化版本，优化索引问题
        public static Flyweight getSignInfobyString(string strKey)
        {
            Flyweight flyweight = null;
            foreach (KeyValuePair<string, Flyweight> pair in pool)
            {
                if (pair.Key.GetHashCode() == strKey.GetHashCode() && pair.Key == strKey)
                {
                    flyweight = pool[strKey];
                }
            }
            if (flyweight == null)
            {
                pool[strKey] = flyweight;
            }
            return flyweight;
        }
    }
}