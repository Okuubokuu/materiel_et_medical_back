using materiel_et_medical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace materiel_et_medical.Repository
{
    public class CategorieRepository : CrudSQLRepository<Categorie>
    {
        public CategorieRepository(MaterielEtMedicalContext context): base(context)
        {

        }
    }
}
