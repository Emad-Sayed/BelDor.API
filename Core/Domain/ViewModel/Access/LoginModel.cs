using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Access
{
    public class LoginModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool rememberMe { get; set; }
    }
}
