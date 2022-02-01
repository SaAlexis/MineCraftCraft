using Microsoft.EntityFrameworkCore;

namespace Mine2Craft.Test.Persistance
{
    public class DbGenericRepository<T> : IGenericRepository<T> where T : class,new() 
    {
        private DbContext Context { get; }

        public DbGenericRepository(DbContext context)
        {
            Context = context;
        }

        public void Add(T entity)
        {           
           Context.Add(entity);
           Context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }     

        public virtual T? Get(Guid guid)
        {
            return Context.Set<T>().Find(guid);
        }

        public bool Delete(Guid guid)
        {
            T? item = Context.Set<T>().Find(guid);
            if (item != null)
            {
                Context.Remove(item);
                Context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(T entity)
        {
            if (entity != null)
            {
                Context.Update(entity);
                Context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
