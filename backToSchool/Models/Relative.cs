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
    
    public partial class Relative
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Relative()
        {
            this.Responsible_Letter = new HashSet<Responsible_Letter>();
            this.Student_Relative = new HashSet<Student_Relative>();
        }
    
        public string Relative_Id { get; set; }
        public string Relative_Name { get; set; }
        public string Relative_Last_Name { get; set; }
        public string Relative_Number { get; set; }
        public string Relative_Email { get; set; }
        public bool Relative_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Responsible_Letter> Responsible_Letter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Relative> Student_Relative { get; set; }
    }
}
