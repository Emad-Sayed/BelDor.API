using Core.Domain.ViewModel.Access;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Validation.Access
{
    public class AddManagerOrEmployeeValidation : AbstractValidator<AddManagerOrEmployee>
    {
        public AddManagerOrEmployeeValidation()
        {
            RuleFor(x => x.RoleName).NotNull().NotEmpty().Must(d => d.Equals("MANAGER") || d.Equals("EMPLOYEE"));
        }
    }
}
