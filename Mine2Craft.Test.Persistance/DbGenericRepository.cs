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
    }
}
