using Core.Domain.Entity.LocationEntites;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Lookups.Departement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Repository
{
    public interface IDepartementRepository : IRepository<Departement>
    {
        (IEnumerable<DepartementViewModel>, int) DepartementFilter(BaseSearch search);
    }
}
