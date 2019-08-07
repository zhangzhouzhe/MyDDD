using MyDDD.Domain.Interfaces;
using MyDDD.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly StudyContext _context;

        public UnitOfWork(StudyContext context)
        {
            _context = context;
        }
        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
