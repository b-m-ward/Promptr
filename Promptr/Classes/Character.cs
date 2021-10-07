using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promptr.Core.Classes
{
    public class Character
    {
        public Character(int age, string firstName, string lastName)
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;

        }

        public Character()
        {

        }

        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
