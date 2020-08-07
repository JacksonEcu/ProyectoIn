
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Practica_clase.Models;

namespace Practica_clase.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

             

    }
        public DbSet<Celular> Celulares { get; set; }
        public DbSet<Persona> Personas { get; set; }

    }
}
