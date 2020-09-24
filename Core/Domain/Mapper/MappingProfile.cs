using AutoMapper;
using Core.Domain.Entity.LocationEntites;
using Core.Domain.ViewModel.Lookups.Branch;
using Core.Domain.ViewModel.Lookups.Departement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BranchCreateModel, Branch>();
            CreateMap<DepartementCreateModel, Departement>();
        }
    }
}
