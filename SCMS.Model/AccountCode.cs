//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountCode
    {
        public System.Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public System.Guid CountryProgrammeId { get; set; }
    
        public virtual CountryProgramme CountryProgramme { get; set; }
    }
}