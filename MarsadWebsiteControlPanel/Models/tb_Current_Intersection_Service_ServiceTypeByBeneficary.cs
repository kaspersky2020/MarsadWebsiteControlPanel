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
    
    public partial class tb_Current_Intersection_Service_ServiceTypeByBeneficary
    {
        public string ServiceID { get; set; }
        public int ServiceTypeByBeneficiaryID { get; set; }
        public string ImportingDate { get; set; }
        public string VersionNumber { get; set; }
        public string VersionDate { get; set; }
        public string DataSourceName { get; set; }
        public string MyComments { get; set; }
    
        public virtual tb_List_ServiceTypeByBeneficiary tb_List_ServiceTypeByBeneficiary { get; set; }
        public virtual tb_Current_Service tb_Current_Service { get; set; }
    }
}
