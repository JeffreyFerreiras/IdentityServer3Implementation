//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdSrv3.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScopeSecret
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTimeOffset> Expiration { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public int Scope_Id { get; set; }
    
        public virtual Scope Scope { get; set; }
    }
}
