namespace EncapsulationPolymorphism
{
    public class CSharpDeveloper : Developer
    {
        public override bool MeetsMinimumOOPScore(int score)
        {
            return score > 75;
        }
    }
}
