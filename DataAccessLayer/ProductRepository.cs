using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductRepository
    {
        ShopEnSonEntities db;

        public ProductRepository()
        {
            db = new ShopEnSonEntities();
        }

        public List<CustomerProduct> List()
        {
            List<CustomerProduct> result =
                      (from p in db.Products                                                        
                      join c in db.Categories on p.categoryId equals c.Id
                      select new CustomerProduct()
                      {
                          Id = p.Id,
                          categoryId = p.categoryId,
                          Name = p.Name,
                          Price = p.Price,
                          productCode = p.productCode,
                          stocks = p.stocks,
                          CategoryName = c.Name

                      }).ToList();

            return result;
        }

        public Products Insert(Products entity)
        {
            Products result = new Products();
            result = db.Products.Add(entity);
            db.SaveChanges();

            return result;
        }

        public Products Update(Products entity)
        {
            Products result = db.Products.Where(c => c.Id == entity.Id).FirstOrDefault();
            result.Name = entity.Name;
            result.Price = entity.Price;
            result.productCode = entity.productCode;
            result.categoryId = entity.categoryId;
            result.stocks = entity.stocks;
            db.SaveChanges();

            return result;
        }

        public void Delete(int id)
        {
            Products result = db.Products.Where(c => c.Id == id).FirstOrDefault();
            result = db.Products.Remove(result);
            db.SaveChanges();
        }
    }
}
