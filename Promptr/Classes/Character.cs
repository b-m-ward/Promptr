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
        public string Occupation { get; set; }
        public IEnumerable<string> Characteristics { get; set; }

        public string IntroduceCharacter()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{FirstName} {LastName} is {Age} years old and goes through life as a {Occupation}.");
            builder.AppendLine($"   He or she is:");
            foreach (var trait in Characteristics) builder.AppendLine($"    - {trait}");
            return builder.ToString();

        }

    }
}
