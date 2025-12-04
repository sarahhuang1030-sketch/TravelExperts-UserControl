using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelData.Models;

[Table("regions")]
public partial class Region
{
    [Key]
    [StringLength(5)]
    public string RegionId { get; set; } = null!;

    [StringLength(25)]
    public string? RegionName { get; set; }

    [InverseProperty("Region")]
    public virtual ICollection<Bookingdetail> Bookingdetails { get; set; } = new List<Bookingdetail>();
}
