using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Contracts
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
