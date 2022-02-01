namespace Mine2Craft.Test.Persistance
{
    public interface IGenericRepository<T> where T : class,new() 
    {
        IEnumerable<T> GetAll(); 

        T? Get(Guid guid);

        void Add(T entity);

        bool Delete(Guid guid);

        bool Update(T entity);
    }
}