using materiel_et_medical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace materiel_et_medical.Repository
{
    public class TypeRepository : CrudRepository<Models.Type>
    {
        private MaterielEtMedicalContext context;
        public TypeRepository(MaterielEtMedicalContext context)
        {
            this.context = context;
        }

        public IQueryable<Models.Type> Filter(Models.Type model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Models.Type> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Type> FindByID()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Models.Type> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Models.Type Save(Models.Type model)
        {
            throw new NotImplementedException();
        }

        public Models.Type Update(Models.Type model)
        {
            throw new NotImplementedException();
        }
    }
}
