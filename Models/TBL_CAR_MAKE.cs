//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ediz_Yurdakul_ST10242585_CLDV6211_POE_Part_3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_CAR_MAKE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_CAR_MAKE()
        {
            this.TBL_CAR_MODEL = new HashSet<TBL_CAR_MODEL>();
        }
    
        public int CAR_MAKE_ID { get; set; }
        public string CAR_MAKE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_CAR_MODEL> TBL_CAR_MODEL { get; set; }
    }
}
