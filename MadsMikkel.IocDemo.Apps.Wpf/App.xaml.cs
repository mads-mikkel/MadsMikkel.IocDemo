using Autofac;
using MadsMikkel.IocDemo.Ioc;
using MadsMikkel.IocDemo.NorthwindEntities;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MadsMikkel.IocDemo.Apps.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App: Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ContainerConfigurator.Configure();
        }
    }
}
