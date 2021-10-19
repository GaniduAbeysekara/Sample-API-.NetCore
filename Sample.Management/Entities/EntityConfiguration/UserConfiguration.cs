using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.Management.Entities;

namespace Sample.Management.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user").HasKey(x => x.Id);
            builder.Property(x=>x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasColumnName("name").IsRequired().HasColumnType("VARCHAR(255)");
            builder.Property(x => x.Email).HasColumnName("email").IsRequired().HasColumnType("VARCHAR(255)");
        }
    }
}
