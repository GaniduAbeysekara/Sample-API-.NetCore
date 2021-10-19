using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Management.Entities.EntityConfiguration
{
    class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("subject").HasKey(s => s.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasColumnName("subject_name").IsRequired().HasColumnType("VARCHAR(255)");
            builder.Property(x => x.Code).HasColumnName("subject_code").IsRequired().HasColumnType("VARCHAR(255)");

        }
    }
}
