using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF01.Configurations
{
    class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);
            builder.Property(D => D.HiringDate).HasComputedColumnSql("GETDATE()");

            builder.HasMany(D => D.instructors)
                   .WithOne(i => i.WorkForDepartment)
                   .IsRequired(false)
                   .HasForeignKey(i => i.Dept_id)
                   .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
