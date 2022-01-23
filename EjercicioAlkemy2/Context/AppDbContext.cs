using EjercicioAlkemy2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EjercicioAlkemy2.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Ejercicio2-Alkemy;Integrated Security=True;");
        }

       public  DbSet<User>Users{ get; set; }
       public DbSet<Post>Posts{ get; set; }
        public DbSet<Comment>Comments{ get; set; }

    }
}
