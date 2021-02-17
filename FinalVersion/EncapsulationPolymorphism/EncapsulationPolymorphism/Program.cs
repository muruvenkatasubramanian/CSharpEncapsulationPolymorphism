using System;

namespace EncapsulationPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Developer cSharpDeveloper = new CSharpDeveloper();
            Developer pythonDeveloper = new PythonDeveloper();
            Developer rPADeveloper = new RPADeveloper();

            Console.WriteLine(cSharpDeveloper.InterviewResult("Pete", 70, 55));
            Console.WriteLine(pythonDeveloper.InterviewResult("Raymond", 45, 55));
            Console.WriteLine(rPADeveloper.InterviewResult("Ann", 75, 30));
        }
    }
}
