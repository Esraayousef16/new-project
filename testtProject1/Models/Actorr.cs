//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testtProject1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Actorr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actorr()
        {
            this.Actor_in_moviee = new HashSet<Actor_in_moviee>();
            this.favourite_actorr = new HashSet<favourite_actorr>();
        }
    
        public int id { get; set; }
        public string image { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public Nullable<int> age { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actor_in_moviee> Actor_in_moviee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<favourite_actorr> favourite_actorr { get; set; }
    }
}
