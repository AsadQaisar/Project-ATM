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
    
    public partial class tbl_DropdownType
    {
        public int DocumentTypeID { get; set; }
        public string Description { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifyOn { get; set; }
        public Nullable<int> ModifyBy { get; set; }
        public bool IsActive { get; set; }
    }
}
