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
    
    public partial class TBL_CAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_CAR()
        {
            this.TBL_RENTAL = new HashSet<TBL_RENTAL>();
        }
    
        public string CAR_NO { get; set; }
        public int CAR_MODEL_ID { get; set; }
        public int KILOMETRES_TRAVELLED { get; set; }
        public int SERVICE_KILOMETRES { get; set; }
        public Nullable<bool> AVAILABLE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_RENTAL> TBL_RENTAL { get; set; }
        public virtual TBL_CAR_MODEL TBL_CAR_MODEL { get; set; }
    }
}
