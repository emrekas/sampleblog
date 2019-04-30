using System;
using System.Collections.Generic;
using System.Text;

namespace SampleBlog.Domain.Entities
{
    public class Post
    {
        public Post()
        {
            TagPosts = new HashSet<TagPost>();
            Comments=new HashSet<Comment>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string ContentText { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; }

        //relations
        public virtual ICollection<TagPost> TagPosts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public User User { get; set; }
    }
}