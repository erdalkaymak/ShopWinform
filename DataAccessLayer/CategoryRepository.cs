using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryRepository
    {
        public List<Categories> List()
        {
            var db = new ShopEnSonEntities();
            List<Categories> result = new List<Categories>();
            result = db.Categories.ToList();
            return result;
        }

        public Categories Insert(Categories categories)
        {
            var db = new ShopEnSonEntities();
            Categories result = new Categories();
            result = db.Categories.Add(categories);
            db.SaveChanges();

            return result;
        }

        public void Delete(int id)
        {
            var db = new ShopEnSonEntities();
            Categories result = db.Categories.Where(c => c.Id == id).FirstOrDefault();
            result = db.Categories.Remove(result);
            db.SaveChanges();
        }

        public Categories Update(Categories entity)
        {
            var db = new ShopEnSonEntities();
            Categories result = db.Categories.Where(c => c.Id == entity.Id).FirstOrDefault();
            result.Name = entity.Name;
            result.CatOrder = entity.CatOrder;
            result.Description = entity.Description;
            db.SaveChanges();

            return result;
        }
    }
}
