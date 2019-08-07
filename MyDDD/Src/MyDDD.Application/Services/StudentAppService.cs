using AutoMapper;
using MyDDD.Application.Interfaces;
using MyDDD.Application.ViewModels;
using MyDDD.Domain.Commands;
using MyDDD.Domain.Core.Bus;
using MyDDD.Domain.Interfaces;
using MyDDD.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Application.Services
{
    public class StudentAppService : IStudentAppService
    {

        private readonly IStudentRepository _studentRepository;

        private readonly IMapper _mapper;

        private readonly IMediatorHandler _bus;

        public StudentAppService(
            IStudentRepository studentRepository,
            IMapper mapper,
            IMediatorHandler bus
            )
        {
            _mapper = mapper;
            _studentRepository = studentRepository;
            _bus = bus;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<StudentViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public StudentViewModel GetById(Guid id)
        {
            return _mapper.Map<StudentViewModel>
                (_studentRepository.GetById(id));
        }

        public void Register(StudentViewModel studentViewModel)
        {
            var registerCommand = _mapper.Map<RegisterStudentCommand>(studentViewModel);
            _bus.SendCommand(registerCommand);


            //_studentRepository.Add(
            //    _mapper.Map<Student>(studentViewModel));
        }

        public void Remove(Guid id)
        {
            _studentRepository.Delete(id);
        }

        public void Update(StudentViewModel studentViewModel)
        {
            _studentRepository.Update(_mapper.Map<Student>(studentViewModel));
        }
    }
}
