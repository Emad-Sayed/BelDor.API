using AutoMapper;
using Core.Domain.Entity.LocationEntites;
using Core.Domain.UOW;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Lookups.Departement;
using Core.Infrastrcture.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Service.Lookups
{
    public class DepartementService : IService<BaseSearch, DepartementCreateModel>
    {
        public readonly IUOW UOW;
        public readonly IResponse response;
        private readonly IMapper mapper;
        public DepartementService(IUOW uow_, IResponse response_, IMapper mapper_)
        {
            UOW = uow_;
            response = response_;
            mapper = mapper_;
        }
        public IResponse Create(DepartementCreateModel model)
        {
            Departement newDepartement = mapper.Map<Departement>(model);
            UOW.Departements.Add(newDepartement);
            UOW.Compelete();
            return response;
        }

        public IResponse Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IResponse GetAll(BaseSearch search)
        {
            var (result, totalRows) = UOW.Departements.DepartementFilter(search);
            response.pagesTotalRows = totalRows;
            float all_pages = (float)totalRows / search.pageSize;
            response.pagesTotalNumber = (int)Math.Ceiling(all_pages);
            response.pageSize = search.pageSize;
            response.pageNumber = search.pageNumber;
            response.data = result;
            return response;
        }

        public IResponse GetById(int id)
        {
            var data = UOW.Departements.SingleOrDefault(d => d.Id == id);
            if (data == null)
                response.status = false;
            else
                response.data = data;
            return response;
        }
    }
}
