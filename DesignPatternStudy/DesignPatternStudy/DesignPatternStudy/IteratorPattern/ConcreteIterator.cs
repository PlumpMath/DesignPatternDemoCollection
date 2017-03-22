using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.IteratorPattern
{
  public   class ConcreteIterator : Iterator
    {
        private List<object> vector = new List<object>();

        public int cursor = 0;
        public ConcreteIterator(List<object> list)
        {
            vector = list;
        }

        public object  next()
        {
            object result = null;
            if(this.hasNext())
            {
                result = this.vector[this.cursor++];
            }
            return result;
        }

        public bool hasNext()
        {
            if (this.cursor == this.vector.Count)
                return false;
            else
                return true;
        }

        public  bool  remove()
        {
            this.vector.RemoveAt(this.cursor);
            return true;
        }
    }
}
