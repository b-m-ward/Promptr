using Autofac;
using Promptr.Core.Classes;
using Promptr.Core.Services;
using System;

namespace Promptr.Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            CoreRegistration reg = new CoreRegistration();

            CharacterService chars;
            using(var scope = reg.Container.BeginLifetimeScope())
            {
                chars = scope.Resolve<CharacterService>();
            }

            Character person = chars.BuildBasicCharacter(0, 100);

            Console.WriteLine(person.IntroduceCharacter());
            Console.ReadKey();
        }
    }
}
