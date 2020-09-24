using Core.Domain.Entity.LocationEntites;
using Core.Domain.Repository;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Lookups.Departement;
using Domain.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Repository
{
    public class DepartementRepository : Repository<Departement>, IDepartementRepository
    {
        public DepartementRepository(AppDbContext _Context) : base(_Context)
        {
        }

        public (IEnumerable<DepartementViewModel>, int) DepartementFilter(BaseSearch search)
        {
            var query = Context.Departements.Where(b => String.IsNullOrEmpty(search.keyWord) ||
            b.NameEN.Contains(search.keyWord) || b.NameAR.Contains(search.keyWord))
                .Select(t => new DepartementViewModel
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
    }
}
