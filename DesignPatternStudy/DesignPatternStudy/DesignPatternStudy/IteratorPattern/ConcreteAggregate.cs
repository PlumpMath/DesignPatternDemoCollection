using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.IteratorPattern
{
    public class ConcreteAggregate : Aggregate
    {
        private List<object> vector = new List<object>();

        public void add(object obj)
        {
            vector.Add(obj);
        }

        public Iterator iterator()
        {
            return new ConcreteIterator(this.vector);
        }

        public void remove(object obj)
        {
            this.remove(obj);
        }
    }
}