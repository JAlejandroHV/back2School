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
    
    public partial class Student_Relative
    {
        public string Relative_Id { get; set; }
        public string Student_Id { get; set; }
        public string Relation { get; set; }
    
        public virtual Relative Relative { get; set; }
        public virtual Student Student { get; set; }
    }
}
