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
    
    public partial class staff
    {
        public staff()
        {
            this.teams = new HashSet<team>();
        }
    
        public long id { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string skype { get; set; }
        public string phone_number { get; set; }
    
        public virtual ICollection<team> teams { get; set; }
    }
}
