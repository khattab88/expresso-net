using Api.Dtos;
using AutoMapper;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Mappings
{
    public class DtoToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DtoToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<TagDto, Tag>();
        }
    }
}