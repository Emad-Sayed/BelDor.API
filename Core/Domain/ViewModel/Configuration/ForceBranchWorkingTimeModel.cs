using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Configuration
{
    public class ForceBranchWorkingTimeModel : BranchWorkingTimeModel
    {
        public int BranchId { get; set; }
    }
}
