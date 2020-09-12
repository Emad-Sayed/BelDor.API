using AutoMapper;
using Core.Domain.Entity.LocationEntites;
using Core.Domain.UOW;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Lookups.Branch;
using Core.Infrastrcture.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Service.Lookups
{
    public class BranchService : IService<BaseSearch, BranchCreateModel>
    {
        public readonly IUOW UOW;
        public readonly IResponse response;
        private readonly IMapper mapper;
        public BranchService(IUOW uow_, IResponse response_, IMapper mapper_)
        {
            UOW = uow_;
            response = response_;
            mapper = mapper_;
        }
        public IResponse Create(BranchCreateModel model)
        {
            Branch newBranch = mapper.Map<Branch>(model);
            UOW.Branches.Add(newBranch);
            UOW.Compelete();
            foreach (int id in model.DeptIds)
            {
                var selectedDept = UOW.Departements.SingleOrDefault(d => d.Id == id);
                if (selectedDept != null)
                {
                    var newBranchDepartement = new BranchDepartement() { BranchId = newBranch.Id, DepartementId = id };
                    UOW.BranchDepartement.Add(newBranchDepartement);
                }
            }
            UOW.Compelete();
            return response;
        }

        public IResponse Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IResponse GetAll(BaseSearch search)
        {
            var (result, totalRows) = UOW.Branches.BranchFilter(search);
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
            var data = UOW.Branches.GetBranchRelations(id);
            response.data = data;
            return response;
        }
    }
}
