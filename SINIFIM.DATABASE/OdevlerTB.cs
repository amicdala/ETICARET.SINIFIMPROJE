//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SINIFIM.DATABASE
{
    using System;
    using System.Collections.Generic;
    
    public partial class OdevlerTB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OdevlerTB()
        {
            this.Odev_GorulduTB = new HashSet<Odev_GorulduTB>();
            this.Odev_TeslimTB = new HashSet<Odev_TeslimTB>();
        }
    
        public int id { get; set; }
        public string baslik { get; set; }
        public string konu { get; set; }
        public string icerik { get; set; }
        public Nullable<System.DateTime> teslimtarih { get; set; }
        public Nullable<int> sinifid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Odev_GorulduTB> Odev_GorulduTB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Odev_TeslimTB> Odev_TeslimTB { get; set; }
        public virtual SanalSinifTB SanalSinifTB { get; set; }
    }
}
