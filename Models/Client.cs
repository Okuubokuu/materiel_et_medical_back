using System;
using System.Collections.Generic;

namespace materiel_et_medical.Models
{
    public partial class Client : Model
    {
        public Client()
        {
            Adresse = new HashSet<Adresse>();
            Location = new HashSet<Location>();
        }

        public string CodeClient { get; set; }
        public string Nom { get; set; }
        public int? Telephone { get; set; }
        public int TypeId { get; set; }

        public virtual Type Type { get; set; }
        public virtual ICollection<Adresse> Adresse { get; set; }
        public virtual ICollection<Location> Location { get; set; }
    }
}
