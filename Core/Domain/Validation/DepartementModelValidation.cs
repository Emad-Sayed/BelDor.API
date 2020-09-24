using Core.Domain.ViewModel.Lookups.Departement;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Validation
{
    public class DepartementModelValidation : AbstractValidator<DepartementCreateModel>
    {
        public DepartementModelValidation()
        {
            RuleFor(x => x.NameAR).NotNull().NotEmpty();
            RuleFor(x => x.NameEN).NotNull().NotEmpty();
        }
    }
}
