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
    
    public partial class sp_Reports_Consumers_0_1_A_ValidateNoConsumerDependOnDataRelatedToHim_Result
    {
        public int ID { get; set; }
        public string ServiceID { get; set; }
        public string ConsumerID { get; set; }
        public int DatasetID { get; set; }
        public string ProviderID { get; set; }
        public string DatasetActivatedToUsedByService { get; set; }
        public Nullable<int> GSBDatasetID { get; set; }
        public Nullable<System.DateTime> ImportingDate { get; set; }
        public string VersionNumber { get; set; }
        public string VersionDate { get; set; }
        public string DataSourceName { get; set; }
    }
}
