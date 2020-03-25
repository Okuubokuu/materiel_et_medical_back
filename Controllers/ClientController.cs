using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using materiel_et_medical.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace materiel_et_medical.Controllers
{
    [Route("/clients")]
    [ApiController]
    public class ClientController
    {
        public ClientController()
        {
        }
        
        public ICollection<Client> findAll()
        {
            ICollection<Client> clients = new List<Client>();
            Client c1 = new Client()
            {
                CodeClient = "CDF4227",
                Nom = "LeCLient"
            };
            Client c2 = new Client()
            {
                CodeClient = "QK5FL74",
                Nom = "LeCLient"
            };
            clients.Add(c1);
            clients.Add(c2);

            return clients;
        }
    }
}