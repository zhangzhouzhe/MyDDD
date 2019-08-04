using MyDDD.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Domain.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        Student GetByEmail(string email);
    }
}
