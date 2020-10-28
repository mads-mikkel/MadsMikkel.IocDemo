using MadsMikkel.IocDemo.NorthwindEntities;
using MadsMikkel.IocDemo.Services.Application;

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MadsMikkel.IocDemo.Ui.ViewModels
{
    public interface IProductViewModel: IViewModel
    {
        ObservableCollection<Products> Products { get; set; }
    }

    public class ProductViewModel: ViewModelBase, IProductViewModel
    {
        private readonly IProductService productService;
        private Products selectedProduct;

        public ProductViewModel(IProductService productService)
        {
            this.productService = productService;
            Products = new ObservableCollection<Products>();
        }

        public ObservableCollection<Products> Products { get; set; }

        public Products SelectedProduct
        {
            get => selectedProduct;
            set
            {
                selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
            }
        }

        public override void Initialize()
        {
            List<Products> products = productService.GetAllProducts();
            Products.Clear();
            foreach(var p in products) { Products.Add(p); }
        }
    }
}