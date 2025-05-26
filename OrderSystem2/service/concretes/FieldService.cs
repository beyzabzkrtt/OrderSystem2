using OrderSystem2.entity;
using OrderSystem2.repository.abstracts;
using OrderSystem2.service.abstracts;

namespace OrderSystem2.service.concretes
{
    public class FieldService : IFieldService
    {
        private readonly IFieldRepository _fieldRepository;

        public FieldService(IFieldRepository fieldRepository)
        {
            _fieldRepository = fieldRepository;
        }

        public void Add(Field entity)
        {
             entity.Status = true;
            _fieldRepository.Add(entity);
            
        }

        public void Delete(int id)
        {

            _fieldRepository.Delete(id);
        }

        public List<Field> GetAll()
        {
            return _fieldRepository.GetAll();
        }

        public Field GetById(int id)
        {
            return _fieldRepository.GetById(id);
        }

        public void SetUsed(int id, bool inUsed)
        {
           _fieldRepository.SetUsed(id, inUsed);
        }

        public void Update(Field entity, int id)
        {
           _fieldRepository.Update(entity, id);
        }
    }
}
