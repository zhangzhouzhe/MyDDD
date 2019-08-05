using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Application.AutoMappers
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(
                config =>
                {
                    config.AddProfile(new DomainToViewModelMappingProfile());
                });
        }
    }
}
