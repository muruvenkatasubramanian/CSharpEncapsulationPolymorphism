namespace EncapsulationPolymorphism
{
    public class RPADeveloper : Developer
    {
        public override bool MeetsMinimumSQLScore(int score)
        {
            return score > 20;
        }
    }
}
