//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureLife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class reservation
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> phone { get; set; }
        public string email { get; set; }
        public Nullable<byte> people { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> eventDate { get; set; }
        public Nullable<int> eventTimeID { get; set; }
        public Nullable<int> activityID { get; set; }
        public Nullable<int> employeeID { get; set; }
    
        public virtual activity activity { get; set; }
        public virtual employee employee { get; set; }
        public virtual eventTime eventTime { get; set; }
    }
}