using materiel_et_medical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace materiel_et_medical.Repository
{
    public class CategorieRepository : CrudRepository<Categorie>
    {
        public IQueryable<Categorie> Filter(Categorie model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Categorie> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categorie> FindByID()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Categorie> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Categorie Save(Categorie model)
        {
            throw new NotImplementedException();
        }

        public Categorie Update(Categorie model)
        {
            throw new NotImplementedException();
        }
    }
}
