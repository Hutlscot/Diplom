//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplom
{
    using System;
    using System.Collections.Generic;
    
    public partial class Relative
    {
        public int Id { get; set; }
        public string Degree { get; set; }
        public string Address { get; set; }
        public int StudentId { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
