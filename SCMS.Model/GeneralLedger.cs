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
    
    public partial class GeneralLedger
    {
        public GeneralLedger()
        {
            this.PaymentVoucherBudgetLines = new HashSet<PaymentVoucherBudgetLine>();
            this.ProjectBudgets = new HashSet<ProjectBudget>();
        }
    
        public System.Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public System.Guid MasterBudgetCategoryId { get; set; }
    
        public virtual MasterBudgetCategory MasterBudgetCategory { get; set; }
        public virtual ICollection<PaymentVoucherBudgetLine> PaymentVoucherBudgetLines { get; set; }
        public virtual ICollection<ProjectBudget> ProjectBudgets { get; set; }
    }
}
