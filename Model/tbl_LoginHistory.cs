//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_ATM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_LoginHistory
    {
        public int LogID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string IpAddress { get; set; }
        public string MACAddress { get; set; }
        public string SystemName { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
    
        public virtual tbl_User tbl_User { get; set; }
    }
}
