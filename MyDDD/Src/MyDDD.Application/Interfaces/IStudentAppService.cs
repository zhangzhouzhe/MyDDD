using MyDDD.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Application.Interfaces
{
    public interface IStudentAppService : IDisposable
    {
        void Register(StudentViewModel studentViewModel);
        IEnumerable<StudentViewModel> GetAll();
        StudentViewModel GetById(Guid id);
        void Update(StudentViewModel studentViewModel);
        void Remove(Guid id);
    }
}
