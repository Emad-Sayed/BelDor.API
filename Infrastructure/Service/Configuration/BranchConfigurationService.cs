using Core.Domain.Entity;
using Core.Domain.UOW;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Configuration;
using Core.Helpers;
using Core.Infrastrcture.Service;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Service.Configuration
{
    public class BranchConfigurationService : IBranchConfiguration
    {
        public readonly IUOW UOW;
        public readonly IResponse response;
        public BranchConfigurationService(IUOW uow_, IResponse response_)
        {
            UOW = uow_;
            response = response_;
        }
        public IResponse GetBackToDefaultTime(int BranchId)
        {
            var ServerDateTime = DateTime.Now.AddServerTimeHours();
            var SelectedBranchTime = UOW.BranchConfigurations.SingleOrDefault(bc => bc.BranchId == BranchId && bc.CreatedAt.Date == ServerDateTime.Date);
            if (SelectedBranchTime != null)
            {
                UOW.BranchConfigurations.Remove(SelectedBranchTime);
            }
            UOW.Compelete();
            return response;
        }

        public IResponse GetBranchTime(int BranchId)
        {
            var ServerDateTime = DateTime.Now.AddServerTimeHours();
            var SelectedBranchTime = UOW.BranchConfigurations.SingleOrDefault(bc => bc.BranchId == BranchId && bc.CreatedAt.Date == ServerDateTime.Date);
            if (SelectedBranchTime != null)
                response.data = SelectedBranchTime;
            else
                response.data = UOW.Configurations.SingleOrDefault(c => true);
            return response;
        }

        public IResponse SetBranchTime(BranchWorkingTimeModel workingTime, int ManagerId, int BranchId)
        {
            var ServerDateTime = DateTime.Now.AddServerTimeHours();
            var SelectedBranchTime = UOW.BranchConfigurations.SingleOrDefault(bc => bc.BranchId == BranchId && bc.CreatedAt.Date == ServerDateTime.Date);
            if (SelectedBranchTime != null)
            {
                SelectedBranchTime.StartTime = TimeSpan.Parse(workingTime.Start);
                SelectedBranchTime.EndTime = TimeSpan.Parse(workingTime.End);
                SelectedBranchTime.UpdatedById = ManagerId;
            }
            else
            {
                UOW.BranchConfigurations.Add(new BranchConfiguration()
                { StartTime = TimeSpan.Parse(workingTime.Start), EndTime = TimeSpan.Parse(workingTime.End), BranchId = BranchId, CreatedById = ManagerId });
            }
            UOW.Compelete();
            return response;
        }
    }
}
