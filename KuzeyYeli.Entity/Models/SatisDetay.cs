//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class SatisDetay
    {
        public int SatisID { get; set; }
        public int UrunID { get; set; }
        public decimal Fiyat { get; set; }
        public short Adet { get; set; }
        public float Indirim { get; set; }
    
        public virtual Satislar Satislar { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
