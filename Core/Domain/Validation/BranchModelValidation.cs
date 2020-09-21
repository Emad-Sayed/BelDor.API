using Core.Domain.ViewModel.Lookups.Branch;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Validation
{
    public class BranchModelValidation : AbstractValidator<BranchCreateModel>
    {
        public BranchModelValidation()
        {
            RuleFor(x => x.NameAR).NotNull().NotEmpty();
            RuleFor(x => x.NameEN).NotNull().NotEmpty();
        }
    }
}
