using System;
using System.Collections.Generic;

namespace materiel_et_medical.Models
{
    public partial class Type : Model
    {
        public Type()
        {
            Client = new HashSet<Client>();
        }

        public string Type1 { get; set; }

        public virtual ICollection<Client> Client { get; set; }
    }
}
