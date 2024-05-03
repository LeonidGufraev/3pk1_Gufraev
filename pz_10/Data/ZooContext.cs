using System.Collections.Generic;
using System.Reflection.Emit;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using static pz_10.Data.ZooContext;

namespace pz_10.Data
{
    public class ZooContext : DbContext
    {

        public ZooContext() => Database.EnsureCreated();


        public DbSet<Animal> Animals { get; set; }
        public DbSet<Cage> Cage { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().HasData(GetAnimal());
            modelBuilder.Entity<Cage>().HasData(GetCage());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Zoo.db");
            base.OnConfiguring(optionsBuilder);
        }

        private Animal[] GetAnimal()
        {
            return new Animal[]
            {
                new Animal { Id=1,Name = "Слон", Quantity = 2},
                new Animal {Id=2, Name = "Зебра", Quantity = 3},
                new Animal { Id=3,Name = "Лев", Quantity = 4},
                new Animal { Id=4,Name = "Обезьяна", Quantity = 12},
                new Animal {Id=5, Name = "Олень", Quantity = 2}
            };
        }
        private Cage[] GetCage()
        {
            return new Cage[]
            {
                new Cage { Id=1,Beast = 1, Quantity = 2},
                new Cage {  Id=2,Beast = 2, Quantity = 3},
                new Cage {  Id=3,Beast = 3, Quantity = 4},
                new Cage {  Id=4,Beast= 4,Quantity = 12},
                new Cage {  Id=5,Beast= 5, Quantity = 2}
            };
        }
    }
}