//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiInMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Short_Description { get; set; }
        public string Long_Description { get; set; }
        public string Small_Image { get; set; }
        public string Large_Image { get; set; }
    }
}
