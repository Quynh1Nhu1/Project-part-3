using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Web_project.Configurations;
using Web_project.Entity;

namespace Web_project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            // Bỏ tiền tố AspNet của các bảng: mặc định các bảng trong IdentityDbContext có
            // tên với tiền tố AspNet như: AspNetUserRoles, AspNetUser ...
            // Đoạn mã sau chạy khi khởi tạo DbContext, tạo database sẽ loại bỏ tiền tố đó
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }


            builder.ApplyConfiguration(new AppRoleConfigurations());
            builder.ApplyConfiguration(new AppUsersConfigurations());

            builder.ApplyConfiguration(new CategoriesConfigurations());
            builder.ApplyConfiguration(new ProductInCategoriesConfigurations());
            builder.ApplyConfiguration(new ProductsConfigurations());






        }
        public DbSet<AppRole> AppRole { set; get; }
        public DbSet<AppUsers> AppUsers { set; get; }
        public DbSet<Cart> Cart { set; get; }
        public DbSet<Categories> Categories { set; get; }
        public DbSet<ProductInCategories> ProductInCategories { set; get; }
        public DbSet<Products> Products { set; get; }


    }

}
