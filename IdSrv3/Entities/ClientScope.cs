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
    
    public partial class ClientScope
    {
        public int Id { get; set; }
        public string Scope { get; set; }
        public int Client_Id { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
