using System;
using System.Collections.Generic;

namespace materiel_et_medical.Models
{
    public partial class Type
    {
        public Type()
        {
            Client = new HashSet<Client>();
        }

        public int Id { get; set; }
        public string Type1 { get; set; }

        public virtual ICollection<Client> Client { get; set; }
    }
}
