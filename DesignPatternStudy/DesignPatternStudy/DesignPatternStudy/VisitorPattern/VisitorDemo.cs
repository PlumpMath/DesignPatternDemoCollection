using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.VisitorPattern
{
    class VisitorDemo
    {
        public static void main()
        {
            for(int index=0;index<10;index++)
            {
                Element el = ObjectStructure.createElement();
                el.accept(new Visitor());
            }
        }
    }
}
