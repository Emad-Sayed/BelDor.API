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
        (int,int) IfClerkGetMetaData(int ClerkId);
        Task<IResponse> CreateVisitor(RegisterationModel visitor);
        Task<IResponse> CreateManagerOrEmployee(AddManagerOrEmployee clerk);
    }
}
