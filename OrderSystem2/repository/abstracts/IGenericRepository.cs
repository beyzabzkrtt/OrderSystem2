namespace OrderSystem2.repository.abstracts
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity,int id);
        void Delete(int id);
    }
}
