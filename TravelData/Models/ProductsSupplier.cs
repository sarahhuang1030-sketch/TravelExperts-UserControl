using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelData.Models;

[Table("products_suppliers")]
[Index("ProductId", Name = "ProductId")]
[Index("ProductSupplierId", Name = "ProductSupplierId")]
[Index("SupplierId", Name = "Product_Supplier_ID")]
[Index("ProductId", Name = "ProductsProducts_Suppliers1")]
[Index("SupplierId", Name = "SuppliersProducts_Suppliers1")]
public partial class ProductsSupplier
{
    [Key]
    public int ProductSupplierId { get; set; }

    public int? ProductId { get; set; }

    public int? SupplierId { get; set; }

    [InverseProperty("ProductSupplier")]
    public virtual ICollection<PackagesProductsSupplier> PackagesProductsSuppliers { get; set; } = new List<PackagesProductsSupplier>();

    [ForeignKey("ProductId")]
    [InverseProperty("ProductsSuppliers")]
    public virtual Product? Product { get; set; }

    [ForeignKey("SupplierId")]
    [InverseProperty("ProductsSuppliers")]
    public virtual Supplier? Supplier { get; set; }
}
