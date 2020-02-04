using System;
using Autofac;
using Autofac.Extras.DynamicProxy;

namespace AutofacDynamicProxyBug
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Thingy>()
                   .As<IThingy>()
                   .EnableInterfaceInterceptors();

            var container = builder.Build();

            var thingy = container.Resolve<IThingy>();
        }
    }

    public class Thingy : IThingy { }

    public interface IThingy { }
}
