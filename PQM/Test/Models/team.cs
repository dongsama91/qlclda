//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class team
    {
        public team()
        {
            this.projects = new HashSet<project>();
            this.staffs = new HashSet<staff>();
        }
    
        public long id { get; set; }
        public string name { get; set; }
        public string workplace { get; set; }
        public string technique { get; set; }
    
        public virtual ICollection<project> projects { get; set; }
        public virtual ICollection<staff> staffs { get; set; }
    }
}
