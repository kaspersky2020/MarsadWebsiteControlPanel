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
    
    public partial class tb_Current_Intersection_Service_Dataset
    {
        public string ServiceID { get; set; }
        public string ConsumerID { get; set; }
        public int DatasetID { get; set; }
        public string ProviderID { get; set; }
        public string DatasetActivatedToUsedByService { get; set; }
        public string GSBDatasetID { get; set; }
        public string ImportingDate { get; set; }
        public string VersionNumber { get; set; }
        public string VersionDate { get; set; }
        public string DataSourceName { get; set; }
    
        public virtual tb_Current_MarsadDataset tb_Current_MarsadDataset { get; set; }
        public virtual tb_Current_Service tb_Current_Service { get; set; }
    }
}