﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_IlkOrnek
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EntityFrameworkLINQ_SinavOgrenciEntities : DbContext
    {
        public EntityFrameworkLINQ_SinavOgrenciEntities()
            : base("name=EntityFrameworkLINQ_SinavOgrenciEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_dersler> tbl_dersler { get; set; }
        public virtual DbSet<tbl_notlar> tbl_notlar { get; set; }
        public virtual DbSet<tbl_ogrenci> tbl_ogrenci { get; set; }
        public virtual DbSet<tbl_kulupler> tbl_kulupler { get; set; }
    
        public virtual ObjectResult<not_listesi_Result> not_listesi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<not_listesi_Result>("not_listesi");
        }
    }
}