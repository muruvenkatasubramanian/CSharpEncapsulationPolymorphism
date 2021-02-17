namespace EncapsulationPolymorphism
{
    public class PythonDeveloper : Developer
    {
        public bool MeetsMinimumOOPScore(int score)
        {
            return score > 65;
        }
    }
}
