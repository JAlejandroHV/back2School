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
    
    public partial class Group_Attendance
    {
        public int Group_Id { get; set; }
        public System.DateTime Group_Date { get; set; }
    
        public virtual Group Group { get; set; }
    }
}
