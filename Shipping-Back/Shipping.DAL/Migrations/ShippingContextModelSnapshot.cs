﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shipping.DAL.Data;

#nullable disable

namespace Shipping.DAL.Migrations
{
    [DbContext(typeof(ShippingContext))]
    partial class ShippingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("UserType").HasValue("ApplicationUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Pickup")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("GovernorateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.DeliverToVillage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AdditionalCost")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("DeliverToVillages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdditionalCost = 10.0
                        });
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Governorate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Governorates");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.GroupPermission", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("GroupId");

                    b.HasIndex("PermissionId");

                    b.ToTable("GroupPermissions");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("DeliverToVillage")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<string>("MerchantId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OrderShippingTotalCost")
                        .HasColumnType("float");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.Property<double>("ProductTotalCost")
                        .HasColumnType("float");

                    b.Property<int?>("ReasonsRefusalTypeId")
                        .HasColumnType("int");

                    b.Property<string>("RepresentativeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SecondPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShippingTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("orderStatus")
                        .HasColumnType("int");

                    b.Property<int>("orderType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("CityId");

                    b.HasIndex("GovernorateId");

                    b.HasIndex("MerchantId");

                    b.HasIndex("ReasonsRefusalTypeId");

                    b.HasIndex("RepresentativeId");

                    b.HasIndex("ShippingTypeId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Branch"
                        },
                        new
                        {
                            Id = 2,
                            Name = "City"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Governorate"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Employee"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Representative"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Merchant"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Order"
                        },
                        new
                        {
                            Id = 8,
                            Name = "OrderReports"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Group"
                        },
                        new
                        {
                            Id = 10,
                            Name = "ReasonsRefusalType"
                        },
                        new
                        {
                            Id = 11,
                            Name = "ShippingType"
                        },
                        new
                        {
                            Id = 12,
                            Name = "DeliverToVillage"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Weight"
                        });
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.ReasonsRefusalType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ReasonsRefusalTypes");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.RepresentativeGovernate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<string>("RepresentativeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("GovernorateId");

                    b.HasIndex("RepresentativeId");

                    b.ToTable("RepresentativeGovernates");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.ShippingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ShippingTypes");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.SpecialPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<string>("MerchentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("GovernorateId");

                    b.HasIndex("MerchentId");

                    b.ToTable("SpecialPrices");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Weight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AdditionalPrice")
                        .HasColumnType("float");

                    b.Property<double>("DefaultWeight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Weights");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdditionalPrice = 5.0,
                            DefaultWeight = 10.0
                        });
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Employee", b =>
                {
                    b.HasBaseType("Shipping.DAL.Data.Models.ApplicationUser");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasIndex("GroupId");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Merchant", b =>
                {
                    b.HasBaseType("Shipping.DAL.Data.Models.ApplicationUser");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<double?>("PickUp")
                        .HasColumnType("float");

                    b.Property<double?>("ReturnerPercent")
                        .HasColumnType("float");

                    b.Property<string>("StoreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("CityId");

                    b.HasIndex("GovernorateId");

                    b.HasDiscriminator().HasValue("Merchant");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Representative", b =>
                {
                    b.HasBaseType("Shipping.DAL.Data.Models.ApplicationUser");

                    b.Property<double?>("Amount")
                        .HasColumnType("float");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Representative");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Shipping.DAL.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Shipping.DAL.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.DAL.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Shipping.DAL.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("Shipping.DAL.Data.Models.Branch", "branch")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("branch");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.City", b =>
                {
                    b.HasOne("Shipping.DAL.Data.Models.Governorate", "Governorate")
                        .WithMany("Cities")
                        .HasForeignKey("GovernorateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governorate");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.GroupPermission", b =>
                {
                    b.HasOne("Shipping.DAL.Data.Models.Group", "Group")
                        .WithMany("GroupPermissions")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.DAL.Data.Models.Permission", "Permission")
                        .WithMany("GroupPermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Permission");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Order", b =>
                {
                    b.HasOne("Shipping.DAL.Data.Models.Branch", "Branch")
                        .WithMany("Orders")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Shipping.DAL.Data.Models.City", "City")
                        .WithMany("Orders")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.DAL.Data.Models.Governorate", "Governorate")
                        .WithMany("Orders")
                        .HasForeignKey("GovernorateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Shipping.DAL.Data.Models.Merchant", "Merchant")
                        .WithMany()
                        .HasForeignKey("MerchantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.DAL.Data.Models.ReasonsRefusalType", "ReasonsRefusalType")
                        .WithMany()
                        .HasForeignKey("ReasonsRefusalTypeId");

                    b.HasOne("Shipping.DAL.Data.Models.Representative", "Representative")
                        .WithMany()
                        .HasForeignKey("RepresentativeId");

                    b.HasOne("Shipping.DAL.Data.Models.ShippingType", "ShippingType")
                        .WithMany()
                        .HasForeignKey("ShippingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("City");

                    b.Navigation("Governorate");

                    b.Navigation("Merchant");

                    b.Navigation("ReasonsRefusalType");

                    b.Navigation("Representative");

                    b.Navigation("ShippingType");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Product", b =>
                {
                    b.HasOne("Shipping.DAL.Data.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.RepresentativeGovernate", b =>
                {
                    b.HasOne("Shipping.DAL.Data.Models.Governorate", "Governorate")
                        .WithMany()
                        .HasForeignKey("GovernorateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.DAL.Data.Models.Representative", "Representative")
                        .WithMany()
                        .HasForeignKey("RepresentativeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governorate");

                    b.Navigation("Representative");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.SpecialPrice", b =>
                {
                    b.HasOne("Shipping.DAL.Data.Models.City", "City")
                        .WithMany("SpecialPrices")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.DAL.Data.Models.Governorate", "Governorate")
                        .WithMany("SpecialPrices")
                        .HasForeignKey("GovernorateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Shipping.DAL.Data.Models.Merchant", "Merchant")
                        .WithMany()
                        .HasForeignKey("MerchentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Governorate");

                    b.Navigation("Merchant");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Employee", b =>
                {
                    b.HasOne("Shipping.DAL.Data.Models.Group", "Group")
                        .WithMany("Employees")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Merchant", b =>
                {
                    b.HasOne("Shipping.DAL.Data.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("Shipping.DAL.Data.Models.Governorate", "Governorate")
                        .WithMany()
                        .HasForeignKey("GovernorateId");

                    b.Navigation("City");

                    b.Navigation("Governorate");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Branch", b =>
                {
                    b.Navigation("ApplicationUsers");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.City", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("SpecialPrices");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Governorate", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("Orders");

                    b.Navigation("SpecialPrices");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Group", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("GroupPermissions");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Order", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Shipping.DAL.Data.Models.Permission", b =>
                {
                    b.Navigation("GroupPermissions");
                });
#pragma warning restore 612, 618
        }
    }
}
