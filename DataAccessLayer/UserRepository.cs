using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserRepository
    {             
        public List<Users> List()
        {
            var db = new ShopEnSonEntities();
            List<Users> result = new List<Users>();
            result = db.Users.ToList();
            return result;
            
        }
        public Users Insert(Users entity)
        {
            Users result = new Users();
            ShopEnSonEntities db = new ShopEnSonEntities();
            result = db.Users.Add(entity);
            db.SaveChanges();
            return result;
        }

        public Users Update(Users entitiy)
        {
           
            ShopEnSonEntities db = new ShopEnSonEntities();
            Users defaultUser = db.Users.Where(c => c.Id == entitiy.Id).FirstOrDefault();
            defaultUser.Password = entitiy.Password;
            defaultUser.UserName = entitiy.UserName;
            defaultUser.FullName = entitiy.FullName;
            defaultUser.Credit = entitiy.Credit;
            db.SaveChanges();

            return defaultUser;
        }

        public void Delete(int id)
        {
            ShopEnSonEntities db = new ShopEnSonEntities();
            Users usr=db.Users.Where(c=> c.Id==id).FirstOrDefault();
            db.Users.Remove(usr);
            db.SaveChanges();
        }
    }
}
