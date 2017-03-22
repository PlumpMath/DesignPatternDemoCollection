using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.IteratorPattern
{
    //场景demo
   public class IteratorDemo
    {
        public static void main()
        {
            Aggregate agg = new ConcreteAggregate();
            agg.add("abc");
            agg.add("aaa");
            agg.add("1234");

            //便利迭代器
            Iterator iterator = agg.iterator();
            while(iterator.hasNext())
            {
                Console.WriteLine("next=" + iterator.next());
            }
        }
    }
}
