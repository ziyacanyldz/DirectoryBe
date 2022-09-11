using Business.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class KayitlarManager : IKayitlarService
    {
        private KayitlarDal kayitlarDal;
        public KayitlarManager()
        {
            kayitlarDal = new KayitlarDal();
        }
        public Kayit Add(Kayit kayit)
        {
            kayit.Tarih = DateTime.Now;
            return kayitlarDal.Add(kayit);
        }

        public void Delete(int id)
        {
            kayitlarDal.Delete(id);
        }

        public List<Kayit> GetAll()
        {
            return kayitlarDal.GetAll();
        }

        public Kayit GetById(int id)
        {
            return kayitlarDal.GetById(id);
        }

        public Kayit GetByName(string name)
        {
            return kayitlarDal.GetByName(name);
        }

        public Kayit Update(Kayit kayit)
        {
            kayit.Tarih = DateTime.Now;
            return kayitlarDal.Update(kayit);
        }
    }
}
