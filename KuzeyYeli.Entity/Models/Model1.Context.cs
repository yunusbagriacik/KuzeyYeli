﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KuzeyYeli.Entity.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KuzeyYeliEntities : DbContext
    {
        public KuzeyYeliEntities()
            : base("name=KuzeyYeliEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bolge> Bolge { get; set; }
        public virtual DbSet<Bolgeler> Bolgeler { get; set; }
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<MusteriDemographics> MusteriDemographics { get; set; }
        public virtual DbSet<Musteriler> Musteriler { get; set; }
        public virtual DbSet<Nakliyeciler> Nakliyeciler { get; set; }
        public virtual DbSet<Personeller> Personeller { get; set; }
        public virtual DbSet<SatisDetay> SatisDetay { get; set; }
        public virtual DbSet<Satislar> Satislar { get; set; }
        public virtual DbSet<Tedarikciler> Tedarikciler { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
    }
}