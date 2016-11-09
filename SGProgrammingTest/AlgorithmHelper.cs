using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGProgrammingTest
{
    /// <summary>
    /// This class holds the algorithm to count the people alive per year data.
    /// Typically a class like this would hold more, I just didn't want it inside the driver file.
    /// </summary>
    static class AlgorithmHelper
    {
        /// <summary>
        /// Solves for the year (or years) with the most people alive based on the data set.
        /// </summary>
        /// <param name="PeopleData">A collection of people based on the person class.</param>
        /// <param name="YearsWithMostAlive">The solution found after counting.</param>
        /// <param name="info">Some addition, but not necessary, information for displaying to a human.</param>
        static public void CountYearsInPeopleData(ICollection<Person> PeopleData, List<int> YearsWithMostAlive, AlgorithmAnalytics info = null)
        {
            // This KV pairs represent years as the key and and increment of people alive as the value
            Dictionary<int, int> YearCountKV = new Dictionary<int, int>(100); // only 100 years to care about.

            foreach (var p in PeopleData)
            {
                for (int year = p.BirthYear; year < p.DeathYear; year++)
                {
                    if (!YearCountKV.ContainsKey(year))
                    {
                        YearCountKV.Add(year, 1);
                    }
                    else
                    {
                        YearCountKV[year]++;
                    }
                }
            }

            // List used to store the number of years with the same amount of people alive.
            // IE: 2 years could have 10 people alive in them, so we need to store both years as results
            if (YearsWithMostAlive == null) YearsWithMostAlive = new List<int>(100);
            else YearsWithMostAlive.Clear();
            // NOTE: This may be faster if we do a sort + insert method on the years with the highest counts.
            //      However because the max number of years is only 100, seems like a small upgrade at best.  KISS
            foreach (var year in YearCountKV.Keys)
            {
                // Show our yearly data to the console window.
                Console.WriteLine(string.Format("Year {0} had {1} people alive.", year, YearCountKV[year]));

                if (YearsWithMostAlive.Count == 0)
                {
                    YearsWithMostAlive.Add(year);
                }
                else
                {
                    if (YearCountKV[YearsWithMostAlive[0]] < YearCountKV[year])
                    {
                        YearsWithMostAlive.Clear();
                        YearsWithMostAlive.Add(year);
                    }
                    else if (YearCountKV[YearsWithMostAlive[0]] == YearCountKV[year])
                    {
                        YearsWithMostAlive.Add(year);
                    }
                }
            }

            // Analytic info stored here.
            if( info != null )
            {
                info.MaxNumberOfPeopleInYears = YearCountKV[YearsWithMostAlive[0]];
                info.TotalYearsFound = YearsWithMostAlive.Count;
            }
        }
    }
}
