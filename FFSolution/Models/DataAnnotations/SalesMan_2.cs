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
    using System.ComponentModel.DataAnnotations;
    [MetadataType(typeof(SalesManMetaData))]
    public partial class SalesMan
    {
    }
    public partial class SalesManMetaData
    {
     [System.ComponentModel.DisplayName("Sales Man ID")]
        public int SalesManID { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public string Updator { get; set; }
        [System.ComponentModel.DisplayName("Sales Man Name")]
        public string SalesManName { get; set; }
        [System.ComponentModel.DisplayName("Sales Man Phone")]
        public string SalesManPhone { get; set; }
        [System.ComponentModel.DisplayName("Asscoiated User Name")]
        public string UserName { get; set; }
    
        public virtual ICollection<Tran> Tran { get; set; }
    }
}
