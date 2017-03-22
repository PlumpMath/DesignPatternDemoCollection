using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.IteratorPattern
{
    //抽象迭代器
    public interface Iterator
    {
        //遍历到下一个元素
        object next();

        //是否遍历到尾部
        bool hasNext();

        //删除当前指向的元素
        bool remove();
    }
}