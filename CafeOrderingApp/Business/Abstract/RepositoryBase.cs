using CafeOrderingApp.Data;
using CafeOrderingApp.Models.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Business.Abstract
{
    public abstract class RepositoryBase<T, TId> : IRepository<T, TId> where T : BaseEntity, new()
    {
        protected CafeContext _context;
        public DbSet<T> Table { get; set; }
        public RepositoryBase()
        {
            _context = new CafeContext();
            Table = _context.Set<T>();
        }
        public virtual T GetById(TId id)
        {
            return Table.Find(id);
        }
        public IQueryable<T> Get(Func<T, bool> predicate = null)
        {
            return predicate == null ? Table : Table.Where(predicate).AsQueryable();
        }

        public virtual void Add(T entity, bool isSaveLater = false)
        {
            Table.Add(entity);
                if (!isSaveLater)
                this.Save();
        }

        public virtual void Remove(T entity, bool isSaveLater = false)
        {
            Table.Remove(entity);
            if (!isSaveLater)
                this.Save();
        }

        public virtual void Update(T entity, bool isSaveLater = false)
        {
            Table.Update(entity);
            if (!isSaveLater)
                this.Save();
        }
        public virtual int Save()
        {
           return _context.SaveChanges();
        }
    }
}
