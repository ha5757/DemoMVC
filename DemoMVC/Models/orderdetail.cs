//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class orderdetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orderdetail()
        {
            this.orderproducts = new HashSet<orderproduct>();
        }
    
        public int orderid { get; set; }
        public string orderdesc { get; set; }
        public System.DateTime orderdate { get; set; }
        public int discount { get; set; }
        public Nullable<int> customerid { get; set; }
        public Nullable<int> salesmanid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderproduct> orderproducts { get; set; }
    }
}
