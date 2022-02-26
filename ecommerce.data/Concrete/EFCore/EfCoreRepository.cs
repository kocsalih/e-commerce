using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecommerce.entity;
using ecommerce.data.Abstract;

namespace ecommerce.data.Concrete.EFCore
{
    public class EfCoreRepository : EfCoreGenericRepository<Product, ShopContext>, IProductRepository

    {
        public List<Product> GetPopulerProduct()
        {
            throw new NotImplementedException();
        }
    }
}
