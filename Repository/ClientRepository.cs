using materiel_et_medical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace materiel_et_medical.Repository
{
    public class ClientRepository : CrudRepository<Client>
    {
        private MaterielEtMedicalContext context;
        public ClientRepository(MaterielEtMedicalContext context)
        {
            this.context = context;
        }

        public IQueryable<Client> Filter(Client model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Client> FindAll()
        {
            return this.context.Client.Select(client => client);
        }

        public IEnumerable<Client> FindByID()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Client> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Client Save(Client model)
        {
            throw new NotImplementedException();
        }

        public Client Update(Client model)
        {
            throw new NotImplementedException();
        }
    }
}
