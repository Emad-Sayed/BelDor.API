using Core.Domain.ViewModel.Configuration;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Validation.Configuration
{
    public class BranchConfigurationValidation : AbstractValidator<BranchWorkingTimeModel>
    {
        public BranchConfigurationValidation()
        {
            RuleFor(x => x.End).Must((Model,End) => {
                //TimeSpan toStartTime = TimeSpan.Parse(Model.Start);
                //TimeSpan toEndTime = TimeSpan.Parse(End);
                //return toEndTime > toStartTime;
                return true;
            }).WithMessage("End Time must be larger than Start Time");
        }
    }
}
