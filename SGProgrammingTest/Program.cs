using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGProgrammingTest
{
    /// <summary>
    /// Main driver for this console application.
    /// This app is designed to solve the following problem
    /// -- Given a list of people with their birth and end years (all between 1900 and 2000), 
    /// -- find the year with the most number of people alive.
    /// We will generate a dataset
    /// Search our data for the year with the most people alive
    /// Display the results.
    /// 
    /// I'm aware that due to the nature of this problem, I could have put the entire solution in this 
    /// file.  However I wanted to display organization and problem breakdown as well.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a Dataset
            Console.WriteLine("Welcome to SGProgrammingTest.");
            Console.WriteLine("Generating Dataset...");
            Console.WriteLine("");
            var PeopleData = new PersonContainer(10);
            foreach(var person in PeopleData.People)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("");

            // Find the year with the most people 
            Console.WriteLine("Solving for the most people alive during a certain year.");
            var YearsWithMostAlive = new List<int>();
            var Analytics = new AlgorithmAnalytics();
            AlgorithmHelper.CountYearsInPeopleData(PeopleData.People, YearsWithMostAlive, Analytics);

            // Display results 
            Console.WriteLine("");
            Console.WriteLine("Results:");
            foreach(var year in YearsWithMostAlive)
            {
                Console.WriteLine(year); 
            }
            Console.WriteLine("");
            Console.WriteLine("We found {0} people alive during year(s) listed above.", Analytics.MaxNumberOfPeopleInYears);
            Console.WriteLine("Total years were {0}.", Analytics.TotalYearsFound);
            Console.WriteLine("");

#if DEBUG
            Console.WriteLine("Press enter to continue...");
            Console.Read();
#endif
        }
    }
}
