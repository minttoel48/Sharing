﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GVNMESEntities : DbContext
    {
        public GVNMESEntities()
            : base("name=GVNMESEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<mCategory> mCategories { get; set; }
        public virtual DbSet<mItem> mItems { get; set; }
        public virtual DbSet<mUser> mUsers { get; set; }
        public virtual DbSet<tCartDetail> tCartDetails { get; set; }
        public virtual DbSet<tCartHeader> tCartHeaders { get; set; }
    }
}
