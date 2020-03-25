using System;
using System.Collections.Generic;

namespace materiel_et_medical.Models
{
    public partial class Categorie : Model
    {
        public Categorie()
        {
            Materiel = new HashSet<Materiel>();
        }

        public string Code { get; set; }
        public string Libelle { get; set; }

        public virtual ICollection<Materiel> Materiel { get; set; }
    }
}
