using Microsoft.EntityFrameworkCore;
using Entity;

namespace Datos
{
    public class PersonasContext: DbContext
    {
        public PersonasContext(DbContextOptions options):base(options)
        {
            
        }
        
        public DbSet<Persona>personas{get;set;}
        public DbSet<Restaurante>restaurantes{get;set;}
    }
}