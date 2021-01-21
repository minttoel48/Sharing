using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN2021_SHARING.Common.Entity
{
    public class mUser
    {
        public int intUserId { get; set; }
        public string txtUsername { get; set; }
        public string txtPassword { get; set; }
        public string txtFullname { get; set; }
        public string txtEmail { get; set; }
        public System.DateTime dtCreated { get; set; }
        public string txtCreatedBy { get; set; }
        public System.DateTime dtUpdated { get; set; }
        public string txtUpdatedBy { get; set; }
    }
}
