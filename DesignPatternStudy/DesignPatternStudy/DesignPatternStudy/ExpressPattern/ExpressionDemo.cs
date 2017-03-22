using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ExpressPattern
{
   public class ExpressionDemo
    {
        public static void main()
        {
            Console.WriteLine("请输入公式:(格式如:a+b-c,注意参数为字符且不要出现重复的，如两个不同的参都叫a，后者将被忽略)");
            string expstr = Console.ReadLine();

            Dictionary<string, int> var = getValue(expstr);
            Calculator cal = new Calculator(expstr);
            Console.WriteLine("运算结果=" + cal.run(var));
        }
         
        public static Dictionary<string,int>getValue(string expStr)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach(char ch in expStr.ToCharArray())
            {
                if (ch !='+' &&ch!='-')
                {
                    if(!map.ContainsKey(""+ch))
                    {
                        Console.WriteLine("请输入参数"+ch);
                        string number = Console.ReadLine();
                        int res = 0;
                        if (int.TryParse(number, out res))
                        {
                            map.Add("" + ch, int.Parse(number));
                        }
                        else
                        {
                            Console.WriteLine("输入不合法，不能换行");
                            break;
                        }
                    }
                }
            }
            return map;
        }
    }
}
