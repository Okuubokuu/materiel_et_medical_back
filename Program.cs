using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using materiel_et_medical.Models;
using materiel_et_medical.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace materiel_et_medical
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            MaterielEtMedicalContext context = new MaterielEtMedicalContext();

            //ClientRepository cRepo = new ClientRepository(context);
            CrudRepository<Client> crudclient = new CrudSQLRepository<Client>(context);

            crudclient.FindAll();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
