using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecommerce.entity;


namespace ecommerce.data.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        List<Product> GetPopulerProduct();
    }
}
