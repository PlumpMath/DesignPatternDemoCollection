using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//广告信模板

namespace DesignPatternStudy.ProtoTypePattern
{
    public class AdvTemplete
    {
        private string advSubject = "XX银行信用卡活动";
        private string advContent = "广告内容啊啊啊";

        public string getAdvSubject()
        {
            return this.advSubject;
        }

        public string getAdvContent()
        {
            return this.advContent;
        }
    }
}
