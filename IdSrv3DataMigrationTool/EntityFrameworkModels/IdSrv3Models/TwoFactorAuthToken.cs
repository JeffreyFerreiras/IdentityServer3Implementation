//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdSrv3DataMigrationTool.EntityFrameworkModels.IdSrv3Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TwoFactorAuthToken
    {
        public int Key { get; set; }
        public int ParentKey { get; set; }
        public string Token { get; set; }
        public System.DateTime Issued { get; set; }
    
        public virtual UserAccount UserAccount { get; set; }
    }
}
