using Refactoring_usando_generics.Interfaces;

namespace Refactoring_usando_generics.Repository
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        protected List<T> _entities = new List<T>();

        public void Agregar(T entity)
        {
            _entities.Add(entity);
        }

        public void Actualizar(T entity)
        {
            var index = _entities.FindIndex(e => e.Id == entity.Id);
            if (index != -1)
            {
                _entities[index] = entity;
            }
        }

        public void Remover(T entity)
        {
            _entities.Remove(entity);
        }

        public List<T> TraerTodos()
        {
            return _entities;
        }

        public T ObtenerPorId(int id)
        {
            return _entities.FirstOrDefault(e => e.Id == id);
        }
    }
    

}
