using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ChainofResponsbilityPattern
{
    //模式相关的框架代码
    //作用：用来封装请求

    public class Request1
    {
        public string testStr = "";
        private Level level = null;

        public Request1(string str,int levelNumber)
        {
            this.testStr = str;
            this.level = new Level();
            this.level.levelNumber = levelNumber;
        }

        public Level getRequestLevel()
        {
            return level;
        }
    }
}
