//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA46Team10Bsports
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourtTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CourtTable()
        {
            this.TransactionTables = new HashSet<TransactionTable>();
        }
    
        public int CourtID { get; set; }
        public string CourtType { get; set; }
        public string SportsType { get; set; }
        public Nullable<System.DateTime> MaintDate { get; set; }
        public string Remarks { get; set; }
        public string Flag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionTable> TransactionTables { get; set; }
    }
}
