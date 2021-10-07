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
        CharacterService _character;
        public PromptGenerator(CharacterService character)
        {
            _character = character;
        }

        public Character GenerateCharacter()
        {
            return _character.BuildCharacter();
        }

        public Character GenerateCharacter(int age, string firstName, string lastName)
        {
            return new Character(age, firstName, lastName);
        }

    }
}
