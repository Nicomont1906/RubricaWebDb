using Microsoft.EntityFrameworkCore;
namespace montaspro.nicolo._4i.rubricaWebDb.Models
{

   

    public class dbContext : DbContext
    {
        private readonly DbContextOptions? _options;
        public dbContext() { }

        protected override void
                OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite("Data Source=Rubrica.db");

        public DbSet<Persona> Persone { get; set; }
    }

}
