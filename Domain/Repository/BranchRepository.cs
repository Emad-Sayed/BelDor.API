using Core.Domain.Entity.LocationEntites;
using Core.Domain.Repository;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Lookups.Branch;
using Domain.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace Domain.Repository
{
    public class BranchRepository : Repository<Branch>, IBranchRepository
    {
        public BranchRepository(AppDbContext _Context) : base(_Context)
        {
        }

        public (IEnumerable<BranchViewModel>, int) BranchFilter(BaseSearch search)
        {
            var query = Context.Branches.Where(b => String.IsNullOrEmpty(search.keyWord) ||
            b.NameEN.Contains(search.keyWord) || b.NameAR.Contains(search.keyWord))
                .Select(t => new BranchViewModel
                {
                    Id = t.Id,
                    NameAR = t.NameAR,
                    NameEN = t.NameEN,
                    CreatedyId = t.CreatedBy.Id,
                    CreatedName = t.CreatedBy.UserName
                });
            var count = query.Count();
            var data = query.OrderBy(c => c.Id).Skip((search.pageNumber - 1) * search.pageSize).Take(search.pageSize);
            return (data, count);
        }
        public object GetBranchRelations(int id)
        {
            var query = Context.BranchDepartement.Include(b => b.Branch).Include(b => b.Departement).Where(b => b.BranchId == id).ToList();
            var groupedData = query.GroupBy(g => g.BranchId).Select(b => new
            {
                BranchId = b.Key,
                BranchAR = b.First().Branch.NameAR,
                BranchEN = b.First().Branch.NameEN,
                Departements = b.Select(item => new
                {
                    DepartementId = item.DepartementId,
                    DepartementNameAR = item.Departement.NameAR,
                    DepartementNameEN = item.Departement.NameEN
                })
            });
            return groupedData;
        }
    }
}
