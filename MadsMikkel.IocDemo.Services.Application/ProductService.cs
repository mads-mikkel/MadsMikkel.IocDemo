using MadsMikkel.IocDemo.DataAccess;
using MadsMikkel.IocDemo.NorthwindEntities;

using System;
using System.Collections.Generic;

namespace MadsMikkel.IocDemo.Services.Application
{
    public interface IProductService
    {
        List<Products> GetAllProducts();
    }

    public class ProductService: IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public virtual List<Products> GetAllProducts()
        {
            var list = productRepository.GetAllProductsWithCategorySortedByName() as List<Products>;
            if(list is null) throw new InvalidOperationException("List was null");
            return list;
        }
    }
}