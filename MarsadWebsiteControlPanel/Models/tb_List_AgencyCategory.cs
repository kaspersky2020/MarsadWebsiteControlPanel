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
    
    public partial class tb_List_AgencyCategory
    {
        public int AgencyCategoryID { get; set; }
        public string AgencyCategoryName { get; set; }
        public string AgencyCategoryProviderID { get; set; }
    
        public virtual tb_Current_Agency tb_Current_Agency { get; set; }
    }
}
