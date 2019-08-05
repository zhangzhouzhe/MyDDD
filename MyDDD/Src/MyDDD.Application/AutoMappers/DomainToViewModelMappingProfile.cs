using AutoMapper;
using MyDDD.Application.ViewModels;
using MyDDD.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Application.AutoMappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Student, StudentViewModel>();
            });
        }
    }
}
