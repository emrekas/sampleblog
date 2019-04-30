using Microsoft.EntityFrameworkCore;
using SampleBlog.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SampleBlog.Persistence.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(x => x.Status)
                .IsRequired()
                .HasColumnType("TINYINT");

            builder.Property(x => x.ContentText)
                .IsRequired()
                .HasColumnType("varchar(2000)");


            //Relations
            builder.HasOne(x => x.User)
                .WithMany(x => x.Posts)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(x => x.UserId)
                .HasConstraintName("FK_User_UserPosts");

            //Relations
            builder.HasMany(x => x.TagPosts)
                .WithOne(y => y.Post)
                .HasForeignKey(y => y.PostId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}