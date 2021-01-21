using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN2021_SHARING.Common.Entity
{
    public class tCartDetail
    {
        public int intCartDetailId { get; set; }
        public int intCartHeaderId { get; set; }
        public int intItemId { get; set; }
        public int intQty { get; set; }
        public System.DateTime dtCreated { get; set; }
        public string txtCreatedBy { get; set; }
        public System.DateTime dtUpdated { get; set; }
        public string txtUpdatedBy { get; set; }

        public virtual tCartHeader tCartHeader { get; set; }
    }
}
