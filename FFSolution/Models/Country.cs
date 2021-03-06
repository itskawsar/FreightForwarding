//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FFSolution.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Country
    {
        public Country()
        {
            this.Agent = new HashSet<Agent>();
            this.Port = new HashSet<Port>();
            this.Tran = new HashSet<Tran>();
        }
    
        public int CountryID { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public string Updator { get; set; }
        public string CountryName { get; set; }
    
        public virtual ICollection<Agent> Agent { get; set; }
        public virtual ICollection<Port> Port { get; set; }
        public virtual ICollection<Tran> Tran { get; set; }
    }
}
