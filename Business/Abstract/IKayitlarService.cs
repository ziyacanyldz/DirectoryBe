using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKayitlarService
    {
        List<Kayit> GetAll();
        Kayit GetById(int id);
        Kayit GetByName(string name);
        Kayit Add(Kayit kayit);
        Kayit Update(Kayit kayit);
        void Delete(int id);
        
    }
}
