using System.Collections.Generic;

namespace Moda_System.Classes
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        //void Add(TEntity obj);
        List<ErrosDB> Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        //void Update(TEntity obj);
        //void Remove(TEntity obj);
        List<ErrosDB> Update(TEntity obj);
        List<ErrosDB> Remove(TEntity obj);
        void Dispose();
    }
}
