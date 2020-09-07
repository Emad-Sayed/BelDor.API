using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel
{
    public interface IResponse 
    {
        public bool status { get; set; }
        public string error_AR { get; set; }
        public string error_EN { get; set; }
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public int pagesTotalNumber { get; set; }
        public int pagesTotalRows { get; set; }
        public object data { get; set; }
    }
}
