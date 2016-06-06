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
    
    public partial class FleetDailyManagement
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> FleetId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> StartMilleage { get; set; }
        public Nullable<double> EndMilleage { get; set; }
        public Nullable<double> DistancedCovered { get; set; }
        public Nullable<double> TotalFuelConsumed { get; set; }
        public System.Guid IncidenceId { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<System.Guid> DriverInChargeId { get; set; }
        public double FuelCost { get; set; }
    
        public virtual FleetDetail FleetDetail { get; set; }
        public virtual FleetMajorIncidence FleetMajorIncidence { get; set; }
        public virtual Staff Staff { get; set; }
    }
}