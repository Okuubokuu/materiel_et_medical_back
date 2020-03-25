using materiel_et_medical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace materiel_et_medical.Repository
{
    public class LocationRepository : CrudRepository<Location>
    {
        public IQueryable<Location> Filter(Location model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Location> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Location> FindByID()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Location> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Location Save(Location model)
        {
            throw new NotImplementedException();
        }

        public Location Update(Location model)
        {
            throw new NotImplementedException();
        }
    }
}
