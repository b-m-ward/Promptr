using Promptr.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promptr.Core.Services.Interfaces
{
    public interface IPromptGenerator
    {
        Character GenerateCharacter();
        int RandomizeAge(int minAge, int maxAge);
        string RandomizeFirstName();
        string RandomizeLastName();
    }
}
