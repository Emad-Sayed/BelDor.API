using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel
{
    public class BaseSearch
    {
        public string keyWord { get; set; }
        public int pageNumber { get; set; } = 1;
        public int pageSize { get; set; } = 10;
    }
}
