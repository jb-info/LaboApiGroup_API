using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_Repo.Interfaces
{
    public interface IRepository<TKey, TEntity>
        where TEntity : IEntity<TKey>
    {
        TEntity Get(TKey id);
        IEnumerable<TEntity> GetAll();
        TKey Insert(TEntity entity);
        bool Update(TEntity data);
        bool Delete(TEntity id);


    }
}
