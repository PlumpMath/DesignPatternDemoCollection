using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.FlyweightPattern
{
    //外部状态类
    public class ExtrinsicState
    {
        private string subject;
        private string location;

        public string subjectandLocaltion; //为用优化索引
        public string getSubject()
        {
            return subject;
        }

        public void setSubject(string subject)
        {
            this.subject = subject;
            subjectandLocaltion = this.subject + "." + this.location;
        }

        public string getLocation()
        {
            return location;
        }

        public void setLocaltion(string location)
        {
            this.location = location;
            subjectandLocaltion = this.subject + "." + this.location;
        }

        public bool equals(ExtrinsicState otherState)
        {
            return (this.subject == otherState.subject && this.location == otherState.location);
        }

        public int hashCode()
        {
            return subject.GetHashCode() + location.GetHashCode();
        }

        public string getSubjectandLocation()
        {
            return subjectandLocaltion;// this.subject +"."+ this.location;
        }
    }
}
