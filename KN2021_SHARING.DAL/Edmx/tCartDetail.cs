//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KN2021_SHARING.DAL.Edmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class tCartDetail
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
