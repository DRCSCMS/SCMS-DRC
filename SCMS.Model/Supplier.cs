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
    
    public partial class Supplier
    {
        public Supplier()
        {
            this.GarageInfoes = new HashSet<GarageInfo>();
            this.GoodsReceivedNotes = new HashSet<GoodsReceivedNote>();
            this.PaymentRequests = new HashSet<PaymentRequest>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string Fax { get; set; }
        public string WebAddress { get; set; }
        public string LogoLocation { get; set; }
        public System.Guid CountryId { get; set; }
        public System.Guid CountryProgrammeId { get; set; }
        public bool IsApproved { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual ICollection<GarageInfo> GarageInfoes { get; set; }
        public virtual ICollection<GoodsReceivedNote> GoodsReceivedNotes { get; set; }
        public virtual ICollection<PaymentRequest> PaymentRequests { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
