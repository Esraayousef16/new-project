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
    
    public partial class Actor_in_moviee
    {
        public Nullable<int> Actor { get; set; }
        public Nullable<int> Movie { get; set; }
        public string id { get; set; }
    
        public virtual Actorr Actorr { get; set; }
        public virtual Moviee Moviee { get; set; }
    }
}