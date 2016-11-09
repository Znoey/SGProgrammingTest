using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGProgrammingTest
{
    /// <summary>
    /// Storing the data for a person
    /// </summary>
    class Person
    {
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }

        // I often prefer more controlled randomization, but I don't think it's needed here.
        private static Random rando = new Random();

        public Person()
        {
            // Our program only needs to randomly set the year's of birth
            BirthYear = rando.Next() % 100 + 1900; // any year between 1900 and 2000
            DeathYear = rando.Next() % (2000 - BirthYear) + BirthYear; // any year after birth  
        }

        public override string ToString()
        {
            return string.Format("Person: {0} - {1}", BirthYear, DeathYear);
        }
    }
}
