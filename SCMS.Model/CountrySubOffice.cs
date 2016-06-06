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
    
    public partial class CountrySubOffice
    {
        public CountrySubOffice()
        {
            this.Assets = new HashSet<Asset>();
            this.CompletionCertificates = new HashSet<CompletionCertificate>();
            this.CompletionCertificates1 = new HashSet<CompletionCertificate>();
            this.GoodsReceivedNotes = new HashSet<GoodsReceivedNote>();
            this.ProcurementPlans = new HashSet<ProcurementPlan>();
            this.Staffs = new HashSet<Staff>();
            this.WareHouses = new HashSet<WareHouse>();
            this.WayBills = new HashSet<WayBill>();
            this.WayBills1 = new HashSet<WayBill>();
            this.WayBills2 = new HashSet<WayBill>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> LocationId { get; set; }
        public Nullable<System.Guid> CountryProgrammeId { get; set; }
        public string Name { get; set; }
        public bool IsCountryHeadOffice { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<CompletionCertificate> CompletionCertificates { get; set; }
        public virtual ICollection<CompletionCertificate> CompletionCertificates1 { get; set; }
        public virtual CountryProgramme CountryProgramme { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<GoodsReceivedNote> GoodsReceivedNotes { get; set; }
        public virtual ICollection<ProcurementPlan> ProcurementPlans { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
        public virtual ICollection<WareHouse> WareHouses { get; set; }
        public virtual ICollection<WayBill> WayBills { get; set; }
        public virtual ICollection<WayBill> WayBills1 { get; set; }
        public virtual ICollection<WayBill> WayBills2 { get; set; }
    }
}