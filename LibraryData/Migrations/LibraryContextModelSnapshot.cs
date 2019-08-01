﻿// <auto-generated />
using System;
using LibraryData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryData.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryData.Models.BranchHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BranchId");

                    b.Property<int>("CloseTime");

                    b.Property<int>("DayOfWork");

                    b.Property<int>("OpenTime");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("BranchHours");
                });

            modelBuilder.Entity("LibraryData.Models.Checkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LibraryAssetId");

                    b.Property<int?>("LibraryCardId");

                    b.Property<DateTime>("Since");

                    b.Property<DateTime>("Until");

                    b.HasKey("Id");

                    b.HasIndex("LibraryAssetId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("Checkouts");
                });

            modelBuilder.Entity("LibraryData.Models.CheckoutHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CheckedIn");

                    b.Property<DateTime>("CheckedOut");

                    b.Property<int>("LibraryAssetId");

                    b.Property<int>("LibraryCardId");

                    b.HasKey("Id");

                    b.HasIndex("LibraryAssetId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("CheckoutHistories");
                });

            modelBuilder.Entity("LibraryData.Models.Hold", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("HoldPlaced");

                    b.Property<int?>("LibraryAssetId");

                    b.Property<int?>("LibraryCardId");

                    b.HasKey("Id");

                    b.HasIndex("LibraryAssetId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("Holds");
                });

            modelBuilder.Entity("LibraryData.Models.LibraryAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cost");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.Property<int?>("LocationId");

                    b.Property<int>("NumberOfCopies");

                    b.Property<int>("StatusId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("StatusId");

                    b.ToTable("LibraryAssets");

                    b.HasDiscriminator<string>("Discriminator").HasValue("LibraryAsset");
                });

            modelBuilder.Entity("LibraryData.Models.LibraryBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("OpenDate");

                    b.Property<string>("Telephone")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("LibraryBranches");
                });

            modelBuilder.Entity("LibraryData.Models.LibraryCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<decimal>("Fees");

                    b.HasKey("Id");

                    b.ToTable("LibraryCards");
                });

            modelBuilder.Entity("LibraryData.Models.Patron", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<int?>("HomeLibraryBranchId");

                    b.Property<string>("LastName");

                    b.Property<int?>("LibraryCardId");

                    b.Property<string>("TelephoneNumber");

                    b.HasKey("Id");

                    b.HasIndex("HomeLibraryBranchId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("Patrons");
                });

            modelBuilder.Entity("LibraryData.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("LibraryData.Models.Book", b =>
                {
                    b.HasBaseType("LibraryData.Models.LibraryAsset");

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("DeweyIndex")
                        .IsRequired();

                    b.Property<string>("ISBN")
                        .IsRequired();

                    b.HasDiscriminator().HasValue("Book");
                });

            modelBuilder.Entity("LibraryData.Models.Video", b =>
                {
                    b.HasBaseType("LibraryData.Models.LibraryAsset");

                    b.Property<string>("Director")
                        .IsRequired();

                    b.HasDiscriminator().HasValue("Video");
                });

            modelBuilder.Entity("LibraryData.Models.BranchHours", b =>
                {
                    b.HasOne("LibraryData.Models.LibraryBranch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");
                });

            modelBuilder.Entity("LibraryData.Models.Checkout", b =>
                {
                    b.HasOne("LibraryData.Models.LibraryAsset", "LibraryAsset")
                        .WithMany()
                        .HasForeignKey("LibraryAssetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LibraryData.Models.LibraryCard", "LibraryCard")
                        .WithMany("Checkouts")
                        .HasForeignKey("LibraryCardId");
                });

            modelBuilder.Entity("LibraryData.Models.CheckoutHistory", b =>
                {
                    b.HasOne("LibraryData.Models.LibraryAsset", "LibraryAsset")
                        .WithMany()
                        .HasForeignKey("LibraryAssetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LibraryData.Models.LibraryCard", "LibraryCard")
                        .WithMany()
                        .HasForeignKey("LibraryCardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LibraryData.Models.Hold", b =>
                {
                    b.HasOne("LibraryData.Models.LibraryAsset", "LibraryAsset")
                        .WithMany()
                        .HasForeignKey("LibraryAssetId");

                    b.HasOne("LibraryData.Models.LibraryCard", "LibraryCard")
                        .WithMany()
                        .HasForeignKey("LibraryCardId");
                });

            modelBuilder.Entity("LibraryData.Models.LibraryAsset", b =>
                {
                    b.HasOne("LibraryData.Models.LibraryBranch", "Location")
                        .WithMany("LibraryAssets")
                        .HasForeignKey("LocationId");

                    b.HasOne("LibraryData.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LibraryData.Models.Patron", b =>
                {
                    b.HasOne("LibraryData.Models.LibraryBranch", "HomeLibraryBranch")
                        .WithMany("Patrons")
                        .HasForeignKey("HomeLibraryBranchId");

                    b.HasOne("LibraryData.Models.LibraryCard", "LibraryCard")
                        .WithMany()
                        .HasForeignKey("LibraryCardId");
                });
#pragma warning restore 612, 618
        }
    }
}
