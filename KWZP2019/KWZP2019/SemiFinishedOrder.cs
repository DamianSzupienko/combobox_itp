//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2019
{
    using System;
    using System.Collections.Generic;
    
    public partial class SemiFinishedOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SemiFinishedOrder()
        {
            this.SfOrderDetails = new HashSet<SfOrderDetail>();
        }
    
        public int IdSfOrder { get; set; }
        public int IdSupplier { get; set; }
        public System.DateTime SfOrderDate { get; set; }
        public System.DateTime SfDeliveryDate { get; set; }
        public decimal Cost { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SfOrderDetail> SfOrderDetails { get; set; }
    }
}
