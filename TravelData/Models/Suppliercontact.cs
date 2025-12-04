using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelData.Models;

[Table("suppliercontacts")]
[Index("AffiliationId", Name = "AffiliationsSupCon")]
[Index("SupplierId", Name = "SuppliersSupCon")]
public partial class Suppliercontact
{
    [Key]
    public int SupplierContactId { get; set; }

    [StringLength(50)]
    public string? SupConFirstName { get; set; }

    [StringLength(50)]
    public string? SupConLastName { get; set; }

    [Column(TypeName = "text")]
    public string? SupConCompany { get; set; }

    [Column(TypeName = "text")]
    public string? SupConAddress { get; set; }

    [Column(TypeName = "text")]
    public string? SupConCity { get; set; }

    [Column(TypeName = "text")]
    public string? SupConProv { get; set; }

    [Column(TypeName = "text")]
    public string? SupConPostal { get; set; }

    [Column(TypeName = "text")]
    public string? SupConCountry { get; set; }

    [StringLength(50)]
    public string? SupConBusPhone { get; set; }

    [StringLength(50)]
    public string? SupConFax { get; set; }

    [Column(TypeName = "text")]
    public string? SupConEmail { get; set; }

    [Column("SupConURL", TypeName = "text")]
    public string? SupConUrl { get; set; }

    [StringLength(10)]
    public string? AffiliationId { get; set; }

    public int? SupplierId { get; set; }

    [ForeignKey("AffiliationId")]
    [InverseProperty("Suppliercontacts")]
    public virtual Affiliation? Affiliation { get; set; }

    [ForeignKey("SupplierId")]
    [InverseProperty("Suppliercontacts")]
    public virtual Supplier? Supplier { get; set; }
}
