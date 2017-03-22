using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ObserverPattern
{
    public class Lisi : Observer
    {
        public void update(string str)
        {
            this.reportToQinshihuang(str);
        }

        private void reportToQinshihuang(string reportContext)
        {
            Console.WriteLine("报告，韩非子有新活动=" + reportContext);
        }
    }
}
