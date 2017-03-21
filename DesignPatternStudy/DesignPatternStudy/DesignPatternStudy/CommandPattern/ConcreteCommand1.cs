using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.CommandPattern
{
    //具体命令类
    public class ConcreteCommand1 : Command
    {
        private Receiver _receiver;

        public ConcreteCommand1(Receiver receiver)
        {
            this._receiver = receiver;
        }

        public override void execute()
        {
            _receiver.doSomething();
        }
    }
}