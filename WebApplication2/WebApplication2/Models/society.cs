//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class society
    {
        public society()
        {
            this.sponsors = new HashSet<sponsor>();
        }
    
        public int societyid { get; set; }
        public string shortname { get; set; }
        public string longname { get; set; }
    
        public virtual ICollection<sponsor> sponsors { get; set; }
    }
}
