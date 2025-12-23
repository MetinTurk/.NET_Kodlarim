using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSorusu
{
    public class BaseRepository<TEntity,TKey> : IRepository<TEntity,TKey> where TEntity : IEntity<TKey>
    {
        public TEntity GetById(TKey key)
        {
            throw new NotImplementedException();
        }
        public List<TEntity> GetAll()
        {
            throw new NotImplementedException ();
        } 
    }
}
