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
    
    public partial class ProjectDonor
    {
        public ProjectDonor()
        {
            this.Approvers = new HashSet<Approver>();
            this.Assets = new HashSet<Asset>();
            this.Assets1 = new HashSet<Asset>();
            this.AssetManagments = new HashSet<AssetManagment>();
            this.BudgetCategories = new HashSet<BudgetCategory>();
            this.DocumentPreparers = new HashSet<DocumentPreparer>();
            this.OrderRequests = new HashSet<OrderRequest>();
            this.ProcurementPlans = new HashSet<ProcurementPlan>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ProjectId { get; set; }
        public System.Guid DonorId { get; set; }
        public Nullable<System.Guid> CurrencyId { get; set; }
        public string ProjectNumber { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.Guid ProjectManagerId { get; set; }
        public Nullable<double> OverrunAdjustment { get; set; }
    
        public virtual ICollection<Approver> Approvers { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<Asset> Assets1 { get; set; }
        public virtual ICollection<AssetManagment> AssetManagments { get; set; }
        public virtual ICollection<BudgetCategory> BudgetCategories { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual ICollection<DocumentPreparer> DocumentPreparers { get; set; }
        public virtual Donor Donor { get; set; }
        public virtual ICollection<OrderRequest> OrderRequests { get; set; }
        public virtual ICollection<ProcurementPlan> ProcurementPlans { get; set; }
        public virtual Project Project { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}