using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_project.Entity;

namespace Web_project.Configurations
{
    public class AppUsersConfigurations : IEntityTypeConfiguration<AppUsers>
    {

        public void Configure(EntityTypeBuilder<AppUsers> builder)
        {

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Dob).IsRequired();

        }

    }
}
