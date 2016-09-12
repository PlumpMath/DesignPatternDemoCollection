namespace DesignPatternStudy.FactoryPattern.FactoryMulti
{
    public class BlackHumanFactory : AbstractHumanFact1
    {
        public override Human createHuman()
        {
            return new BlackHuman();
        }
    }
}