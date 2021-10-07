using Promptr.Core.Classes;
using Promptr.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promptr.Core.Services
{
    class PromptGenerator : IPromptGenerator
    {
        public PromptGenerator()
        {

        }

        public Character GenerateCharacter()
        {
            return new Character()
            {
                Age = RandomizeAge(),
                FirstName = RandomizeFirstName(),
                LastName = RandomizeLastName()
            };
        }

        public Character GenerateCharacter(int age, string firstName, string lastName)
        {
            return new Character(age, firstName, lastName);
        }

        public int RandomizeAge(int minAge = 0, int maxAge = 100)
        {
            Random rng = new Random();
            return rng.Next(minAge, maxAge);

        }

        public string RandomizeFirstName()
        {
            throw new NotImplementedException();
        }

        public string RandomizeLastName()
        {
            throw new NotImplementedException();
        }
    }
}
