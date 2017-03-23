using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.BuilderPattern
{
    //车辆产品描述
    public interface ICar
    {
        string getWheel();
        string getEngine(); 
    }
}
