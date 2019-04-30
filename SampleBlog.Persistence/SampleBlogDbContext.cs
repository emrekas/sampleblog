using Microsoft.EntityFrameworkCore;
using SampleBlog.Domain.Entities;

namespace SampleBlog.Persistence
{
    public class SampleBlogDbContext : DbContext
    {
        public SampleBlogDbContext(DbContextOptions<SampleBlogDbContext> options) : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TagPost> TagPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SampleBlogDbContext).Assembly);
        }
    }
}
