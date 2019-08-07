using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Domain.Interfaces
{
    public interface  IUnitOfWork
    {
        bool Commit();
    }
}
