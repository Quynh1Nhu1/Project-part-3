using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_project.Entity;

namespace Web_project.DataSeeding
{
    public static class InsertData
    {
        public static void Seed(this ModelBuilder builder)
        {
            //var roleId1 = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            //var roleId2 = new Guid("BF60BD9D-6C87-406B-B75E-8BCF13D1F2E8");
            //var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            //var staffId = new Guid("D8128F3A-E0C7-4355-B0B4-40D339D9DB55");

            var hasher = new PasswordHasher<AppUsers>();


            builder.Entity<Products>().HasData(
                new Products()
                {
                    ProductId = 1,
                    ProductName = "ProductName1",
                    ProductDecription = "ProductDecription",
                    ProductPrice = 11,
                    ProductBrand = "ProductBrand",
                    ProductProductCode = "ProductProductCode",
                    ProductSize = "ProductSize",
                    ProductColor = "ProductColor",
                    ProductDateUpload = DateTime.Now
                },

                new Products()
                {
                    ProductId = 2,
                    ProductName = "ProductName2",
                    ProductDecription = "ProductDecription",
                    ProductPrice = 11,
                    ProductBrand = "ProductBrand",
                    ProductProductCode = "ProductProductCode",
                    ProductSize = "ProductSize",
                    ProductColor = "ProductColor",
                    ProductDateUpload = DateTime.Now
                },

                new Products()
                {
                    ProductId = 3,
                    ProductName = "ProductName3",
                    ProductDecription = "ProductDecription",
                    ProductPrice = 11,
                    ProductBrand = "ProductBrand",
                    ProductProductCode = "ProductProductCode",
                    ProductSize = "ProductSize",
                    ProductColor = "ProductColor",
                    ProductDateUpload = DateTime.Now
                },

                new Products()
                {
                    ProductId = 4,
                    ProductName = "ProductName4",
                    ProductDecription = "ProductDecription",
                    ProductPrice = 11,
                    ProductBrand = "ProductBrand",
                    ProductProductCode = "ProductProductCode",
                    ProductSize = "ProductSize",
                    ProductColor = "ProductColor",
                    ProductDateUpload = DateTime.Now
                },

                new Products()
                {
                    ProductId = 5,
                    ProductName = "ProductName5",
                    ProductDecription = "ProductDecription",
                    ProductPrice = 11,
                    ProductBrand = "ProductBrand",
                    ProductProductCode = "ProductProductCode",
                    ProductSize = "ProductSize",
                    ProductColor = "ProductColor",
                    ProductDateUpload = DateTime.Now
                },

                new Products()
                {
                    ProductId = 6,
                    ProductName = "ProductName6",
                    ProductDecription = "ProductDecription",
                    ProductPrice = 11,
                    ProductBrand = "ProductBrand",
                    ProductProductCode = "ProductProductCode",
                    ProductSize = "ProductSize",
                    ProductColor = "ProductColor",
                    ProductDateUpload = DateTime.Now
                },


                new Products()
                {
                    ProductId = 7,
                    ProductName = "ProductName7",
                    ProductDecription = "ProductDecription",
                    ProductPrice = 11,
                    ProductBrand = "ProductBrand",
                    ProductProductCode = "ProductProductCode",
                    ProductSize = "ProductSize",
                    ProductColor = "ProductColor",
                    ProductDateUpload = DateTime.Now
                },

                new Products()
                {
                    ProductId = 8,
                    ProductName = "ProductName8",
                    ProductDecription = "ProductDecription",
                    ProductPrice = 11,
                    ProductBrand = "ProductBrand",
                    ProductProductCode = "ProductProductCode",
                    ProductSize = "ProductSize",
                    ProductColor = "ProductColor",
                    ProductDateUpload = DateTime.Now
                },

                new Products()
                {
                    ProductId = 9,
                    ProductName = "ProductName9",
                    ProductDecription = "ProductDecription",
                    ProductPrice = 11,
                    ProductBrand = "ProductBrand",
                    ProductProductCode = "ProductProductCode",
                    ProductSize = "ProductSize",
                    ProductColor = "ProductColor",
                    ProductDateUpload = DateTime.Now
                },


                new Products()
                {
                    ProductId = 10,
                    ProductName = "ProductName10",
                    ProductDecription = "ProductDecription",
                    ProductPrice = 11,
                    ProductBrand = "ProductBrand",
                    ProductProductCode = "ProductProductCode",
                    ProductSize = "ProductSize",
                    ProductColor = "ProductColor",
                    ProductDateUpload = DateTime.Now
                });



            //builder.Entity<AppUsers>().HasData(
            //     new AppUsers()
            //     {
            //         Id = adminId,
            //         UserName = "admin",
            //         NormalizedUserName = "admin",
            //         Email = "admin@gmail.com",
            //         NormalizedEmail = "admin@gmail.com",
            //         EmailConfirmed = true,
            //         PasswordHash = hasher.HashPassword(null, "Aaz1234@"),
            //         SecurityStamp = string.Empty,
            //         FirstName = "Ad",
            //         LastName = "min",
            //         Dob = new DateTime(2021, 01, 31)
            //     },


                 
            //     new AppUsers()
            //     {
            //         Id = staffId,
            //         UserName = "staff",
            //         NormalizedUserName = "staff",
            //         Email = "staff@gmail.com",
            //         NormalizedEmail = "staff@gmail.com",
            //         EmailConfirmed = true,
            //         PasswordHash = hasher.HashPassword(null, "Aaz1234@"),
            //         SecurityStamp = string.Empty,
            //         FirstName = "staff",
            //         LastName = "staff",
            //         Dob = new DateTime(2021, 01, 31)
            //     }
            //    );

            //builder.Entity<AppRole>().HasData(
            //    new AppRole()
            //    {
            //        Id = roleId1,
            //        Name = "admin",
            //        NormalizedName = "admin",
            //        Description = "Administrator role"
            //    },

            //    new AppRole()
            //    {
            //        Id = roleId2,
            //        Name = "staff",
            //        NormalizedName = "staff",
            //        Description = "staff role"
            //    });

            builder.Entity<Categories>().HasData(
                new Categories()
                {
                    Id = 1,
                    SortOrder = 1,
                    CategoriesName = "CategoryName1",
                    CategoriesType = "CategoryType",
                    CategoriesSex = "woman"
                },

                new Categories()
                {
                    Id = 2,
                    SortOrder = 1,
                    CategoriesName = "CategoryName2",
                    CategoriesType = "CategoryType",
                    CategoriesSex = "man"
                },

                new Categories()
                {
                    Id = 3,
                    SortOrder = 1,
                    CategoriesName = "CategoryName3",
                    CategoriesType = "CategoryType",
                    CategoriesSex = "bede"
                });

            builder.Entity<ProductInCategories>().HasData(
                new ProductInCategories() { ProductId = 1, CategoryId = 1 },
                new ProductInCategories() { ProductId = 2, CategoryId = 2 },
                new ProductInCategories() { ProductId = 3, CategoryId = 3 },
                new ProductInCategories() { ProductId = 4, CategoryId = 1 },
                new ProductInCategories() { ProductId = 5, CategoryId = 2 },
                new ProductInCategories() { ProductId = 6, CategoryId = 3 },
                new ProductInCategories() { ProductId = 7, CategoryId = 1 },
                new ProductInCategories() { ProductId = 8, CategoryId = 1 },
                new ProductInCategories() { ProductId = 9, CategoryId = 1 },
                new ProductInCategories() { ProductId = 10, CategoryId = 1 }
                );



            //builder.Entity<IdentityUserRole<Guid>>().HasData(
            //    new IdentityUserRole<Guid>()
            //    {
            //        RoleId = roleId1,
            //        UserId = adminId
            //    },

            //    new IdentityUserRole<Guid>()
            //    {
            //        RoleId = roleId2,
            //        UserId = staffId
            //    });

        }
    }
}
