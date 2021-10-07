using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promptr.Core.Classes;
using Promptr.Core.Services;
using System.Diagnostics;

namespace Promptr.Tests
{
    [TestClass, TestCategory("Character Generation")]
    public class CharacterGeneratorTests
    {
        private CharacterService _chars;

        [TestInitialize]
        public void Init()
        {
            CoreRegistration registry = new CoreRegistration();
            using (var scope = registry.Container.BeginLifetimeScope())
            {
                _chars = scope.Resolve<CharacterService>();
            }
        }

        [TestMethod, Description("Generate a random basic character")]
        public void GenerateBasicCharacter()
        {
            Character character = _chars.BuildBasicCharacter(18, 65);
            Assert.IsNotNull(character);

            string intro = character.IntroduceCharacter();
            Assert.IsNotNull(intro);
        }
    }
}
