using OrderSystem2.entity;

namespace OrderSystem2.repository.abstracts
{
    public interface IFieldRepository : IGenericRepository<Field>
    {      
        public void SetUsed(int id,bool inUsed);
    }
}
