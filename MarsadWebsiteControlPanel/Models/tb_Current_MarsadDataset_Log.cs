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
    
    public partial class tb_Current_MarsadDataset_Log
    {
        public int ID { get; set; }
        public int DatasetID { get; set; }
        public string DatasetName_Old { get; set; }
        public string DatasetName { get; set; }
        public string DatasetAvaiableOnGSB { get; set; }
        public Nullable<int> NumberOfServicesConsuimngDataset { get; set; }
        public Nullable<int> NumberOfConsumers { get; set; }
        public string ProviderID { get; set; }
        public Nullable<bool> ShowInResult { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModificationDate { get; set; }
        public Nullable<short> RowNumber { get; set; }
    }
}
