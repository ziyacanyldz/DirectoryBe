using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class KayitlarDal
    {
        public List<Kayit> GetAll()
        {
            using (var kayitDbContext = new KayitDbContext())
            {
                return kayitDbContext.Kayitlar.ToList();
            }
        }
        
        public Kayit GetById(int id)
        {
            using (var kayitDbContext = new KayitDbContext())
            {
                return kayitDbContext.Kayitlar.Find(id);
            }
        }

        public Kayit GetByName(string name)
        {
            using (var kayitDbContext = new KayitDbContext())
            {
                return kayitDbContext.Kayitlar.FirstOrDefault(x=>x.AdiSoyadi.ToLower()==name.ToLower());
            }
        }

        public void Delete(int id)
        {
            using (var kayitDbContext = new KayitDbContext())
            {
                var deletedKayit = GetById(id);
                kayitDbContext.Kayitlar.Remove(deletedKayit);
                kayitDbContext.SaveChanges();
            }
        }

        public Kayit Add(Kayit kayit)
        {
            using (var kayitDbContext = new KayitDbContext())
            {
                kayitDbContext.Kayitlar.Add(kayit);
                kayitDbContext.SaveChanges();
                return kayit;
            }
        }

        public Kayit Update(Kayit kayit)
        {
            using (var kayitDbContext = new KayitDbContext())
            {
                kayitDbContext.Kayitlar.Update(kayit);
                kayitDbContext.SaveChanges();
                return kayit;
            }
        }
    }
}
