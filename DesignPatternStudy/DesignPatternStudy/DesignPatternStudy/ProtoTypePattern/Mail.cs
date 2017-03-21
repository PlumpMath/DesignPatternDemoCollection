using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ProtoTypePattern
{
    public class Mail
    {
        private string _recevier;
        private string _subject;
        private string _appellation;
        private string _contxt;
        private string _tail;

        public Mail(AdvTemplete advTemplete)
        {
            this._contxt = advTemplete.getAdvContent();
            this._subject = advTemplete.getAdvSubject();
        }

        public string receiver
        {
            get { return _recevier; }
            set { _recevier = value; }
        }

        public string subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public string appellatopn
        {
            get { return _appellation; }
            set { _appellation = value; }
        }

        public string contxt
        {
            get { return _contxt; }
            set { _contxt = value; }
        }

        public string tail
        {
            get { return _tail; }
            set { _tail = value; }
        }
         
    }
}
