using materiel_et_medical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace materiel_et_medical.Repository
{
    public class MaterielRepository : CrudRepository<Materiel>
    {
        public IQueryable<Materiel> Filter(Materiel model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Materiel> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Materiel> FindByID()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Materiel> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Materiel Save(Materiel model)
        {
            throw new NotImplementedException();
        }

        public Materiel Update(Materiel model)
        {
            throw new NotImplementedException();
        }
    }
}
