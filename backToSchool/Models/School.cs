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
    
    public partial class School
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public School()
        {
            this.Staffs = new HashSet<Staff>();
            this.Students = new HashSet<Student>();
        }
    
        public string School_Id { get; set; }
        public string School_Name { get; set; }
        public string School_Contact_Name { get; set; }
        public string School_Email { get; set; }
        public string School_Number { get; set; }
        public string School_RFC { get; set; }
        public bool School_Status { get; set; }
        public System.DateTime School_Licence_Expiration { get; set; }
        public bool School_Letter_Required { get; set; }
    
        public virtual School_Setup School_Setup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff> Staffs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
