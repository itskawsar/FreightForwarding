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
    
    public partial class Measurement
    {
        public Measurement()
        {
            this.ShippingMode = new HashSet<ShippingMode>();
        }
    
        public int MeaurementID { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public string Updator { get; set; }
        public string MeasurementName { get; set; }
        public string MeasurementDescription { get; set; }
    
        public virtual ICollection<ShippingMode> ShippingMode { get; set; }
    }
}
