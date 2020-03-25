using System;
using System.Collections.Generic;

namespace materiel_et_medical.Models
{
    public partial class Materiel : Model
    {
        public Materiel()
        {
            Location = new HashSet<Location>();
        }

        public string Reference { get; set; }
        public string Designation { get; set; }
        public DateTime? DateAchat { get; set; }
        public float? PrixJour { get; set; }
        public int Categorie { get; set; }

        public virtual Categorie CategorieNavigation { get; set; }
        public virtual ICollection<Location> Location { get; set; }
    }
}
