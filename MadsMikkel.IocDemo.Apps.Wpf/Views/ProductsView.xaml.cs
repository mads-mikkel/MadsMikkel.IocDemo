using Autofac;

using MadsMikkel.IocDemo.Ioc.Containers;
using MadsMikkel.IocDemo.Ui.ViewModels;

using System.Windows;
using System.Windows.Controls;

namespace MadsMikkel.IocDemo.Apps.Wpf.Views
{
    /// <summary>
    /// Interaction logic for ProductsView.xaml
    /// </summary>
    public partial class ProductsView: UserControl
    {
        public ProductsView()
        {
            InitializeComponent();            
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            IProductViewModel productsViewModel = AutofacContainer.Instance.Resolve<IProductViewModel>();
            DataContext = productsViewModel;
            productsViewModel.Initialize();
        }
    }
}
