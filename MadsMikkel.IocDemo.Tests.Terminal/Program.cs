using Autofac;

using MadsMikkel.IocDemo.Ioc;
using MadsMikkel.IocDemo.Ioc.Containers;
using MadsMikkel.IocDemo.NorthwindEntities;
using MadsMikkel.IocDemo.Services.Application;

using System;
using System.Collections.Generic;

namespace MadsMikkel.IocDemo.Tests.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerConfigurator.Configure();
            ListAllProducts();
        }

        static void ListAllProducts()
        {
            string output = "";
            List<Products> products = null;
            using(var scope = AutofacContainer.Instance.BeginLifetimeScope()) 
            {
                IProductService productService = scope.Resolve<IProductService>();
                products = productService.GetAllProducts();
            }
            foreach(var p in products) { output += $"{p.ProductName}\n"; }
            Console.WriteLine(output);
        }
    }
}