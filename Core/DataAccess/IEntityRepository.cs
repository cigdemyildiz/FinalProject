using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//Core katmanı diğer katmanları referans almaz, bağımsız olmalı!!!
namespace Core.DataAccess
{
    //generic constraint (kısıt)
    //class: referans tip olabilir demek
    //IEntity: class IEntity olmalı ya da IEntity yi implement eden bir nesne olabilir dedik
    //new(): newlenebilir olmalı yani artık IEntity de parametre veremeyiz 
   public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
