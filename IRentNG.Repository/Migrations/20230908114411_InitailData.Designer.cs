﻿// <auto-generated />
using System;
using IRentNG.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IRentNG.Repository.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230908114411_InitailData")]
    partial class InitailData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AmenityProperty", b =>
                {
                    b.Property<int>("AmenitiesId")
                        .HasColumnType("int");

                    b.Property<Guid>("PropertiesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AmenitiesId", "PropertiesId");

                    b.HasIndex("PropertiesId");

                    b.ToTable("AmenityProperty");

                    b.HasData(
                        new
                        {
                            AmenitiesId = 2,
                            PropertiesId = new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9")
                        },
                        new
                        {
                            AmenitiesId = 3,
                            PropertiesId = new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9")
                        },
                        new
                        {
                            AmenitiesId = 4,
                            PropertiesId = new Guid("afe12c0a-880e-4559-9725-fdd49d06f91c")
                        });
                });

            modelBuilder.Entity("IRentNG.Entities.Models.Amenity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AmenityId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "None"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kitchen"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tv"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Wifi"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Washing Machine"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Air Conditioning"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Free Parking On Premises"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Dedicated Workspace"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Cinema"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Pool"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Hot Tub"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Veranda"
                        },
                        new
                        {
                            Id = 13,
                            Name = "BBQ Grill"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Pool Table"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Piano"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Exercise Equipment"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Smoke Alarm"
                        },
                        new
                        {
                            Id = 18,
                            Name = "First Aid Kit"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Fire Extinguisher"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Furnitures"
                        },
                        new
                        {
                            Id = 21,
                            Name = "24HoursElectricity"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Estate"
                        },
                        new
                        {
                            Id = 23,
                            Name = "FullyServicedEstate"
                        });
                });

            modelBuilder.Entity("IRentNG.Entities.Models.Property", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PropertyId");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Bathrooms")
                        .HasColumnType("int");

                    b.Property<int>("Bedrooms")
                        .HasColumnType("int");

                    b.Property<string>("CoverPhotoURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("Privacy")
                        .HasColumnType("int");

                    b.Property<int>("Structure")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9"),
                            Address = "123 Main Street",
                            Bathrooms = 1,
                            Bedrooms = 2,
                            CoverPhotoURL = "https://example.com/coverphoto1.jpg",
                            Description = "Description of Sample Property 1",
                            Duration = 2,
                            Price = 100.00m,
                            Privacy = 1,
                            Structure = 1,
                            Title = "Sample Property 1",
                            UserId = "579CB2F2-5256-4014-8279-08F527B7F302"
                        },
                        new
                        {
                            Id = new Guid("afe12c0a-880e-4559-9725-fdd49d06f91c"),
                            Address = "456 Elm Street",
                            Bathrooms = 1,
                            Bedrooms = 1,
                            CoverPhotoURL = "https://example.com/coverphoto2.jpg",
                            Description = "Description of Sample Property 2",
                            Duration = 4,
                            Price = 50.00m,
                            Privacy = 2,
                            Structure = 3,
                            Title = "Sample Property 2",
                            UserId = "6A5C9A15-7F19-46FF-9E1D-62D617126006"
                        });
                });

            modelBuilder.Entity("IRentNG.Entities.Models.PropertyPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PhotoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PropertyID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PropertyID");

                    b.ToTable("PropertyPhotos");
                });

            modelBuilder.Entity("IRentNG.Entities.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "579cb2f2-5256-4014-8279-08f527b7f302",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f8a42467-9e45-4e52-bb24-4fafd5e19ea6",
                            Email = "user1@example.com",
                            EmailConfirmed = true,
                            FullName = "John Doe",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@EXAMPLE.COM",
                            NormalizedUserName = "USER1@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAENwyUAfEMb+oQnrp5/lJ5jP4YnXz5ecAXS/5OjlQETk2M3PWlGeWO8ORQZnBe6UPYQ==",
                            PermanentAddress = "123 Main Street",
                            PhoneNumberConfirmed = false,
                            ProfilePicture = "https://example.com/user1.jpg",
                            SecurityStamp = "800e925b-19d6-4653-a071-2b2d594dc5ce",
                            TwoFactorEnabled = false,
                            UserName = "user1@example.com"
                        },
                        new
                        {
                            Id = "6a5c9a15-7f19-46ff-9e1d-62d617126006",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cfecabd5-04d2-430c-9ccc-c723fd157459",
                            Email = "user2@example.com",
                            EmailConfirmed = true,
                            FullName = "Jane Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER2@EXAMPLE.COM",
                            NormalizedUserName = "USER2@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEJ/Ja7X9mFmIgF/RSqqvBheJzCYkvu9SuiLf0vUqR0nV9eUTUIlSsxxGgdQ3IkqvDg==",
                            PermanentAddress = "456 Elm Street",
                            PhoneNumberConfirmed = false,
                            ProfilePicture = "https://example.com/user2.jpg",
                            SecurityStamp = "103ec15c-72b1-409c-81e4-422b947db361",
                            TwoFactorEnabled = false,
                            UserName = "user2@example.com"
                        });
                });

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

                    b.HasData(
                        new
                        {
                            Id = "70d986bf-9830-495f-80a9-b04e196dd54b",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "51e14401-6a9a-4b59-9b25-7c6c543179f2",
                            Name = "Landlord",
                            NormalizedName = "LANDLORD"
                        },
                        new
                        {
                            Id = "2fb49c49-7673-4509-994f-6a151cd70e02",
                            Name = "Tenant",
                            NormalizedName = "TENANT"
                        });
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

            modelBuilder.Entity("AmenityProperty", b =>
                {
                    b.HasOne("IRentNG.Entities.Models.Amenity", null)
                        .WithMany()
                        .HasForeignKey("AmenitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IRentNG.Entities.Models.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IRentNG.Entities.Models.Property", b =>
                {
                    b.HasOne("IRentNG.Entities.Models.User", "User")
                        .WithMany("Properties")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("IRentNG.Entities.Models.PropertyPhoto", b =>
                {
                    b.HasOne("IRentNG.Entities.Models.Property", "Property")
                        .WithMany("PropertyPhotos")
                        .HasForeignKey("PropertyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
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
                    b.HasOne("IRentNG.Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IRentNG.Entities.Models.User", null)
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

                    b.HasOne("IRentNG.Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IRentNG.Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IRentNG.Entities.Models.Property", b =>
                {
                    b.Navigation("PropertyPhotos");
                });

            modelBuilder.Entity("IRentNG.Entities.Models.User", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}