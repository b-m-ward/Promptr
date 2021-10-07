using Autofac;
using Promptr.Core.Services;
using System;

namespace Promptr
{
    public class CoreRegistration
    {
        public IContainer Container { get; set; }

        public CoreRegistration()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<NameService>().AsSelf();
            builder.RegisterType<CharacterService>().AsSelf();
            builder.RegisterType<CharacteristicsService>().AsSelf();


            Container = builder.Build();
        }
    }
}
