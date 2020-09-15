using Core.Domain.Entity.Access;
using Core.Domain.UOW;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Access;
using Core.Infrastrcture.Service;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<IResponse> CreateVisitor(RegisterationModel visitor)
        {
            AppUser newAppUser = new AppUser
            {
                UserName = visitor.UserName,
                Email = visitor.Email,
                EmailConfirmed = true,
            };
            var result = await userManager.CreateAsync(newAppUser, visitor.Password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(newAppUser, "VISITOR");
            }
            else
            {
                response.error_EN = result.Errors.Select(e => e.Description).FirstOrDefault();
                response.status = false;
            }
            return response;
        }
    }
}
