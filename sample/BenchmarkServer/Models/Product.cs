﻿//-----------------------------------------------------------------------------
// <copyright file="Product.cs" company=".NET Foundation">
//      Copyright (c) .NET Foundation and Contributors. All rights reserved.
//      See License.txt in the project root for license information.
// </copyright>
//------------------------------------------------------------------------------

namespace ODataPerformanceProfile.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public Color Color { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }
        public virtual ProductDetail Detail { get; set; }
        public virtual ICollection<Supplier> ProductSuppliers { get; set; }
        public virtual ICollection<Order> ProductOrders { get; set; }     
    }

    public class ProductDetail
    {
        public string Id { get; set; }
        public string Info { get; set; }
    }

    public class Supplier
    { 
        public int Id { get; set; }
        public string Name { get; set; }  
        public string Description { get; set; }
        public Location SupplierAddress { get; set; }
    }

    public enum Color
    {
        Red,
        Green,
        Blue
    }

    public class Location
    {
        public string City { get; set; }
        public string Address { get; set; }
    }

    public class Order
    { 
        public int Id { get; set; } 
        public string OrderNo { get; set; }   
    }
}
