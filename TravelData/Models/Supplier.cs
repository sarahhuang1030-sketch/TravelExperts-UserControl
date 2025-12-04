using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelData.Models;

[Table("suppliers")]
[Index("SupplierId", Name = "SupplierId")]
public partial class Supplier
{
    [Key]
    public int SupplierId { get; set; }

    [Column(TypeName = "text")]
    public string? SupName { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<ProductsSupplier> ProductsSuppliers { get; set; } = new List<ProductsSupplier>();

    [InverseProperty("Supplier")]
    public virtual ICollection<Suppliercontact> Suppliercontacts { get; set; } = new List<Suppliercontact>();
}
