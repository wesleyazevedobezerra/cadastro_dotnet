using Cadastro.Domain.Contracts.Interfaces;
using Cadastro.Domain.Entities.Base;
using Cadastro.Infrastructure.Data.Context;
using Cadastro.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> :  IRepository<TEntity> where TEntity : class
    {
        protected readonly CadastroContext Db;
        protected readonly DbSet<TEntity> DbSet;
        private bool _disposed = false;

        public Repository(CadastroContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
            Db.SaveChanges();
        }

        public void AddRange(IEnumerable<TEntity> obj)
        {
            DbSet.AddRange(obj);
            Db.SaveChanges();
        }


        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual TEntity GetById(int id)
        {
            try
            {
                var entity = DbSet.Find(id);
                return entity;
            }
            catch { return null; }
        }

        public void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
            Db.SaveChanges();
        }

        public void RemoveRange(IEnumerable<TEntity> obj)
        {
            DbSet.RemoveRange(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj, int id)
        {
            if (obj != null)
            {
                TEntity existing = Db.Set<TEntity>().Find(id);

                if (existing != null)
                {
                    Db.Entry(obj).State = EntityState.Modified;

                }

                Db.SaveChanges();

                Db.Entry(obj).State = EntityState.Detached;
                Db.SaveChanges();
            }
        }
    }
}