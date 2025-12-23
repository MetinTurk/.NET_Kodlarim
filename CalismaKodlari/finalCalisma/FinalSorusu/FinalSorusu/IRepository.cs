using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSorusu
{
    public interface IRepository<TEntity,TKey> where TEntity : IEntity<TKey>
    {
        TEntity GetById(TKey key);
        List<TEntity> GetAll();
    }
}
