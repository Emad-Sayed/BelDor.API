using Core.Domain.Entity.Access;
using Core.Domain.UOW;
using Core.Domain.ViewModel;
using Core.Infrastrcture.Service;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Service.User
{
    public class UserService : IUserService
    {
        private UserManager<AppUser> userManager;
        public readonly IUOW UOW;
        public readonly IResponse response;
        public UserService(IUOW uow_, IResponse response_, UserManager<AppUser> userManager_)
        {
            userManager = userManager_;
            UOW = uow_;
            response = response_;
        }

        public int IfEmpployeeGetBranchDepartement(int EmployeeId)
        {
            var query = UOW.Employees.SingleOrDefault(e => e.UserId == EmployeeId);
            return query != null ? query.BranchDepartementId : -1;
        }
    }
}
