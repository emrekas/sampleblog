using System.Collections.Generic;

namespace SampleBlog.Domain.Entities
{
    public class Tag
    {
        public Tag() => TagPosts = new HashSet<TagPost>();
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TagPost> TagPosts { get; set; }
    }
}