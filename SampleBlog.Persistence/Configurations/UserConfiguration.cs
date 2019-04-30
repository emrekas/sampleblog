using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleBlog.Domain.Entities;

namespace SampleBlog.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Password)
                .HasColumnType("nvarchar(25)");

            builder.Property(x => x.ProfilePhoto)
                .HasColumnType("nvarchar(300)");

            builder.Property(x => x.Username)
                .HasColumnType("nvarchar(30)");

            builder.Property(x => x.Email)
                .HasColumnType("varchar(50)");

            //Navigations
            builder.HasMany(x => x.Posts)
                .WithOne(y => y.User)
                .HasForeignKey(x => x.UserId);
        }
    }
}
