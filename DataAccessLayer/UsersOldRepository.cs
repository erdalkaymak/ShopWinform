using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UsersOldRepository
    {
        public List<UsersOld> List()
        {
            ShopEnSonEntities db = new ShopEnSonEntities();
            List<UsersOld> result = new List<UsersOld>();
            result = db.UsersOld.ToList();

            return result;
        }

        public void Delete(int id)
        {
            var db = new ShopEnSonEntities();
            UsersOld result = db.UsersOld.Where(c => c.Id == id).FirstOrDefault();
            db.UsersOld.Remove(result);
            db.SaveChanges();
        }

        public UsersOld Insert(UsersOld entity)
        {
            var db = new ShopEnSonEntities();
            UsersOld result = new UsersOld();
            result = db.UsersOld.Add(entity);
            db.SaveChanges();
            return result;
        }

        public UsersOld Update(UsersOld entity)
        {
            var db = new ShopEnSonEntities();
            UsersOld result = db.UsersOld.Where(c => c.Id == entity.Id).FirstOrDefault();
            result.Password = entity.Password;
            result.UserName = entity.UserName;
            result.FullName = entity.FullName;
            result.Bakiye = entity.Bakiye;

            db.SaveChanges();

            return result;
        }
    }
}
