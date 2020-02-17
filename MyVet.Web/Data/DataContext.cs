using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyVet.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data
{
    public class DataContext: IdentityDbContext<User>
    {
        //ctor
        /*Base de datos que se basa en el DataContext y se llama option
        y se le pasa al constructor de la superclase */
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        /*Cuales entities vamos a mapear en bases de datos 
         y se los pasamos por propiedades
         la colección se maneja en plural (Owners)*/
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }

    }
}
