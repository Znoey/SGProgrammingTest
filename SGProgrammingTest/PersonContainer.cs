using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGProgrammingTest
{
    /// <summary>
    /// Holds our dataset of people for processing.
    /// See Person class, this class is married to it.
    /// While I don't need anything specific here, typically I would use a container class like this
    /// to store specific procedures for this data set.  For example, loading this from a stream.
    /// </summary>
    class PersonContainer
    {
        public List<Person> People;

        public PersonContainer(int numPeopleToGenerate)
        {
            People = new List<Person>();
            for (int i = 0; i < numPeopleToGenerate; i++)
            {
                People.Add(new Person());
            }
        }

        public Person this [int key ]
        {
            get { return People[key]; }
            set { People[key] = value; }
        }
    }
}
