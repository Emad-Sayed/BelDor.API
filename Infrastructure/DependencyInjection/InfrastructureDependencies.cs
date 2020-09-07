﻿using Core.Domain.ViewModel;
using Core.Infrastrcture.Service;
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
            services.AddTransient<IUserService, UserService>();
        }
    }
}
