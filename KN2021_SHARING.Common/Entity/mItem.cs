using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN2021_SHARING.Common.Entity
{
    public class mItem
    {
        public int intItemId { get; set; }
        public int intCategoryId { get; set; }
        public string txtItemName { get; set; }
        public string txtItemDescription { get; set; }
        public int intHarga { get; set; }
        public System.DateTime dtCreated { get; set; }
        public string txtCreatedBy { get; set; }
        public System.DateTime dtUpdated { get; set; }
        public string txtUpdatedBy { get; set; }

        public virtual mCategory mCategory { get; set; }
    }
}
