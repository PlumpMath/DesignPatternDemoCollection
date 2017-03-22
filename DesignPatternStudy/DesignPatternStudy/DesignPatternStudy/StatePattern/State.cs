using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.StatePattern
{
    //抽象环境角色
    public abstract class State
    {
        protected Context context;

        public void setContext(Context context)
        {
            this.context = context;
        }

        public abstract void handle1();
        public abstract void handle2();
    }
}
