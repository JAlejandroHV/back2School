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
    
    public partial class Class_Attendance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Class_Attendance()
        {
            this.Class_Attendance_Detail = new HashSet<Class_Attendance_Detail>();
        }
    
        public int Attendance_Id { get; set; }
        public string Attendance_Topic { get; set; }
        public System.TimeSpan Attendance_Start_Time { get; set; }
        public System.TimeSpan Attendance_End_Time { get; set; }
        public System.DateTime Attendance_Date { get; set; }
        public string Staff_Id { get; set; }
        public int Lesson_Id { get; set; }
        public int Group_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class_Attendance_Detail> Class_Attendance_Detail { get; set; }
        public virtual Group Group { get; set; }
        public virtual Lesson Lesson { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
