using Refactoring_usando_generics.Interfaces;

namespace Refactoring_usando_generics.Repository
{
    public interface IRepository<T> where T : IEntity
    {
        void Agregar(T entity);
        void Actualizar(T entity);
        void Remover(T entity);
        List<T> TraerTodos();
        T ObtenerPorId(int id);
    }
}
