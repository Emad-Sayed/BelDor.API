using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Access;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastrcture.Service
{
    public interface IUserService
    {
        int IfEmpployeeGetBranchDepartement(int EmployeeId);
        Task<IResponse> CreateVisitor(RegisterationModel visitor);
    }
}
