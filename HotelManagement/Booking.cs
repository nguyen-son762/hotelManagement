//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int booking_id { get; set; }
        public Nullable<int> room_id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
    }
}
