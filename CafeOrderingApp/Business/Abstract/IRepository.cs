using CafeOrderingApp.Data;
using CafeOrderingApp.Models;
using CafeOrderingApp.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Business
{
    public interface IRepository<T, in TId> where T : BaseEntity
    {
        T GetById(TId id);
        IQueryable<T> Get(Func<T, bool> predicate = null);
        void Add(T entity, bool isSaveLater = false);
        void Remove(T entity, bool isSaveLater = false);
        void Update(T entity, bool isSaveLater = false);
        int Save();

    }
}
