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
            return this.context.Client.Where(client => client.Id == model.Id
                                        && client.Location == model.Location
                                        && client.Nom == model.Nom
                                        && client.Telephone == model.Telephone
                                        && client.TypeId == model.TypeId);
        }

        public IQueryable<Client> FindAll()
        {
            // SELECT * FROM client;
            return this.context.Client.Select(client => client);
        }

        public Client FindByID(int id)
        {
            return this.context.Client
                .Where(client => client.Id == id)
                .First();
        }

        public Client Save(Client model)
        {
            throw new NotImplementedException();
        }

        public Client Update(Client model)
        {
            throw new NotImplementedException();
        }

        void CrudRepository<Client>.Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}