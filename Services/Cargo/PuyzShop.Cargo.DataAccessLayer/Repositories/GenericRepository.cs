using Microsoft.EntityFrameworkCore;
using PuyzShop.Cargo.DataAccessLayer.Abstract;

namespace PuyzShop.Cargo.DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity, TContext> : IGenericDal<TEntity> where TEntity : class, new() where TContext : DbContext, new()
    {


        public void Delete(int id)
        {
            using var context = new TContext();
            var values = context.Set<TEntity>().Find(id);
            context.Set<TEntity>().Remove(values);
            context.SaveChanges();

        }

        public List<TEntity> GetAll()
        {
            using var context = new TContext();
            var values = context.Set<TEntity>().ToList();
            return values;
        }

        public TEntity GetById(int id)
        {
            using var context = new TContext();
            var values = context.Set<TEntity>().Find(id);
            return values;
        }

        public void Insert(TEntity entity)
        {
            using var context = new TContext();
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            using var context = new TContext();
            context.Set<TEntity>().Update(entity);
            context.SaveChanges();
        }
    }
}
