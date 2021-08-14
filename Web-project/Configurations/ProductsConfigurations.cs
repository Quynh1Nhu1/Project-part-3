using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_project.Entity;

namespace Web_project.Configurations
{
    public class ProductsConfigurations : IEntityTypeConfiguration<Products>
    {

        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(t => new { t.ProductId });

        }

    }
}
