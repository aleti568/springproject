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
    
    public partial class roster
    {
        public roster()
        {
            this.Answers = new HashSet<Answer>();
        }
    
        public int rosterid { get; set; }
        public Nullable<int> scheduledexamid { get; set; }
        public Nullable<int> takerid { get; set; }
        public string status { get; set; }
        public string score { get; set; }
    
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual scheduled_exam scheduled_exam { get; set; }
        public virtual taker taker { get; set; }
    }
}
