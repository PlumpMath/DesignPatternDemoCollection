using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.CommandPattern
{
  public   class TestClient
    {
        public static void testFunc()
        {
            //调用者
            Invoker invoker = new Invoker();

            //接收者
            Receiver receiver = new ConcreteReceiver1();

            //定义一个发送给接收者的命令
            Command command = new ConcreteCommand1(receiver);

            //让调用者执行命令
            invoker.setCommand(command);
            invoker.action();
        }
    }
}
