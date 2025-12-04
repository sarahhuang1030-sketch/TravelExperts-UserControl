using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelData.Models;

[Table("bookingdetails")]
[Index("FeeId", Name = "Agency_Fee_Code")]
[Index("BookingId", Name = "BookingId")]
[Index("BookingId", Name = "BookingsBookingDetails")]
[Index("ClassId", Name = "ClassesBookingDetails")]
[Index("RegionId", Name = "Dest_ID")]
[Index("RegionId", Name = "DestinationsBookingDetails")]
[Index("FeeId", Name = "FeesBookingDetails")]
[Index("ProductSupplierId", Name = "ProductSupplierId")]
[Index("ProductSupplierId", Name = "Products_SuppliersBookingDetails")]
public partial class Bookingdetail
{
    [Key]
    public int BookingDetailId { get; set; }

    public double? ItineraryNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TripStart { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TripEnd { get; set; }

    [Column(TypeName = "text")]
    public string? Description { get; set; }

    [Column(TypeName = "text")]
    public string? Destination { get; set; }

    [Precision(19, 4)]
    public decimal? BasePrice { get; set; }

    [Precision(19, 4)]
    public decimal? AgencyCommission { get; set; }

    public int? BookingId { get; set; }

    [StringLength(5)]
    public string? RegionId { get; set; }

    [StringLength(5)]
    public string? ClassId { get; set; }

    [StringLength(10)]
    public string? FeeId { get; set; }

    public int? ProductSupplierId { get; set; }

    [ForeignKey("BookingId")]
    [InverseProperty("Bookingdetails")]
    public virtual Booking? Booking { get; set; }

    [ForeignKey("ClassId")]
    [InverseProperty("Bookingdetails")]
    public virtual Class? Class { get; set; }

    [ForeignKey("FeeId")]
    [InverseProperty("Bookingdetails")]
    public virtual Fee? Fee { get; set; }

    [ForeignKey("RegionId")]
    [InverseProperty("Bookingdetails")]
    public virtual Region? Region { get; set; }
}
