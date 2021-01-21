using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN2021_SHARING.Common.Entity
{
    public class tCartHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tCartHeader()
        {
            this.tCartDetails = new HashSet<tCartDetail>();
        }

        public int intCartHeaderId { get; set; }
        public int intUserId { get; set; }
        public string txtCartNumber { get; set; }
        public System.DateTime dtCreated { get; set; }
        public string txtCreatedBy { get; set; }
        public System.DateTime dtUpdated { get; set; }
        public string txtUpdatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tCartDetail> tCartDetails { get; set; }
    }
}
