using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastrcture.Service
{
    public interface IBranchConfiguration
    {
        IResponse SetBranchTime(BranchWorkingTimeModel workingTime, int ManagerId, int BranchId);
        IResponse GetBackToDefaultTime(int BranchId);
        IResponse GetBranchTime(int BranchId);
    }
}
