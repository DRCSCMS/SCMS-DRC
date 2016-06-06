﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class SCMSEntities : DbContext
    {
        public SCMSEntities()
            : base("name=SCMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AccountCode> AccountCodes { get; set; }
        public DbSet<AnnualCostProjection> AnnualCostProjections { get; set; }
        public DbSet<Approver> Approvers { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetLog> AssetLogs { get; set; }
        public DbSet<AssetManagment> AssetManagments { get; set; }
        public DbSet<AttachedDocument> AttachedDocuments { get; set; }
        public DbSet<Bin> Bins { get; set; }
        public DbSet<BinItem> BinItems { get; set; }
        public DbSet<BudgetCategory> BudgetCategories { get; set; }
        public DbSet<BudgetCommitment> BudgetCommitments { get; set; }
        public DbSet<BudgetPosting> BudgetPostings { get; set; }
        public DbSet<CheckListCategory> CheckListCategories { get; set; }
        public DbSet<CompletionCertificate> CompletionCertificates { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryProgramme> CountryProgrammes { get; set; }
        public DbSet<CountrySubOffice> CountrySubOffices { get; set; }
        public DbSet<CountrySubProgramme> CountrySubProgrammes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Depreciation> Depreciations { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentAudit> DocumentAudits { get; set; }
        public DbSet<DocumentBackDating> DocumentBackDatings { get; set; }
        public DbSet<DocumentPreparer> DocumentPreparers { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<DutyType> DutyTypes { get; set; }
        public DbSet<Equipment2Fleet> Equipment2Fleet { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<FinanceLimit> FinanceLimits { get; set; }
        public DbSet<FleetDailyManagement> FleetDailyManagements { get; set; }
        public DbSet<FleetDetail> FleetDetails { get; set; }
        public DbSet<FleetEquipment> FleetEquipments { get; set; }
        public DbSet<FleetMajorIncidence> FleetMajorIncidences { get; set; }
        public DbSet<GarageInfo> GarageInfoes { get; set; }
        public DbSet<GarageSeviceCheck> GarageSeviceChecks { get; set; }
        public DbSet<GeneralLedger> GeneralLedgers { get; set; }
        public DbSet<GoodsIssuedVoucher> GoodsIssuedVouchers { get; set; }
        public DbSet<GoodsIssuedVoucherItem> GoodsIssuedVoucherItems { get; set; }
        public DbSet<GoodsReceivedNote> GoodsReceivedNotes { get; set; }
        public DbSet<GoodsReceivedNoteItem> GoodsReceivedNoteItems { get; set; }
        public DbSet<InsuranceType> InsuranceTypes { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<ItemClassification> ItemClassifications { get; set; }
        public DbSet<ItemModel> ItemModels { get; set; }
        public DbSet<ItemPackage> ItemPackages { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<MasterBudgetCategory> MasterBudgetCategories { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<OrderRequest> OrderRequests { get; set; }
        public DbSet<OrderRequestItem> OrderRequestItems { get; set; }
        public DbSet<PaymentDossierDocument> PaymentDossierDocuments { get; set; }
        public DbSet<PaymentRequest> PaymentRequests { get; set; }
        public DbSet<PaymentRequestBudgetLine> PaymentRequestBudgetLines { get; set; }
        public DbSet<PaymentTerm> PaymentTerms { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<PaymentVoucher> PaymentVouchers { get; set; }
        public DbSet<PaymentVoucherBudgetLine> PaymentVoucherBudgetLines { get; set; }
        public DbSet<PermissionRecord> PermissionRecords { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<ProcurementPlan> ProcurementPlans { get; set; }
        public DbSet<ProcurementPlanItem> ProcurementPlanItems { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectBudget> ProjectBudgets { get; set; }
        public DbSet<ProjectDonor> ProjectDonors { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderDocument> PurchaseOrderDocuments { get; set; }
        public DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public DbSet<Rebooking> Rebookings { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermissionRecord> RolePermissionRecords { get; set; }
        public DbSet<ServiceCheckList> ServiceCheckLists { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<ShippingTerm> ShippingTerms { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SystemPrivilege> SystemPrivileges { get; set; }
        public DbSet<SystemRolePrivilege> SystemRolePrivileges { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<SystemUserRole> SystemUserRoles { get; set; }
        public DbSet<TenderingType> TenderingTypes { get; set; }
        public DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
        public DbSet<VehicleMake> VehicleMakes { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<WareHouse> WareHouses { get; set; }
        public DbSet<WarehouseRelease> WarehouseReleases { get; set; }
        public DbSet<WarehouseReleaseItem> WarehouseReleaseItems { get; set; }
        public DbSet<WayBill> WayBills { get; set; }
        public DbSet<GenralInventory> GenralInventories { get; set; }
        public DbSet<InventoryQTY> InventoryQTies { get; set; }
        public DbSet<V_BudgetPipeline> V_BudgetPipeline { get; set; }
        public DbSet<V_BudgetPipeLineReport> V_BudgetPipeLineReport { get; set; }
        public DbSet<V_DocumentStatus> V_DocumentStatus { get; set; }
        public DbSet<VBudgetDetail> VBudgetDetails { get; set; }
        public DbSet<VProjectDonor> VProjectDonors { get; set; }
        public DbSet<VStaffDetail> VStaffDetails { get; set; }
    
        public virtual ObjectResult<BINCARDPDF_Result> BINCARDPDF(string refNo)
        {
            var refNoParameter = refNo != null ?
                new ObjectParameter("RefNo", refNo) :
                new ObjectParameter("RefNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BINCARDPDF_Result>("BINCARDPDF", refNoParameter);
        }
    
        public virtual ObjectResult<GIVPDF_Result> GIVPDF(string refNo)
        {
            var refNoParameter = refNo != null ?
                new ObjectParameter("RefNo", refNo) :
                new ObjectParameter("RefNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GIVPDF_Result>("GIVPDF", refNoParameter);
        }
    
        public virtual ObjectResult<GRNPDF_Result> GRNPDF(string refNo)
        {
            var refNoParameter = refNo != null ?
                new ObjectParameter("RefNo", refNo) :
                new ObjectParameter("RefNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GRNPDF_Result>("GRNPDF", refNoParameter);
        }
    
        public virtual ObjectResult<OrderRequestPDF_Result> OrderRequestPDF(string refNo)
        {
            var refNoParameter = refNo != null ?
                new ObjectParameter("RefNo", refNo) :
                new ObjectParameter("RefNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OrderRequestPDF_Result>("OrderRequestPDF", refNoParameter);
        }
    
        public virtual ObjectResult<POPDFPROC_Result> POPDFPROC(string refNo)
        {
            var refNoParameter = refNo != null ?
                new ObjectParameter("RefNo", refNo) :
                new ObjectParameter("RefNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<POPDFPROC_Result>("POPDFPROC", refNoParameter);
        }
    
        public virtual ObjectResult<ProcurementPlanPDF_Result> ProcurementPlanPDF(string refNo)
        {
            var refNoParameter = refNo != null ?
                new ObjectParameter("RefNo", refNo) :
                new ObjectParameter("RefNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProcurementPlanPDF_Result>("ProcurementPlanPDF", refNoParameter);
        }
    
        public virtual ObjectResult<STOCKCARDPDF_Result> STOCKCARDPDF(string refNo)
        {
            var refNoParameter = refNo != null ?
                new ObjectParameter("RefNo", refNo) :
                new ObjectParameter("RefNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STOCKCARDPDF_Result>("STOCKCARDPDF", refNoParameter);
        }
    
        public virtual ObjectResult<WROPDF_Result> WROPDF(string refNo)
        {
            var refNoParameter = refNo != null ?
                new ObjectParameter("RefNo", refNo) :
                new ObjectParameter("RefNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<WROPDF_Result>("WROPDF", refNoParameter);
        }
    }
}
