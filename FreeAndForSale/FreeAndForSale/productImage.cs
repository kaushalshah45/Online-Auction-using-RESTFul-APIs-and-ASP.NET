//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreeAndForSale
{
    using System;
    using System.Collections.Generic;
    
    public partial class productImage
    {
        public int productID { get; set; }
        public byte[] Image1 { get; set; }
        public byte[] Image2 { get; set; }
    
        public virtual product product { get; set; }
    }
}