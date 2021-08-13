using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_project.Entity;

namespace Web_project.Configurations
{
    public class UserrConfigurations : IEntityTypeConfiguration<Userr>
    {


        public void Configure(EntityTypeBuilder<Userr> builder)
        {
            builder.HasKey(t => new { t.UserId });

          

        }

    }
}
