using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.CommandPattern
{
    public class ConcreteCommand2 : Command
    {
        private Receiver _receiver;

        public ConcreteCommand2(Receiver receiver)
        {
            this._receiver = receiver;
        }

        public override void execute()
        {
            _receiver.doSomething();
        }
    }
}