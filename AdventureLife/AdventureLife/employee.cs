//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureLife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee()
        {
            this.reservations = new HashSet<reservation>();
            this.activities = new HashSet<activity>();
        }
        
        [HiddenInput(DisplayValue = false)]
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public Nullable<int> phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        public string initial { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservation> reservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<activity> activities { get; set; }
    }
}
