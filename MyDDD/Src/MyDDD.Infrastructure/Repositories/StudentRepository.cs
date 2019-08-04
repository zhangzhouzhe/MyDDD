using MyDDD.Domain.Interfaces;
using MyDDD.Domain.Model;
using MyDDD.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Infrastructure.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(StudyContext context) : base(context)
        {
        }

        public Student GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
