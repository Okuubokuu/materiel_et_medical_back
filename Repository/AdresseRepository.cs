using materiel_et_medical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace materiel_et_medical.Repository
{
    public class AdresseRepository : CrudRepository<Adresse>
    {
        public IQueryable<Adresse> Filter(Adresse model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Adresse> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Adresse> FindByID()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Adresse> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Adresse Save(Adresse model)
        {
            throw new NotImplementedException();
        }

        public Adresse Update(Adresse model)
        {
            throw new NotImplementedException();
        }
    }
}
