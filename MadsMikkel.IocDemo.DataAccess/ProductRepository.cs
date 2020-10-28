using MadsMikkel.IocDemo.NorthwindEntities;

using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;

namespace MadsMikkel.IocDemo.DataAccess
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetAllProductsWithCategorySortedByName();
    }

    public class ProductRepository: RepositoryBase, IProductRepository
    {
        public ProductRepository(INorthwindContext northwindContext) : base(northwindContext) { }

        public virtual IEnumerable<Products> GetAllProductsWithCategorySortedByName()
        {
            return northwindContext.Products.Include("Category").OrderBy(p => p.ProductName).ToList();
        }
    }
}