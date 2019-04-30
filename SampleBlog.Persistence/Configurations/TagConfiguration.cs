using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleBlog.Domain.Entities;

namespace SampleBlog.Persistence.Configurations
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnType("varchar(30)");

            //Navigations
            builder.HasMany(x => x.TagPosts)
                .WithOne(y => y.Tag)
                .HasForeignKey(y => y.TagId);

        }
    }
}
