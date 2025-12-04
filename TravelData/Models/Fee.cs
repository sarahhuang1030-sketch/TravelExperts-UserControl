using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelData.Models;

[Table("fees")]
public partial class Fee
{
    [Key]
    [StringLength(10)]
    public string FeeId { get; set; } = null!;

    [StringLength(50)]
    public string FeeName { get; set; } = null!;

    [Precision(19, 4)]
    public decimal FeeAmt { get; set; }

    [StringLength(50)]
    public string? FeeDesc { get; set; }

    [InverseProperty("Fee")]
    public virtual ICollection<Bookingdetail> Bookingdetails { get; set; } = new List<Bookingdetail>();
}
