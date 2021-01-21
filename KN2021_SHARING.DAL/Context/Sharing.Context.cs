using KN2021_SHARING.Common.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN2021_SHARING.DAL.Context
{
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
