using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TravelData.Models;

public partial class TravelexpertsContext : DbContext
{
    public TravelexpertsContext()
    {
    }

    public TravelexpertsContext(DbContextOptions<TravelexpertsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Affiliation> Affiliations { get; set; }


    public virtual DbSet<Agency> Agencies { get; set; }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Bookingdetail> Bookingdetails { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Creditcard> Creditcards { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomersReward> CustomersRewards { get; set; }

    public virtual DbSet<Fee> Fees { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<PackagesProductsSupplier> PackagesProductsSuppliers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductsSupplier> ProductsSuppliers { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Reward> Rewards { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Suppliercontact> Suppliercontacts { get; set; }

    public virtual DbSet<Triptype> Triptypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseMySQL("server=localhost;port=3306;database=travelexpertssarah;user=root;password=Sarah923*@!;");

    // Connecting to Azure Database
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
               "Server=tcp:travelexperts-sql.database.windows.net,1433;" +
    "Initial Catalog=TravelExperts;" +
    "Persist Security Info=False;" +
    "User ID=sqladmin;" +
    "Password=Sarah923;" +
    "MultipleActiveResultSets=False;" +
    "Encrypt=True;" +
    "TrustServerCertificate=False;" +
    "Connection Timeout=30;"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Affiliation>(entity =>
        {
            entity.HasKey(e => e.AffilitationId).HasName("PRIMARY");
        });

        modelBuilder.Entity<Agency>(entity =>
        {
            entity.HasKey(e => e.AgencyId).HasName("PRIMARY");
        });

        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasKey(e => e.AgentId).HasName("PRIMARY");

            entity.HasOne(d => d.Agency).WithMany(p => p.Agents).HasConstraintName("agents_ibfk_1");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PRIMARY");

            entity.HasOne(d => d.Customer).WithMany(p => p.Bookings).HasConstraintName("bookings_ibfk_1");

            entity.HasOne(d => d.Package).WithMany(p => p.Bookings).HasConstraintName("bookings_ibfk_2");

            entity.HasOne(d => d.TripType).WithMany(p => p.Bookings).HasConstraintName("bookings_ibfk_3");
        });

        modelBuilder.Entity<Bookingdetail>(entity =>
        {
            entity.HasKey(e => e.BookingDetailId).HasName("PRIMARY");

            entity.HasOne(d => d.Booking).WithMany(p => p.Bookingdetails).HasConstraintName("bookingdetails_ibfk_1");

            entity.HasOne(d => d.Class).WithMany(p => p.Bookingdetails).HasConstraintName("bookingdetails_ibfk_3");

            entity.HasOne(d => d.Fee).WithMany(p => p.Bookingdetails).HasConstraintName("bookingdetails_ibfk_4");

            entity.HasOne(d => d.Region).WithMany(p => p.Bookingdetails).HasConstraintName("bookingdetails_ibfk_2");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PRIMARY");
        });

        modelBuilder.Entity<Creditcard>(entity =>
        {
            entity.HasKey(e => e.CreditCardId).HasName("PRIMARY");

            entity.HasOne(d => d.Customer).WithMany(p => p.Creditcards)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("creditcards_ibfk_1");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PRIMARY");

            entity.HasOne(d => d.Agent).WithMany(p => p.Customers).HasConstraintName("customers_ibfk_1");
        });

        modelBuilder.Entity<CustomersReward>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.RewardId }).HasName("PRIMARY");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomersRewards)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("customers_rewards_ibfk_1");

            entity.HasOne(d => d.Reward).WithMany(p => p.CustomersRewards)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("customers_rewards_ibfk_2");
        });

        modelBuilder.Entity<Fee>(entity =>
        {
            entity.HasKey(e => e.FeeId).HasName("PRIMARY");
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.PackageId).HasName("PRIMARY");
        });

        modelBuilder.Entity<PackagesProductsSupplier>(entity =>
        {
            entity.HasKey(e => new { e.PackageId, e.ProductSupplierId }).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.HasOne(d => d.Package).WithMany(p => p.PackagesProductsSuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("packages_products_suppliers_ibfk_2");

            entity.HasOne(d => d.ProductSupplier).WithMany(p => p.PackagesProductsSuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("packages_products_suppliers_ibfk_1");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");
        });

        modelBuilder.Entity<ProductsSupplier>(entity =>
        {
            entity.HasKey(e => e.ProductSupplierId).HasName("PRIMARY");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductsSuppliers).HasConstraintName("products_suppliers_ibfk_1");

            entity.HasOne(d => d.Supplier).WithMany(p => p.ProductsSuppliers).HasConstraintName("products_suppliers_ibfk_2");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PRIMARY");
        });

        modelBuilder.Entity<Reward>(entity =>
        {
            entity.HasKey(e => e.RewardId).HasName("PRIMARY");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PRIMARY");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PRIMARY");
        });

        modelBuilder.Entity<Suppliercontact>(entity =>
        {
            entity.HasKey(e => e.SupplierContactId).HasName("PRIMARY");

            entity.HasOne(d => d.Affiliation).WithMany(p => p.Suppliercontacts).HasConstraintName("suppliercontacts_ibfk_2");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Suppliercontacts).HasConstraintName("suppliercontacts_ibfk_1");
        });

        modelBuilder.Entity<Triptype>(entity =>
        {
            entity.HasKey(e => e.TripTypeId).HasName("PRIMARY");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.HasOne(d => d.Role).WithMany(p => p.Users).HasConstraintName("fk_users_roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
