//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentBook
    {
        public int Id { get; set; }
        public Nullable<int> BookId { get; set; }
        public Nullable<System.DateTime> DateBorrowed { get; set; }
        public Nullable<System.DateTime> DateToReturn { get; set; }
        public Nullable<System.DateTime> DateReturned { get; set; }
        public Nullable<bool> IsReturned { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.Guid> StudentId { get; set; }
    }
}
