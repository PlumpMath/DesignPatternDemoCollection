
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.IteratorPattern
{
    //抽象容器
    interface Aggregate
    {
        void add(object obj);

        void remove(object obj);

        Iterator iterator();
    }
}
