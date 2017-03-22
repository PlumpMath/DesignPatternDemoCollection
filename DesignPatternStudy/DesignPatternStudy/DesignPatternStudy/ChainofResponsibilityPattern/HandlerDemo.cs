using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ChainofResponsbilityPattern
{
public     class HandlerDemo
    {
        public static void main()
        {
            //声明所有处理节点
            Handler handler1 = new ConcreteHandler1();
            Handler handler2 = new ConcreteHandler2();
            Handler handler3 = new ConcreteHandler3();

            //设置链中的阶段顺序 1-->2-->3
            handler1.setNext(handler2);
            handler2.setNext(handler3);

            //提交请求，返回处理
            for (int index = 0; index < 5; index++)
            {
                Response response = handler1.handleMessage(new Request1("测试串啊啊",index));
            }
        }
    }
}
