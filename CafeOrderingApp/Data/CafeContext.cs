using CafeOrderingApp.Models;
using CafeOrderingApp.Models.Abstract;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Data
{
    public class CafeContext :DbContext
    {
       public CafeContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CafeDb;Integrated Security=True;");
            }

        }
        public DbSet<Kat> Katlar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Masa> Masalar { get; set; }

        public override int SaveChanges()
        {
            var entiries = ChangeTracker.Entries()
               .Where(x => x.Entity is BaseEntity && x.State == EntityState.Added);

            foreach (var item in entiries)
            {
                ((BaseEntity)item.Entity).CreatedDate = DateTime.Now;
            }

            entiries = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && x.State == EntityState.Modified);

            foreach (var item in entiries)
            {
                ((BaseEntity)item.Entity).UpdatedDate = DateTime.Now;
            }

            entiries = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && x.State == EntityState.Deleted);

            foreach (var item in entiries)
            {
                ((BaseEntity)item.Entity).DeletedDate = DateTime.Now;
                ((BaseEntity)item.Entity).IsDeleted = true;
                item.State = EntityState.Modified;
            }

            return base.SaveChanges();
        }


    }
}
