using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.CommandPattern
{
    //通用receiver类
    public class Receiver
    {
        public virtual void doSomething()
        {
            Console.WriteLine("base doSomething");
        }
    }
}