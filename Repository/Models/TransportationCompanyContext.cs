using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models;

public partial class TransportationCompanyContext : DbContext
{
    public TransportationCompanyContext()
    {
    }

    public TransportationCompanyContext(DbContextOptions<TransportationCompanyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CarsTable> CarsTables { get; set; }

    public virtual DbSet<DriverTable> DriverTables { get; set; }

    public virtual DbSet<GarageTable> GarageTables { get; set; }

    public virtual DbSet<OccasionalCustomersTable> OccasionalCustomersTables { get; set; }

    public virtual DbSet<OccasionalTravelTable> OccasionalTravelTables { get; set; }

    public virtual DbSet<RegularCustomerTable> RegularCustomerTables { get; set; }

    public virtual DbSet<RegularTravelTable> RegularTravelTables { get; set; }

    public virtual DbSet<StationTable> StationTables { get; set; }

    public virtual DbSet<TravelTimeSystem> TravelTimeSystems { get; set; }

    public virtual DbSet<VehicleRepairsTable> VehicleRepairsTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-NHIB2FA6;Initial Catalog=Transportation company;Integrated Security=True;Trusted_Connection=True;trustservercertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarsTable>(entity =>
        {
            entity.HasKey(e => e.CodeCar);

            entity.ToTable("CarsTable");

            entity.Property(e => e.CompanyCar).HasMaxLength(50);
            entity.Property(e => e.NumPlaces).HasColumnName("Num_Places");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<DriverTable>(entity =>
        {
            entity.HasKey(e => e.DriverCode);

            entity.ToTable("DriverTable");

            entity.Property(e => e.DriverId).HasMaxLength(50);
            entity.Property(e => e.DriverName).HasMaxLength(50);
            entity.Property(e => e.DriverTel).HasMaxLength(50);
            entity.Property(e => e.LicenseType).HasMaxLength(50);
        });

        modelBuilder.Entity<GarageTable>(entity =>
        {
            entity.HasKey(e => e.GarageCode);

            entity.ToTable("Garage_Table");

            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.GarageName).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<OccasionalCustomersTable>(entity =>
        {
            entity.ToTable("Occasional_Customers_table");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<OccasionalTravelTable>(entity =>
        {
            entity.HasKey(e => e.OccasionalTravelCode);

            entity.ToTable("Occasional_travel_Table");

            entity.Property(e => e.OccasionalTravelCode).HasColumnName("Occasional_travel_Code");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Target).HasMaxLength(50);

            entity.HasOne(d => d.CarCodeNavigation).WithMany(p => p.OccasionalTravelTables)
                .HasForeignKey(d => d.CarCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Occasional_travel_Table_CarsTable");

            entity.HasOne(d => d.CustomercodeNavigation).WithMany(p => p.OccasionalTravelTables)
                .HasForeignKey(d => d.Customercode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Occasional_travel_Table_Occasional_Customers_table");

            entity.HasOne(d => d.DriverCodeNavigation).WithMany(p => p.OccasionalTravelTables)
                .HasForeignKey(d => d.DriverCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Occasional_travel_Table_DriverTable");
        });

        modelBuilder.Entity<RegularCustomerTable>(entity =>
        {
            entity.HasKey(e => e.RegularCustomerCode);

            entity.ToTable("Regular_Customer_Table");

            entity.Property(e => e.RegularCustomerCode).HasColumnName("Regular_Customer_Code");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.HP)
                .HasMaxLength(50)
                .HasColumnName("H.P");
            entity.Property(e => e.InstutitionName)
                .HasMaxLength(50)
                .HasColumnName("Instutition_Name");
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<RegularTravelTable>(entity =>
        {
            entity.HasKey(e => e.CodeTravel);

            entity.ToTable("Regular_ travel_Table");

            entity.Property(e => e.CollectionPoint).HasMaxLength(50);
            entity.Property(e => e.Target).HasMaxLength(50);

            entity.HasOne(d => d.CodeCarNavigation).WithMany(p => p.RegularTravelTables)
                .HasForeignKey(d => d.CodeCar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Regular_ travel_Table_CarsTable");

            entity.HasOne(d => d.CodeCustonerNavigation).WithMany(p => p.RegularTravelTables)
                .HasForeignKey(d => d.CodeCustoner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Regular_ travel_Table_Regular_Customer_Table");

            entity.HasOne(d => d.DriverCodeNavigation).WithMany(p => p.RegularTravelTables)
                .HasForeignKey(d => d.DriverCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Regular_ travel_Table_DriverTable");

            entity.HasOne(d => d.TravelStsationCodeNavigation).WithMany(p => p.RegularTravelTables)
                .HasForeignKey(d => d.TravelStsationCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Regular_ travel_Table_StationTable");

            entity.HasOne(d => d.TravelTimesCodeNavigation).WithMany(p => p.RegularTravelTables)
                .HasForeignKey(d => d.TravelTimesCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Regular_ travel_Table_Travel_time_system");
        });

        modelBuilder.Entity<StationTable>(entity =>
        {
            entity.ToTable("StationTable");

            entity.Property(e => e.IndexStation).HasColumnName("indexStation");
            entity.Property(e => e.StationAddress).HasMaxLength(50);
            entity.Property(e => e.X)
                .HasMaxLength(50)
                .HasColumnName("x");
            entity.Property(e => e.Y)
                .HasMaxLength(50)
                .HasColumnName("y");
        });

        modelBuilder.Entity<TravelTimeSystem>(entity =>
        {
            entity.ToTable("Travel_time_system");

            entity.Property(e => e.LeavingTime)
                .HasMaxLength(50)
                .HasColumnName("leavingTime");
        });

        modelBuilder.Entity<VehicleRepairsTable>(entity =>
        {
            entity.HasKey(e => e.ActionCode);

            entity.ToTable("Vehicle_repairs_Table");

            entity.Property(e => e.EnterDate).HasColumnType("date");
            entity.Property(e => e.ExitDate).HasColumnType("date");

            entity.HasOne(d => d.CarCodeNavigation).WithMany(p => p.VehicleRepairsTables)
                .HasForeignKey(d => d.CarCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vehicle_repairs_Table_CarsTable");

            entity.HasOne(d => d.GarageCodeNavigation).WithMany(p => p.VehicleRepairsTables)
                .HasForeignKey(d => d.GarageCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vehicle_repairs_Table_Garage_Table");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
