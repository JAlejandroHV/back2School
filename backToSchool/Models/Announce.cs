//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace backToSchool.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Announce
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Announce()
        {
            this.Groups = new HashSet<Group>();
        }
    
        public int Announce_Id { get; set; }
        public System.DateTime Announce_Creation { get; set; }
        public System.DateTime Announce_Expiration { get; set; }
        public string Announce_Message { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group> Groups { get; set; }
    }
}
