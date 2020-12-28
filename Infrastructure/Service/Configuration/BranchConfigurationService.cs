using Core.Domain.Entity;
using Core.Domain.UOW;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Configuration;
using Core.Helpers;
using Core.Infrastrcture.Service;
using Hangfire;
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
        public IResponse SetDefaultTime(BranchWorkingTimeModel model)
        {
            var startTime = TimeSpan.Parse(model.Start);
            var endTime = TimeSpan.Parse(model.End);
            var start = new DateTime(2000, 10, 10, startTime.Hours, startTime.Minutes, 0).AddHours(-2); //To convert to UTC
            var end = new DateTime(2000, 10, 10, endTime.Hours, endTime.Minutes, 0).AddHours(-2);//To convert to UTC
            RecurringJob.AddOrUpdate(() => OpenQueue(model), Cron.Daily(start.TimeOfDay.Hours, start.TimeOfDay.Minutes));
            RecurringJob.AddOrUpdate(() => CloseQueue(), Cron.Daily(end.TimeOfDay.Hours, end.TimeOfDay.Minutes));
            return response;
        }
        public void OpenQueue(BranchWorkingTimeModel model)
        {
            var newQueue = new ActiveQueue() { StartHour = TimeSpan.Parse(model.Start), EndHour = TimeSpan.Parse(model.End) };
            UOW.ActiveQueues.Add(newQueue);
            UOW.Compelete();
        }
        public void CloseQueue()
        {
            var selectedActiveQueue = UOW.ActiveQueues.SingleOrDefault(q => q.isActive);
            if (selectedActiveQueue != null)
            {
                selectedActiveQueue.isActive = false;
                UOW.Compelete();
            }
        }


        #region not it's time
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
        #endregion
    }
}
