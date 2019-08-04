using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Domain.Interfaces
{
    public interface IRepository<Entity> : IDisposable
        where Entity : class

    {
        void Add(Entity entity);
        void Update(Entity entity);
        int SaveChanges();
        void Delete(Guid Id);

        Entity GetById(Guid Id);
        IEnumerable<Entity> GetAll();
    }
}
