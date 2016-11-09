using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGProgrammingTest
{
    /// <summary>
    /// I want to display some more data at the bottom of the program once finished.
    /// It is mostly in case a human is looking at it and may be interesting for them.
    /// In this case, this class stores data that we can modify in the algorithm but isn't part
    /// of any other class as it's useless otherwise.
    /// </summary>
    class AlgorithmAnalytics
    {
        public int TotalYearsFound { get; set; }
        public int MaxNumberOfPeopleInYears { get; set; }

        /// <summary>
        /// If we want to calculate how long sections of code take, put it here.
        /// </summary>
        //public Dictionary<string, TimeSpan> TimeTaken { get; set; }
    }
}
