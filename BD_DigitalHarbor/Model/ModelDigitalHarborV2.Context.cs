﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD_DigitalHarbor.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DIGITAL_HARBOREntitiesV2 : DbContext
    {
        public DIGITAL_HARBOREntitiesV2()
            : base("name=DIGITAL_HARBOREntitiesV2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACTIVIDADES> ACTIVIDADES { get; set; }
        public virtual DbSet<EMPLEADO> EMPLEADO { get; set; }
    }
}
