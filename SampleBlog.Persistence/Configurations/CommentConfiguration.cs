using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleBlog.Domain.Entities;

namespace SampleBlog.Persistence.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Author)
                .HasColumnType("varchar(80)");
            builder.Property(x => x.ContentText)
                .HasColumnType("varchar(360)");
            builder.Property(x => x.Email)
                .HasColumnType("varchar(50)");
            builder.Property(x => x.Status)
                .HasColumnType("TINYINT");

            builder.HasOne(x => x.Post)
                .WithMany(y => y.Comments)
                .HasForeignKey(x => x.PostId);
        }
    }
}
