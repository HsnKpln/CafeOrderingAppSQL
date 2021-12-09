using CafeOrderingApp.Business.Abstract;
using CafeOrderingApp.Data;
using CafeOrderingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Business
{
    public class KatRepository : RepositoryBase<Kat,int>
    {










        //public CafeContext Context { get; set; }
        //public Kat Get(Guid id)
        //{
        //    return Context.Katlar.FirstOrDefault(x => x.Id == id);
        //}

        //public List<Kat> GetAll(Func<Kat, bool> predicate = null)
        //{
        //    return predicate == null ? Context.Katlar : Context.Katlar.Where(predicate).ToList();
        //}

        //public void Add(Kat item)
        //{
        //    Context.Katlar.Add(item);
        //}

        //public void Remove(Kat item)
        //{
        //    Context.Katlar.Remove(item);
        //    Context.Save();
        //}

        //public void Update()
        //{
        //    Context.Save();
        //}
    }
}
