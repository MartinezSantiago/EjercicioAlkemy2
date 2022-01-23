using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EjercicioAlkemy2.Context;
using EjercicioAlkemy2.Repository;
using EjercicioAlkemy2.Models;

using Microsoft.EntityFrameworkCore;

namespace EjercicioAlkemy2.Repository
{
    public abstract class Repository<TEntity, TContext> : IRepository<TEntity> where TEntity : class where TContext : DbContext
    {
      

        private readonly TContext context;
        protected Repository(TContext c){
            context = c;
            }
     

       public void Delete(int id)
        {
           var aux=context.Set<TEntity>().Find(id);
            context.Set<TEntity>().Remove(aux);
            context.SaveChanges();
        }

        public void Add(TEntity t)
        {
            context.Set<TEntity>().Add(t);
            context.SaveChanges();
        }

        public void Update(TEntity t)
        {


            context.Set<TEntity>().Update(t);
            context.SaveChanges();
            


        }
        public List<TEntity> Get()
        {
            return context.Set<TEntity>().ToList();
        }
    }
}
