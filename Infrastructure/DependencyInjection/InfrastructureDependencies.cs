using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Lookups.Branch;
using Core.Domain.ViewModel.Lookups.Departement;
using Core.Infrastrcture.Notification.SignalR;
using Core.Infrastrcture.Service;
using Infrastructure.Notification.SignalR.Service;
using Infrastructure.Service.Configuration;
using Infrastructure.Service.Lookups;
using Infrastructure.Service.TicketBusinees;
using Infrastructure.Service.User;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DependencyInjection
{
    public static class  InfrastructureDependencies
    {
        public static void InjectInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IResponse, Response>();
            services.AddTransient<INotificationService, NotificationCenterService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITicketService, TicketService>();
            services.AddTransient<IBranchConfiguration, BranchConfigurationService>();
            services.AddTransient<IService<BaseSearch, BranchCreateModel>, BranchService>();
            services.AddTransient<IService<BaseSearch, DepartementCreateModel>, DepartementService>();
        }
    }
}
