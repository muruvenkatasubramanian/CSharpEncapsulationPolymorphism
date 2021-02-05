namespace EncapsulationPolymorphism
{
    public class RPADeveloper
    {
        public string InterviewResult(string name, int oopScore, int sqlScore)
        {

            if (MeetsMinimumOOPScore(oopScore) && MeetsMinimumSQLScore(sqlScore))
                return $"{name} passed the technical interview";
            else
                return $"{name} did not pass the technical interview";
        }

        public bool MeetsMinimumOOPScore(int score)
        {
            return score > 60;
        }

        public bool MeetsMinimumSQLScore(int score)
        {
            return score > 20;
        }
    }
}
