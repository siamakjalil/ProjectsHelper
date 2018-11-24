using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
   public class LoginViewModel
    {
        public string MobileNumber { get; set; }
        public string ReagentCode { get; set; }
    }
    public class UserNameLoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class ActivationViewModel
    {
        public string MobileNumber { get; set; }
        public string ActiveCode { get; set; }
        public string OneSignalId { get; set; }
        public string Pass { get; set; }

    }
}
