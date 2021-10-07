using Promptr.Core.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promptr.Core.Services
{
    public class CharacterService
    {
        NameService _names;
        CharacteristicsService _traits;

        public CharacterService(NameService names, CharacteristicsService traits)
        {
            _names = names;
            _traits = traits;
        }

        public Character BuildBasicCharacter(int minAge, int maxAge, int numTraits = 3)
        {
            return new Character()
            {
                Age = RandomizeAge(minAge, maxAge),
                FirstName = _names.GetFirstName(),
                LastName = _names.GetLastName(),
                Characteristics = _traits.GetTraits(numTraits),
                Occupation = _traits.GetOccupation()
            };
        }

        public Character BuildCharacter()
        {
            return new Character(RandomizeAge(), _names.FirstName, _names.LastName);
        }

        public int RandomizeAge(int minAge = 0, int maxAge = 100)
        {
            Random rng = new Random();
            return rng.Next(minAge, maxAge);
        }

    }
}
