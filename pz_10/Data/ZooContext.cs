using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using static pz_10.Data.ZooContext;

namespace pz_10.Data
{
    public class ZooContext : DbContext
    {

        public ZooContext()=>Database.EnsureCreated();
        

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
                new Animal { ID = 1, Name = "Слон", Quantity = 2},
                new Animal { ID = 2, Name = "Зебра", Quantity = 3},
                new Animal { ID = 3, Name = "Лев", Quantity = 4},
                new Animal { ID = 4, Name = "Обезьяна", Quantity = 12},
                new Animal { ID = 5, Name = "Олень", Quantity = 2}
            };
        }
        private Cage[] GetCage()
        {
            return new Cage[]
            {
                new Cage { Number = 1, Beast = 1, Quantity = 2},
                new Cage { Number = 2, Beast = 2, Quantity = 3},
                new Cage { Number = 3, Beast = 3, Quantity = 4},
                new Cage { Number = 4, Beast= 4,Quantity = 12},
                new Cage { Number = 5, Beast= 5, Quantity = 2}
            };
        }
    }
}