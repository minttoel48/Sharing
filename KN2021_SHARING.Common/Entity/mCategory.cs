using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN2021_SHARING.Common.Entity
{
    public class mCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mCategory()
        {
            this.mItems = new HashSet<mItem>();
        }

        public int intCategoryId { get; set; }
        public string txtCategoryName { get; set; }
        public System.DateTime dtCreated { get; set; }
        public string txtCreatedBy { get; set; }
        public System.DateTime dtUpdated { get; set; }
        public string txtUpdatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mItem> mItems { get; set; }
        
    }
}
