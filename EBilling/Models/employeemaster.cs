//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ebilling.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class employeemaster
    {
        public employeemaster()
        {
            this.ebillordermasters = new HashSet<ebillordermaster>();
            this.elabordermasters = new HashSet<elabordermaster>();
        }
    
        public int empid { get; set; }
        public string empfirstname { get; set; }
        public string emplastname { get; set; }
        public string empdateofbirth { get; set; }
        public string empdesignation { get; set; }
        public System.DateTime createddate { get; set; }
        public System.DateTime modifieddate { get; set; }
        public string deleted { get; set; }
        public int menurights { get; set; }
        public string password { get; set; }
        public int resetpassword { get; set; }
    
        public virtual ICollection<ebillordermaster> ebillordermasters { get; set; }
        public virtual ICollection<elabordermaster> elabordermasters { get; set; }
    }
}
