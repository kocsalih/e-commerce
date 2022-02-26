using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecommerce.entity;
using ecommerce.data.Abstract;

namespace ecommerce.data.Concrete.EFCore
{
    public class EfCoreProductRepository : IProductRepository
    {
        private ShopContext db = new ShopContext();
     
        public void Create(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
        }


        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int i)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetPopulerProduct()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
