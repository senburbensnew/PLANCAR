using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using PLANCAR_DAO.Models;

namespace PLANCAR_DAO.Data
{
    public static class DatabaseSeeder
    {
        public static void SeedDatabase(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<PlancarDbContext>();

                // Ensure the database is created
                context.Database.EnsureCreated();

                // Check if data exists
                if (!context.Departements.Any())
                {
                    // Add initial data
                    context.Departements.AddRange(
                        new Departement { Libelle = "Ouest" },
                        new Departement { Libelle = "Sud" },
                        new Departement { Libelle = "Sud-Est" },
                        new Departement { Libelle = "Sud-Ouest" },
                        new Departement { Libelle = "Nord" },
                        new Departement { Libelle = "Nord-Est" },
                        new Departement { Libelle = "Nord-Ouest" },
                        new Departement { Libelle = "Artibonite" },
                        new Departement { Libelle = "Centre" },
                        new Departement { Libelle = "Nippes" }
                    );

                    context.SaveChanges();
                }
            }
        }
    }
}
