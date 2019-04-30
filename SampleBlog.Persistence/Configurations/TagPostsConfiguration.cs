using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleBlog.Domain.Entities;

namespace SampleBlog.Persistence.Configurations
{
    public class TagPostsConfiguration : IEntityTypeConfiguration<TagPost>
    {
        public void Configure(EntityTypeBuilder<TagPost> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Post)
                .WithMany(y => y.TagPosts)
                .HasForeignKey(x => x.PostId);

            builder.HasOne(x => x.Tag)
                .WithMany(y => y.TagPosts)
                .HasForeignKey(x => x.TagId);
        }
    }
}
