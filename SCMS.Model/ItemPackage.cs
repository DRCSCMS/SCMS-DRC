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
    
    public partial class ItemPackage
    {
        public ItemPackage()
        {
            this.Bins = new HashSet<Bin>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ItemId { get; set; }
        public string shortName { get; set; }
        public string Name { get; set; }
        public int PackSize { get; set; }
    
        public virtual ICollection<Bin> Bins { get; set; }
        public virtual Item Item { get; set; }
    }
}
