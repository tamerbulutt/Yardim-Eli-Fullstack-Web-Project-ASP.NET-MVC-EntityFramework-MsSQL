//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YardımEliWeb.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbYardımEliDonatersEntities : DbContext
    {
        public dbYardımEliDonatersEntities()
            : base("name=dbYardımEliDonatersEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblBilgilendirme> tblBilgilendirme { get; set; }
        public virtual DbSet<tblDonaters> tblDonaters { get; set; }
        public virtual DbSet<tblEsyaBagiscilari> tblEsyaBagiscilari { get; set; }
        public virtual DbSet<tblHikayeler> tblHikayeler { get; set; }
        public virtual DbSet<tblHizmetler> tblHizmetler { get; set; }
        public virtual DbSet<tblKullanıcılar> tblKullanıcılar { get; set; }
        public virtual DbSet<tblNakliyeciler> tblNakliyeciler { get; set; }
    }
}
