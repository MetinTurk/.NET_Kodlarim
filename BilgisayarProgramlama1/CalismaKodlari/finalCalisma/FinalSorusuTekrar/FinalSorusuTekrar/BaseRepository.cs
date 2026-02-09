using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSorusuTekrar
{
    internal abstract class BaseRepository<TEntity , Tkey> : IRepository<TEntity , Tkey> where TEntity : IEntity<Tkey>
    {
        //bunları ben yazdım ama kabul etmedi
        TEntity GetById(Tkey key)
        {
            throw new NotImplementedException();
        }

        List<TEntity> GetAll()
        {
            throw new NotImplementedException ();
        }


        //bunları kendi implemente etti 
        TEntity IRepository<TEntity, Tkey>.GetById(Tkey key)
        {
            return GetById(key);
        }

        List<TEntity> IRepository<TEntity, Tkey>.GetAll()
        {
            return GetAll();
        }
    }
}
