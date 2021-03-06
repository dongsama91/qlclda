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
    
    public partial class project
    {
        public project()
        {
            this.activity_log = new HashSet<activity_log>();
            this.teams = new HashSet<team>();
        }
    
        public long id { get; set; }
        public long id_customer { get; set; }
        public long id_type_project { get; set; }
        public string name_project { get; set; }
        public System.DateTime expected_start_date { get; set; }
        public System.DateTime expected_end_date { get; set; }
        public Nullable<System.DateTime> actual_start_date { get; set; }
        public Nullable<System.DateTime> actual_end_date { get; set; }
        public string technology { get; set; }
        public string purpose { get; set; }
        public string estimator { get; set; }
        public Nullable<int> scale_estimator { get; set; }
        public Nullable<int> contract_value { get; set; }
        public string pm { get; set; }
        public string brse { get; set; }
        public Nullable<int> current_cost { get; set; }
        public Nullable<int> estimated_cost { get; set; }
        public string software { get; set; }
        public string hardware { get; set; }
    
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual customer customer { get; set; }
        public virtual end_project end_project { get; set; }
        public virtual type_project type_project { get; set; }
        public virtual quality quality { get; set; }
        public virtual ICollection<team> teams { get; set; }
    }
}
