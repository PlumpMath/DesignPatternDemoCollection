using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.CommandPattern
{
    //调用者类
    public class Invoker
    {
        private Command _command;
        public void setCommand(Command command)
        {
            this._command = command;
        }

        public void action()
        {
            _command.execute();
        }
    }
}
