using System;
using System.Collections.Generic;

namespace materiel_et_medical.Models
{
    public partial class Adresse : Model
    {
        public int Numero { get; set; }
        public string Nom { get; set; }
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
    }
}
