//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shampaz
{
    using System;
    using System.Collections.Generic;
    
    public partial class SellFactorItem
    {
        public long ProductId { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int Numbers { get; set; }
        public string Name { get; set; }
        public long SellFactorId { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual SellFactor SellFactor { get; set; }
    }
}
