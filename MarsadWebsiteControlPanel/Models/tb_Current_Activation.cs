//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarsadWebsiteControlPanel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Current_Activation
    {
        public string ConsumerID { get; set; }
        public string ConsumerArabicName { get; set; }
        public string GSBServiceCode { get; set; }
        public string GSBServiceArabicName { get; set; }
        public string GSBOperationCode { get; set; }
        public string GSBOperationArabicName { get; set; }
        public string ProviderID { get; set; }
        public string ProviderArabicName { get; set; }
        public string DatasetID { get; set; }
    
        public virtual tb_Current_Agency tb_Current_Agency { get; set; }
        public virtual tb_Current_Agency tb_Current_Agency1 { get; set; }
        public virtual tb_Current_GSBOperation tb_Current_GSBOperation { get; set; }
        public virtual tb_Current_GSBService tb_Current_GSBService { get; set; }
    }
}
