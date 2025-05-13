using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Contracts.Interfaces
{
    public interface IRepository <TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void AddRange(IEnumerable<TEntity> obj);

        void RemoveRange(IEnumerable<TEntity> obj);

        void Update(TEntity obj, int id);

        void Remove(int id);
    }
}
