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
    [MetadataType(typeof(FeesInOriginSellingMetaData))]
    public partial class FeesInOriginSelling
    {
    }
    public partial class FeesInOriginSellingMetaData
    {
        public int TranID { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public string Updator { get; set; }
        public bool IsChina { get; set; }
        public Nullable<decimal> THC { get; set; }
        public Nullable<int> THCCurrencyID { get; set; }
        public Nullable<decimal> Truck { get; set; }
        public Nullable<int> TruckCurrencyID { get; set; }
        public Nullable<decimal> CIQ { get; set; }
        public Nullable<int> CIQCurrencyID { get; set; }
        public Nullable<decimal> CO { get; set; }
        public Nullable<int> COCurrencyID { get; set; }
         [System.ComponentModel.DisplayName("Seal Fees")]
        public Nullable<decimal> SealFees { get; set; }
        public Nullable<int> SealFeesCurrencyID { get; set; }
        public Nullable<decimal> Courier { get; set; }
        public Nullable<int> CourierCurrencyID { get; set; }
        public Nullable<decimal> Insurance { get; set; }
        public Nullable<int> InsuranceCurrencyID { get; set; }
         [System.ComponentModel.DisplayName("Customs Clearance")]
        public Nullable<decimal> CustomsClearance { get; set; }
        public Nullable<int> CustomsClearanceCurrencyID { get; set; }
        public Nullable<decimal> Others { get; set; }
        public Nullable<int> OthersCurrencyID { get; set; }
         [System.ComponentModel.DisplayName("Europe All in")]
        public Nullable<decimal> EuropeAllIn { get; set; }
        public Nullable<int> EuropeAllInCurrencyID { get; set; }
    
        //public virtual Currency Currency { get; set; }
        //public virtual Currency Currency1 { get; set; }
        //public virtual Currency Currency2 { get; set; }
        //public virtual Currency Currency3 { get; set; }
        //public virtual Currency Currency4 { get; set; }
        //public virtual Currency Currency5 { get; set; }
        //public virtual Currency Currency6 { get; set; }
        //public virtual Currency Currency7 { get; set; }
        //public virtual Currency Currency8 { get; set; }
        //public virtual Currency Currency9 { get; set; }
        //public virtual Tran Tran { get; set; }
    }
}