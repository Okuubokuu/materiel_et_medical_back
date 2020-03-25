using System;
using System.Collections.Generic;

namespace materiel_et_medical.Models
{
    public partial class Location : Model
    {
        public int? Duree { get; set; }
        public int ClientId { get; set; }
        public int MaterielId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Materiel Materiel { get; set; }
    }
}
