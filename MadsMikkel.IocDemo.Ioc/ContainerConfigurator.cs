using Autofac;

using MadsMikkel.IocDemo.DataAccess;
using MadsMikkel.IocDemo.Ioc.Containers;
using MadsMikkel.IocDemo.NorthwindEntities;
using MadsMikkel.IocDemo.Services.Application;
using MadsMikkel.IocDemo.Ui.ViewModels;

namespace MadsMikkel.IocDemo.Ioc
{
    public static class ContainerConfigurator
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<NorthwindContext>().As<INorthwindContext>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ProductViewModel>().As<IProductViewModel>();

            IContainer container = builder.Build();
            AutofacContainer.Initialize(container);
        }
    }
}