using Microsoft.EntityFrameworkCore;

namespace pz_10._1
{
    public class ZooContext:DbContext
    {
        public ZooContext()=>
            Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseNpgsql(//"Host=localhost;" +
            //    "Port=0000;" +
            //    "Database=Zoo;" +
            //    "Username=user;" +
            //    "Password=0000;");
        public DbSet<Animal> Animals {  get; set; }
        public DbSet<Cage> Cages { get; set; }
    }
}
