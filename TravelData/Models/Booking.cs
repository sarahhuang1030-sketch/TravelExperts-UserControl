using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelData.Models;

[Table("bookings")]
[Index("CustomerId", Name = "BookingsCustomerId")]
[Index("CustomerId", Name = "CustomersBookings")]
[Index("PackageId", Name = "PackageId")]
[Index("PackageId", Name = "PackagesBookings")]
[Index("TripTypeId", Name = "TripTypesBookings")]
public partial class Booking
{
    [Key]
    public int BookingId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BookingDate { get; set; }

    [StringLength(50)]
    public string? BookingNo { get; set; }

    public double? TravelerCount { get; set; }

    public int? CustomerId { get; set; }

    [StringLength(1)]
    public string? TripTypeId { get; set; }

    public int? PackageId { get; set; }

    [InverseProperty("Booking")]
    public virtual ICollection<Bookingdetail> Bookingdetails { get; set; } = new List<Bookingdetail>();

    [ForeignKey("CustomerId")]
    [InverseProperty("Bookings")]
    public virtual Customer? Customer { get; set; }

    [ForeignKey("PackageId")]
    [InverseProperty("Bookings")]
    public virtual Package? Package { get; set; }

    [ForeignKey("TripTypeId")]
    [InverseProperty("Bookings")]
    public virtual Triptype? TripType { get; set; }
}
