using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promptr.Core.Services;
using System.Diagnostics;

namespace Promptr.Tests
{
    [TestClass, TestCategory("Name Generation")]
    public class NameGeneratorTests
    {
        private NameService _names;

        [TestInitialize]
        public void Init()
        {
            CoreRegistration registry = new CoreRegistration();
            using (var scope = registry.Container.BeginLifetimeScope())
            {
                _names = scope.Resolve<NameService>();
            }
        }

        [TestMethod, Description("Generate a random name and ensure fn/ln are not empty.")]
        public void GenerateBasicName()
        {
            string fn = _names.FirstName;
            Assert.IsNotNull(fn);

            string ln = _names.LastName;
            Assert.IsNotNull(ln);
        }
    }
}
