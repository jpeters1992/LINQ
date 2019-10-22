using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQproblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var listedWords = words.Where(s => s.Contains("th")).ToList();
            foreach (var word in listedWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            //Problem2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var listedNames = names.Distinct();
            foreach (var noDuplicates in listedNames)
            {
                Console.WriteLine(noDuplicates);
            }
            Console.ReadLine();

            //Problem3
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            void AverageGrade(List<string> stringList)
            {
                var classGradesArray = new List<double>();
                double avgGrade = 0;
                List<double> avgGradeList = new List<double>();
                double totalGradeAvg;

                for (int i = 0; i < stringList.Count; i++)
                {
                    classGradesArray = classGrades[i].Split(',').Select(double.Parse).OrderBy(c => c).ToList();
                    classGradesArray.RemoveAt(0);
                    avgGrade = classGradesArray.Average();
                    avgGradeList.Add(avgGrade);
                }

                totalGradeAvg = avgGradeList.Average();
                Console.WriteLine($"{totalGradeAvg}");
            }
            AverageGrade(classGrades);
            Console.ReadLine();

            //Problem4

        }
    }
}
    