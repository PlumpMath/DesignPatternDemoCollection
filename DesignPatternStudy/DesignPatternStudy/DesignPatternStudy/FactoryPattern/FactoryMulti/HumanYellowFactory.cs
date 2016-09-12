using System; 

namespace DesignPatternStudy.FactoryPattern.FactoryMulti
{
    public class HumanYellowFactory : AbstractHumanFact1
    {
        public override Human createHuman()
        {
            return new YellowHuman();
        }
    }
}
