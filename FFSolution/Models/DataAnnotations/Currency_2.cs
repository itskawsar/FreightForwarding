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


    [MetadataType(typeof(CurrencyMetaData))]
    public partial class Currency
    {
    }

    public partial class CurrencyMetaData
    {
           
        public int CurrencyID { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public string Updator { get; set; }
        [System.ComponentModel.DisplayName("Currency Name")]
        public string CurrencyName { get; set; }

        [System.ComponentModel.DisplayName("Currency Code")]
        public string CurrencyCode { get; set; }
      
    }
}
