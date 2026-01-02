using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSorusuTekrar
{
    internal interface IRepository<TEntity , Tkey> where TEntity : IEntity<Tkey>
    {
        TEntity GetById(Tkey key);

        List<TEntity> GetAll();
    }
}
