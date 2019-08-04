using Microsoft.EntityFrameworkCore;
using MyDDD.Domain.Interfaces;
using MyDDD.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Infrastructure.Repositories
{
    public class Repository<Entity> : IRepository<Entity>
        where Entity : class
    {
        protected readonly StudyContext Db;
        protected readonly DbSet<Entity> DbSet;
        public Repository(StudyContext context)
        {
            Db = context;
            DbSet = Db.Set<Entity>();
        }
        public void Add(Entity entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(Guid Id)
        {
            DbSet.Remove(DbSet.Find(Id));
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Entity> GetAll()
        {
            return DbSet;
        }

        public Entity GetById(Guid Id)
        {
            return DbSet.Find(Id);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Update(Entity entity)
        {
            DbSet.Update(entity);
        }
    }
}
