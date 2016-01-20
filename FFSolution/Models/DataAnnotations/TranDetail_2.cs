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
    [MetadataType(typeof(TranDetailMetaData))]
    public partial class TranDetail
    {
    }
    public partial class TranDetailMetaData
    {
        public int TranID { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public string Updator { get; set; }
        [System.ComponentModel.DisplayName("Demurrage Free Days")]
        public Nullable<int> DemurrageFreeDays { get; set; }
        [System.ComponentModel.DisplayName("Demurrage Over Days")]
        public Nullable<int> DemurrageOverDays { get; set; }
        [System.ComponentModel.DisplayName("Demurrage Cost")]
        public Nullable<decimal> DemurrageCost { get; set; }

        public Nullable<int> DemurrageCostCurrencyID { get; set; }
        [System.ComponentModel.DisplayName("Next Collect Date")]

        [DataType(DataType.Date),DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> CollectDate { get; set; }

        [System.ComponentModel.DisplayName("Remaining Amounts Notes")]
        public string RemainingAmountNotes { get; set; }

        [System.ComponentModel.DisplayName("Is Transaction Payment Finsihed ?")]
        public bool PaymentFinished { get; set; }


        [System.ComponentModel.DisplayName("Label of Additional Field 1")]
        public bool AdditionalField1Label { get; set; }


        [System.ComponentModel.DisplayName("Label of Additional Field 2")]
        public bool AdditionalField2Label { get; set; }

        [System.ComponentModel.DisplayName("Transaction Status")]
        public Nullable<int> StatusID { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual Tran Tran { get; set; }
    }
}