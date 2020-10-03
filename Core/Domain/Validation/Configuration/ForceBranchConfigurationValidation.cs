using Core.Domain.ViewModel.Configuration;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Validation.Configuration
{
    public class ForceBranchConfigurationValidation : AbstractValidator<ForceBranchWorkingTimeModel>
    {
        public ForceBranchConfigurationValidation()
        {
            Include(new BranchConfigurationValidation());
        }
    }
}
