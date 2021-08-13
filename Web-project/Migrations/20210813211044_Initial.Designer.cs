﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web_project.Data;

namespace Web_project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210813211044_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                            RoleId = new Guid("8d04dce2-969a-435d-bba4-df3f325983dc")
                        },
                        new
                        {
                            UserId = new Guid("d8128f3a-e0c7-4355-b0b4-40d339d9db55"),
                            RoleId = new Guid("bf60bd9d-6c87-406b-b75e-8bcf13d1f2e8")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("Web_project.Entity.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                            ConcurrencyStamp = "3ffb5434-e94d-45bf-b4a6-a96f0f4b2c70",
                            Description = "Administrator role",
                            Name = "admin",
                            NormalizedName = "admin"
                        },
                        new
                        {
                            Id = new Guid("bf60bd9d-6c87-406b-b75e-8bcf13d1f2e8"),
                            ConcurrencyStamp = "d7f93d3a-4b9c-4ad8-8171-f0968bad8ce0",
                            Description = "staff role",
                            Name = "staff",
                            NormalizedName = "staff"
                        });
                });

            modelBuilder.Entity("Web_project.Entity.AppUsers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ce2cf421-6f68-4855-8567-7987ad3154a7",
                            Dob = new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ad",
                            LastName = "min",
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEDY5IyXj7INF8SZf0vdSaS8qsVHcsY2YIasTxsuAiIjOVjUe8+AnK1lWIICrImdiDw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = new Guid("d8128f3a-e0c7-4355-b0b4-40d339d9db55"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "13d0a500-7eab-47fd-ab2a-f762f4512a04",
                            Dob = new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "staff@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "staff",
                            LastName = "staff",
                            LockoutEnabled = false,
                            NormalizedEmail = "staff@gmail.com",
                            NormalizedUserName = "staff",
                            PasswordHash = "AQAAAAEAACcQAAAAEJMyKJeymDBesW/FNa9q5WTxUJ062t1ZRLJFqTogBQ1bzwSI3Jhld/3wPOUvHY89Dw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "staff"
                        });
                });

            modelBuilder.Entity("Web_project.Entity.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("ProductId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Web_project.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategorySex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "CategoryName",
                            CategorySex = "woman",
                            CategoryType = "CategoryType",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "CategoryName",
                            CategorySex = "man",
                            CategoryType = "CategoryType",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "CategoryName",
                            CategorySex = "bede",
                            CategoryType = "CategoryType",
                            SortOrder = 1
                        });
                });

            modelBuilder.Entity("Web_project.Entity.ProductInCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInCategories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 4
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 6
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 7
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 8
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 9
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 10
                        });
                });

            modelBuilder.Entity("Web_project.Entity.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProductDateUpload")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductDecription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<string>("ProductProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductSize")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductBrand = "ProductBrand",
                            ProductColor = "ProductColor",
                            ProductDateUpload = new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(4462),
                            ProductDecription = "ProductDecription",
                            ProductName = "ProductName1",
                            ProductPrice = 11,
                            ProductProductCode = "ProductProductCode",
                            ProductSize = "ProductSize"
                        },
                        new
                        {
                            ProductId = 2,
                            ProductBrand = "ProductBrand",
                            ProductColor = "ProductColor",
                            ProductDateUpload = new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7925),
                            ProductDecription = "ProductDecription",
                            ProductName = "ProductName2",
                            ProductPrice = 11,
                            ProductProductCode = "ProductProductCode",
                            ProductSize = "ProductSize"
                        },
                        new
                        {
                            ProductId = 3,
                            ProductBrand = "ProductBrand",
                            ProductColor = "ProductColor",
                            ProductDateUpload = new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7937),
                            ProductDecription = "ProductDecription",
                            ProductName = "ProductName3",
                            ProductPrice = 11,
                            ProductProductCode = "ProductProductCode",
                            ProductSize = "ProductSize"
                        },
                        new
                        {
                            ProductId = 4,
                            ProductBrand = "ProductBrand",
                            ProductColor = "ProductColor",
                            ProductDateUpload = new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7939),
                            ProductDecription = "ProductDecription",
                            ProductName = "ProductName4",
                            ProductPrice = 11,
                            ProductProductCode = "ProductProductCode",
                            ProductSize = "ProductSize"
                        },
                        new
                        {
                            ProductId = 5,
                            ProductBrand = "ProductBrand",
                            ProductColor = "ProductColor",
                            ProductDateUpload = new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7941),
                            ProductDecription = "ProductDecription",
                            ProductName = "ProductName5",
                            ProductPrice = 11,
                            ProductProductCode = "ProductProductCode",
                            ProductSize = "ProductSize"
                        },
                        new
                        {
                            ProductId = 6,
                            ProductBrand = "ProductBrand",
                            ProductColor = "ProductColor",
                            ProductDateUpload = new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7942),
                            ProductDecription = "ProductDecription",
                            ProductName = "ProductName6",
                            ProductPrice = 11,
                            ProductProductCode = "ProductProductCode",
                            ProductSize = "ProductSize"
                        },
                        new
                        {
                            ProductId = 7,
                            ProductBrand = "ProductBrand",
                            ProductColor = "ProductColor",
                            ProductDateUpload = new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7944),
                            ProductDecription = "ProductDecription",
                            ProductName = "ProductName7",
                            ProductPrice = 11,
                            ProductProductCode = "ProductProductCode",
                            ProductSize = "ProductSize"
                        },
                        new
                        {
                            ProductId = 8,
                            ProductBrand = "ProductBrand",
                            ProductColor = "ProductColor",
                            ProductDateUpload = new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7945),
                            ProductDecription = "ProductDecription",
                            ProductName = "ProductName8",
                            ProductPrice = 11,
                            ProductProductCode = "ProductProductCode",
                            ProductSize = "ProductSize"
                        },
                        new
                        {
                            ProductId = 9,
                            ProductBrand = "ProductBrand",
                            ProductColor = "ProductColor",
                            ProductDateUpload = new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7947),
                            ProductDecription = "ProductDecription",
                            ProductName = "ProductName9",
                            ProductPrice = 11,
                            ProductProductCode = "ProductProductCode",
                            ProductSize = "ProductSize"
                        },
                        new
                        {
                            ProductId = 10,
                            ProductBrand = "ProductBrand",
                            ProductColor = "ProductColor",
                            ProductDateUpload = new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7948),
                            ProductDecription = "ProductDecription",
                            ProductName = "ProductName10",
                            ProductPrice = 11,
                            ProductProductCode = "ProductProductCode",
                            ProductSize = "ProductSize"
                        });
                });

            modelBuilder.Entity("Web_project.Entity.Cart", b =>
                {
                    b.HasOne("Web_project.Entity.AppUsers", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("Web_project.Entity.Products", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Web_project.Entity.ProductInCategory", b =>
                {
                    b.HasOne("Web_project.Entity.Category", "Category")
                        .WithMany("ProductInCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Web_project.Entity.Products", "Product")
                        .WithMany("ProductInCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Web_project.Entity.Category", b =>
                {
                    b.Navigation("ProductInCategories");
                });

            modelBuilder.Entity("Web_project.Entity.Products", b =>
                {
                    b.Navigation("ProductInCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
