using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.StatePattern
{
    public class Context
    {
        public const int STATE2 = 2;

        private int curstate;

        public void setCurrentState(int state)
        {
            curstate = state;
        }

        public void handle2()
        {

        }
    }
}
