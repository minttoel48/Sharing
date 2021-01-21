using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN2021_SHARING.Common.ViewModel
{
    public class clsCartViewModels
    {
        public int intCartHeaderId { get; set; }
        public int intUserId { get; set; }
        public string txtFullname { get; set; }
        public string txtCartNumber { get; set; }
        public int intCartDetailId { get; set; }       
        public int intItemId { get; set; }
        public string ItemName { get; set; }
        public string txtItemDescription { get; set; }
        public int intQty { get; set; }
    }
}
