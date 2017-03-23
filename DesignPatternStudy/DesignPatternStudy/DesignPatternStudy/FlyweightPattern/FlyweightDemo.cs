using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.FlyweightPattern
{
    public class FlyweightDemo
    {
        public static void main()
        {
            ExtrinsicState state1 = new ExtrinsicState();
            state1.setSubject("科目1");
            state1.setLocaltion("上海");

            ExtrinsicState state2 = new ExtrinsicState();
            state2.setSubject("科目1");
            state2.setLocaltion("上海");

            FlyweightFactory.getSignInfo(state1);
            FlyweightFactory.getSignInfo(state2);

            SignInfoFactory.getSignInfobyString(state1.getSubjectandLocation());
            SignInfoFactory.getSignInfobyString(state2.getSubjectandLocation());
            
            //第一个版本，直接用ExtrinsicState结构作为索引的时候
            long time = System.DateTime.Now.Ticks;
            for (int index = 0; index < 10000000; index++)
            {
                FlyweightFactory.getSignInfo(state2);
            }
            long curtime = System.DateTime.Now.Ticks;
            Console.WriteLine("直接用ExtrinsicState结构作为索引的时候 执行时间=" + (curtime - time) + "ticks"+",startTime="+time+",endTime="+curtime);

            //第二个版本，用string作为索引的时候
            long time2 = System.DateTime.Now.Ticks;
            string strKey = state2.getSubject() + "." + state2.getLocation();
            for (int index = 0; index < 10000000; index++)
            {
                SignInfoFactory.getSignInfobyString(strKey);
            }
            long curtime2 = System.DateTime.Now.Ticks;
            Console.WriteLine("用string作为索引的时候 执行时间=" + (curtime2 - time2) + "ticks" + ",startTime=" + time2 + ",endTime=" + curtime2);
        }
    }
}
