using Core.Domain.Entity.LocationEntites;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Lookups.Branch;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Repository
{
    public interface IBranchRepository: IRepository<Branch>
    {
        object GetBranchRelations(int id);
        (IEnumerable<BranchViewModel>, int) BranchFilter(BaseSearch search);
    }
}
