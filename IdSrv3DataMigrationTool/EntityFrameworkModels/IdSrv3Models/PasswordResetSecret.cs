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
    
    public partial class PasswordResetSecret
    {
        public int Key { get; set; }
        public int ParentKey { get; set; }
        public System.Guid PasswordResetSecretID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    
        public virtual UserAccount UserAccount { get; set; }
    }
}
