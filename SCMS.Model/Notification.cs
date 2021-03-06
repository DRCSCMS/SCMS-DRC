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
    
    public partial class Notification
    {
        public System.Guid Id { get; set; }
        public System.Guid ApproverId { get; set; }
        public bool SentToDelegate { get; set; }
        public System.DateTime SendDate { get; set; }
        public bool IsRespondedTo { get; set; }
        public Nullable<System.DateTime> ResponseDate { get; set; }
        public Nullable<System.Guid> OrderRequestId { get; set; }
        public Nullable<System.Guid> TenderAnalysisId { get; set; }
        public Nullable<System.Guid> PurchaseOrderId { get; set; }
        public Nullable<System.Guid> PaymentRequestId { get; set; }
        public Nullable<System.Guid> GoodsReceivedNoteId { get; set; }
        public Nullable<System.Guid> WarehouseReleaseId { get; set; }
        public Nullable<System.Guid> ProcurementPlanId { get; set; }
    
        public virtual Approver Approver { get; set; }
        public virtual GoodsReceivedNote GoodsReceivedNote { get; set; }
        public virtual OrderRequest OrderRequest { get; set; }
        public virtual PaymentRequest PaymentRequest { get; set; }
        public virtual ProcurementPlan ProcurementPlan { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual WarehouseRelease WarehouseRelease { get; set; }
    }
}
